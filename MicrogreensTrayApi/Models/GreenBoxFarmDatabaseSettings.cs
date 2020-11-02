namespace MicrogreensTrayApi.Models
{
    public class GreenBoxFarmDatabaseSettings : IGreenBoxFarmDatabaseSettings
    {
        public string GreenBoxFarmCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
    }
    public interface IGreenBoxFarmDatabaseSettings
    {
        string GreenBoxFarmCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }
    }
}