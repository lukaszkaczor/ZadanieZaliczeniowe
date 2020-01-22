using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ZadanieZaliczeniowe.Models
{
    public class Attributes
    {
        [JsonProperty(PropertyName = "col1")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "col2")]
        public string RegistrationNumber { get; set; }

        [JsonProperty(PropertyName = "col3")]
        public string RegistryEntry { get; set; }

        [JsonProperty(PropertyName = "col4")]
        public string TaxNumber { get; set; }

        [JsonProperty(PropertyName = "col5")]
        public string CompanyName { get; set; }

        [JsonProperty(PropertyName = "col6")]
        public string Voivodeship { get; set; }

        [JsonProperty(PropertyName = "col7")]
        public string ZipCode { get; set; }

        [JsonProperty(PropertyName = "col8")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "col9")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "col10")]
        public string HouseNumber { get; set; }

        [JsonProperty(PropertyName = "col11")]
        public string LegalForm { get; set; }

        [JsonProperty(PropertyName = "col12")]
        public virtual DateTime DateOccurred { get; set; }

        [JsonProperty(PropertyName = "col13")]
        public DateTime DeliveryDate { get; set; }

        [JsonProperty(PropertyName = "col14")]
        public string BookStatus { get; set; }
    }
}