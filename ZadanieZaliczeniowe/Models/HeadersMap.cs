using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ZadanieZaliczeniowe.Models
{
    public class HeadersMap : Attributes
    {
        [JsonProperty(PropertyName = "col12")]
        public string DateOcurredHeader { get; set; }

        [JsonProperty(PropertyName = "col13")]
        public string DeliveryDateHeader { get; set; }
    }
}