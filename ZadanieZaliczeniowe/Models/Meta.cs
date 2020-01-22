using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ZadanieZaliczeniowe.Models
{
    public class Meta
    {
        [JsonProperty(PropertyName = "headers_map")]
        public HeadersMap HeadersMap { get; set; }

        [JsonProperty(PropertyName = "server_time")]
        public DateTime ServerTime { get; set; }
    }
}