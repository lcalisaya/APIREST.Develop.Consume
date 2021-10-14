using APIREST.MongoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIREST.MongoDB.Repositories
{
    public class TVProgramCollection : ITVProgramCollection
    {
        public Task DeleteTVProgram(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TVProgram>> GetAllTVPrograms()
        {
            throw new NotImplementedException();
        }

        public Task<TVProgram> GetTVProgramById(string id)
        {
            throw new NotImplementedException();
        }

        public Task InsertTVProgram(TVProgram program)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTVProgram(TVProgram program)
        {
            throw new NotImplementedException();
        }
    }
}
