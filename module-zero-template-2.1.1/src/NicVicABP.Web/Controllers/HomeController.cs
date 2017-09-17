using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace NicVicABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : NicVicABPControllerBase
    {
        public ActionResult Index()
        {
            Logger.Info("57657657asd");
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}