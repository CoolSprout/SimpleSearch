using SimpleSearch.Models;
using System.Threading;
using System.Web.Mvc;


namespace SimpleSearch.Controllers
{
    public class HomeController : Controller
    {
        private IPersonRepository rep;
        public HomeController(IPersonRepository rep)
        {
            this.rep = rep;
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost()]
        public JsonResult Search(string searchText)
        {
            var persons = rep.GetPersons(searchText);
            //Delaying result by 3 seconds
            Thread.Sleep(3000);
            return Json(persons, JsonRequestBehavior.AllowGet);
        }
    }
}