using APIREST.MongoDB.Data;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
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
            var filter = Builders<TVProgram>.Filter.Eq(tvp => tvp.Id, idDocument);
            await Collection.DeleteOneAsync(filter);
        }

        public async Task<List<TVProgram>> GetAllTVPrograms()
        {
            //Find all documents according object sent and convert them to a list
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<TVProgram> GetTVProgramById(string idDocument)
        {
            //Get just the document that matches the id sent
            return await Collection.FindAsync(new BsonDocument() {{ "_id", new ObjectId(idDocument) }}).Result.FirstAsync();
        }

        public async Task InsertTVProgram(TVProgram program)
        {
            //Insert directly the program sent
            await Collection.InsertOneAsync(program);
        }

        public async Task UpdateTVProgram(TVProgram program)
        {
            //Create a filter
            var filter = Builders<TVProgram>.Filter.Eq(doc => doc.Id, program.Id);

            //Only set the fields which will be updated
            //var fieldsToUpdate = Builders<TVProgram>.Update.Set(doc => doc.Name, program.Name)
                                                        //.Set(doc => doc.Schedule, program.Schedule)
                                                        //.Set(doc => doc.Driver, program.Driver)
                                                        //.Set(doc => doc.Gender, program.Gender)
                                                        //.Set(doc => doc.TVChannel, program.TVChannel)
                                                        //.Set(doc => doc.ThereAreGuests, program.ThereAreGuests)
                                                        //.Set(doc => doc.IsLiveBroadcast, program.IsLiveBroadcast);


            //Replace the filtered document with the document sent
            //await Collection.UpdateOneAsync(filter, fieldsToUpdate);

            //Replace all the key:values of the document
            await Collection.ReplaceOneAsync(filter, program); 

        }
    }
}
