using Newtonsoft.Json;

namespace WebApplication14.Models
{
    public class Main
    {
        public float Temp { get; set; }
        [JsonProperty("feels_like")]
        public float FeelsLike { get; set; }
        [JsonProperty("temp_min")]
        public float TempMin { get; set; }
        [JsonProperty("temp_max")]
        public float TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int SeaLevel { get; set; }
        public int GrndLevel { get; set; }
    }
}
