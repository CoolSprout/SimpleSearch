using SimpleSearch.DataAccess.Context;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleSearch
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityMvc5.Start();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PersonContext>());
            using (var context = new PersonContext())
            {
                context.Database.Initialize(force: true);
            }
        }
    }
}
