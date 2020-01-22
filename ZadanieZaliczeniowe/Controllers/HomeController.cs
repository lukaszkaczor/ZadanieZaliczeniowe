using System.Web.Mvc;
using Newtonsoft.Json;
using ZadanieZaliczeniowe.Models;

namespace ZadanieZaliczeniowe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //https://dane.gov.pl/dataset/671,wykaz-przedsiebiorcow-wobec-ktorych-wszczeto-postepowanie-w-sprawie-wykreslenia-z-rejestru/resource/21280/table

            var file = FileDownloader.DownloadString(@"https://api.dane.gov.pl/resources/21280/data");
            var model = JsonConvert.DeserializeObject<JsonObject>(file);

            return View(model);
        }
    }
}