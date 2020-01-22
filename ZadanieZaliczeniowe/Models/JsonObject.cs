using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZadanieZaliczeniowe.Models
{
    public class JsonObject
    {
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<JsonData> JsonData { get; set; }
    }
}