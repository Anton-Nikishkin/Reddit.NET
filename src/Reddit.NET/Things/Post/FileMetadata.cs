using Newtonsoft.Json;

namespace Reddit.Things
{
    public class FileMetadata
    {
        [JsonProperty("x")]
        public int Width { get; set; }

        [JsonProperty("y")]
        public int Height { get; set; }

        [JsonProperty("u")]
        public string Url { get; set; }
    }
}