using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using MicrogreensTrayApi.Models;
namespace MicrogreensTrayApi.Models

{
    public class Tray
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public SeedInfo SeedInformation { get; set; }
        public Orders OrderInformation { get; set; }
        public int SeedingRate { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime PlantedDate { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime HarvestDate { get; set; }
        public int DaysUnderWeight { get; set; }
        public int DaysUnderBlackOut { get; set; }
        public int HarvestWeight { get; set; }


        public Tray()
        {
            this.PlantedDate = DateTime.Today;
        }
    }
}