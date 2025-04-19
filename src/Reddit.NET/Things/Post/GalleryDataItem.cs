using System;

using Newtonsoft.Json;

namespace Reddit.Things
{
    [Serializable]
    public class GalleryDataItem
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        public long Id { get; set; }
    }
}