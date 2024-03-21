using Microsoft.Extensions.Options;
using MongoDB.Driver;
using API.Data;
using API.Models;


namespace API.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _productCollection;

        public ProductService(IOptions<DbSettings> dbSettings)
        {
            // initialize mongo client :
            var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);

            // connect to db:
            var mongodb = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);

            // connect to collection :
            _productCollection = mongodb.GetCollection<Product>(dbSettings.Value.CollectionName);
        }

        public async Task<List<Product>> GetAsyncProducts() =>
             // _ => : Lambda unction
             await _productCollection.Find(_ => true).ToListAsync();

    }
}
