using SimpleSearch.DataAccess.Repository;
using System.Web.Mvc;


namespace SimpleSearch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var rep = new PersonRepository();
            var persons = rep.GetPersons();
            return View(persons[0]);
        }
    }
}