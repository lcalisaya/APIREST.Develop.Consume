using MongoDB.Driver;

namespace APIREST.MongoDB.Repositories
{
    public class MongoDBRepository
    {
        public MongoClient Client { get; set; }
        public IMongoDatabase Database { get; set; }
        public MongoDBRepository()
        {
            Client = new MongoClient("mongodb://127.0.0.1:27017");
            Database = Client.GetDatabase("TVPrograms");
        }
    }
}
