using APIREST.MongoDB.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIREST.MongoDB.Repositories
{
    public interface ITVProgramCollection
    {
        Task InsertTVProgram(TVProgram program);
        Task UpdateTVProgram(TVProgram program);
        Task DeleteTVProgram(string id);
        Task<List<TVProgram>> GetAllTVPrograms();
        Task<TVProgram> GetTVProgramById(string id);

    }
}
