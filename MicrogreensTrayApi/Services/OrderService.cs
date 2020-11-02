using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using MicrogreensTrayApi.Models;
using System;
namespace MicrogreensTrayApi.Services
{
    public class OrderService
    {
        private readonly IMongoCollection<Tray> _trays;
        public OrderService(IGreenBoxFarmDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _trays = database.GetCollection<Tray>(settings.GreenBoxFarmCollectionName);
        }

        public List<Tray> Get()
        {
            var filter = Builders<Tray>.Filter.Eq(t => t.OrderInformation.IsPreordered, true);

            // var projectionFilter = Builders<Tray>.Projection
            // .Include(t => t.OrderInformation.CustomerInformation)
            // .Include(t => t.SeedInformation.Name)
            // .Include(t => t.OrderInformation.OrderDate)
            // .Include(t => t.OrderInformation.DueDate);

            // var sortDescending = Builders<Tray>.Sort.Ascending(t => t.OrderInformation.DueDate);

            var orders = _trays
            .Find(filter)
            .ToList();

            return orders;
        }

        public List<Tray> GetInv()
        {
            var filter = Builders<Tray>.Filter.Eq(t => t.OrderInformation.IsPreordered, false);

            var orders = _trays
            .Find(filter)
            .ToList();

            return orders;
        }

    }
}