using APIREST.MongoDB.Models;
using APIREST.MongoDB.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace APIREST.MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVProgramController : Controller
    {
        private readonly ITVProgramCollection _database;

        public TVProgramController(ITVProgramCollection database)
        {
            _database = database;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTVPrograms()
        {
            return Ok(await _database.GetAllTVPrograms());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneTVProgram(string id)
        {
            return Ok(await _database.GetTVProgramById(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertTVProgram([FromBody] TVProgram program)
        {
            if(program == null)
                return BadRequest();
            if (program.Name == string.Empty)
                ModelState.AddModelError("Name", "TV Program should be sent");

            await _database.InsertTVProgram(program);
            return Created("TV Program created", true);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTVProgram([FromBody] TVProgram program, string id)
        {
            if (program == null)
                return BadRequest();
            if (program.Name == string.Empty)
                ModelState.AddModelError("Name", "TV Program should be sent");

            program.Id = new ObjectId(id);
            await _database.UpdateTVProgram(program);
            return Created("TV Program created", true);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTVProgram(string id)
        {
            await _database.DeleteTVProgram(id);
            return NoContent();
        }
    }
}
