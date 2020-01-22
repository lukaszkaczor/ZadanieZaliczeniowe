using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ZadanieZaliczeniowe.Models
{
    public class JsonData
    {
        [JsonProperty(PropertyName = "attributes")]
        public Attributes Attributes { get; set; }
    }
}