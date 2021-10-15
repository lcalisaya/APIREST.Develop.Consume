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
            //Create a filter and then delete it 
            var filter = Builders<TVProgram>.Filter.Eq(tvp => tvp.Id, new ObjectId(idDocument));
            await Collection.DeleteOneAsync(filter);
        }

        public async Task<List<TVProgram>> GetAllTVPrograms()
        {
            //Find all documents according object sent and convert them to a list
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<TVProgram> GetTVProgramById(string id)
        {
            //Get just the document that matches the id sent
            return await Collection.FindAsync(new BsonDocument() {{ "_id", new ObjectId(id) }}).Result.FirstAsync();
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
