using System;

using Newtonsoft.Json;

namespace Reddit.Things
{
    [Serializable]
    public class GalleryData
    {
        [JsonProperty("items")]
        public GalleryDataItem[] Items { get; set; }
    }
}