using Newtonsoft.Json;

namespace DemoApp.Models
{
    public class StudentRecord
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("class")]
        public string StudentClass { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }
    }
}
