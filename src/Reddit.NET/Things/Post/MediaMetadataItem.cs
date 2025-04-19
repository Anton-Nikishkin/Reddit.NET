using Newtonsoft.Json;

using System.Collections.Generic;

namespace Reddit.Things
{
    public class MediaMetadataItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("e")]
        public string Type { get; set; }

        [JsonProperty("m")]
        public string MimeType { get; set; }

        [JsonProperty("o")]
        public List<FileMetadata> Obfuscate { get; set; }

        [JsonProperty("p")]
        public List<FileMetadata> Preview { get; set; }

        [JsonProperty("s")]
        public FileMetadata Source { get; set; }
    }
}