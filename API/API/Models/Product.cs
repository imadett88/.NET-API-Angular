using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace API.Models
{
    public class Product
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("Name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("Number")]
        public int Number { get; set; }

        [BsonElement("Comp")]
        public string Comp { get; set; } = string.Empty;
    }
}
