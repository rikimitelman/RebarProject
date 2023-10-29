using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ReabrProject.Models
{
    [BsonIgnoreExtraElements]
    public class Shake
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("SPrice")]
        public int SPrice { get; set; }
        [BsonElement("MPrice")]
        public int MPrice { get; set; }
        [BsonElement("LPrice")]
        public int LPrice { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid ShakeId = Guid.NewGuid();
    }
}
