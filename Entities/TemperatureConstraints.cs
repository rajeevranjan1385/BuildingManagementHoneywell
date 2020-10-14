namespace API.Entities
{
    public class TemperatureConstraints
    {
        public int Id { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public bool IsPersonAvailable { get; set; }
    }
}