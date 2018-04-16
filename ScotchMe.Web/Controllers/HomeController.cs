using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ScotchMe.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ScotchMeControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}