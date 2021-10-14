using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APIREST.MongoDB.Models
{
    public class TVProgram
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Driver { get; set; }
        public string Gender { get; set; }
        public string Schedule { get; set; }
        public string TVChannel { get; set; }
        public bool ThereAreGuests { get; set; }
        public bool IsLiveBroadcast { get; set; }
    }
}
