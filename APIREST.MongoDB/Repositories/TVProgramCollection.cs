using APIREST.MongoDB.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIREST.MongoDB.Repositories
{
    public class TVProgramCollection : ITVProgramCollection
    {
        internal MongoDBRepository _repository = new MongoDBRepository();
        private readonly IMongoCollection<TVProgram> Collection;
        public TVProgramCollection()
        {
            Collection = _repository.Database.GetCollection<TVProgram>("TVPrograms");
        }
        public async Task DeleteTVProgram(string idDocument)
        {
            var filter = Builders<TVProgram>.Filter.Eq(tvp => tvp.Id, new ObjectId(idDocument));
            await Collection.DeleteOneAsync(filter);
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
