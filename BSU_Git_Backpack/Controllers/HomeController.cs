using BSU_Git_Backpack.Services;
using Google.Apis.Auth.OAuth2.Mvc;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BSU_Git_Backpack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AccountManagement()
        {
            ViewBag.Message = "Your account management page.";

            return View();
        }

        public ActionResult CreateAccount()
        {
            ViewBag.Message = "Your account management page.";

            return View();
        }

        public async Task<ActionResult> IndexAsync(CancellationToken cancellationToken)
        {
            var result = await new AuthorizationCodeMvcApp(this, new AppFlowMetadata()).
                AuthorizeAsync(cancellationToken);

            if (result.Credential != null)
            {
                return View();
            }
            else
            {
                return new RedirectResult(result.RedirectUri);
            }
        }
    }
}