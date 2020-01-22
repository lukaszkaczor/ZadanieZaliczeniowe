using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZadanieZaliczeniowe.Models
{
    public class FileDownloader
    {
        public static string DownloadString(string address)
        {
            using (var webClient = new WebClient())
            {
                return webClient.DownloadString(address);
            }
        }
    }
}