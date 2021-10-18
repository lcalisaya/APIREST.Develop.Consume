using APIREST.MongoDB.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace APIREST.MongoDB.UI.Controllers
{
    public class ProgramController : Controller
    {
        private readonly HttpClient _httpClient;
        public ProgramController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:44394");
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task DeleteTVProgram(string id)
        {
            await _httpClient.DeleteAsync($"api/TVProgram/{id}");
        }
        public async Task<IActionResult> GetAllTVPrograms()
        {
            var tvprograms = await JsonSerializer.DeserializeAsync<IEnumerable<TVProgram>>
                (await _httpClient.GetStreamAsync("api/TVProgram/"),
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return View(tvprograms);
        }

        public async Task<TVProgram> GetTVProgramDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<TVProgram>
                (await _httpClient.GetStreamAsync($"api/TVProgram/{id}"),
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public IActionResult CreateTVProgram() 
        {
            return View();
        }

        public async Task SaveTVProgram(TVProgram tvprogram)
        {
            var productJson = new StringContent(JsonSerializer.Serialize(tvprogram),
                                                Encoding.UTF8, "application/json");
            if (tvprogram.Id == string.Empty)
            {
                await _httpClient.PostAsync("api/TVProgram", productJson);
            } else {
                await _httpClient.PutAsync($"api/TVProgram/{tvprogram.Id}", productJson);
            }
        }
    }
}
