using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using MicrogreensTrayApi.Models;
namespace MicrogreensTrayApi.Services

{
    public class TrayService
    {
        private readonly IMongoCollection<Tray> _trays;
        public TrayService(IGreenBoxFarmDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _trays = database.GetCollection<Tray>(settings.GreenBoxFarmCollectionName);
        }

        public List<Tray> Get() =>
        _trays.Find(tray => true).ToList();

        public Tray Get(string id) =>
        _trays.Find<Tray>(tray => tray.Id == id).FirstOrDefault();

        public Tray Create(Tray tray)
        {
            _trays.InsertOne(tray);
            return tray;
        }

        public void Update(string id, Tray trayInput)
        {
            _trays.ReplaceOne(tray => tray.Id == id, trayInput);
        }

        public void Remove(Tray trayInput)
        {
            _trays.DeleteOne(tray => tray.Id == trayInput.Id);
        }

        public void Remove(string id)
        {
            _trays.DeleteOne(book => book.Id == id);
        }
    }
}