using BSU_Git_Backpack.Services;
using Google.Apis.Auth.OAuth2.Mvc;
using Google.Apis.Services;
using System;
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
                var oauthService = new Google.Apis.Oauth2.v2.Oauth2Service(
                    new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = result.Credential,
                        ApplicationName = "Mike Test"
                    });
                var userInfo = await oauthService.Userinfo.Get().ExecuteAsync();
                Console.WriteLine(result.Credential.UserId);
                return View();
            }
            else
            {
                Console.WriteLine("null credential seen");
                return new RedirectResult(result.RedirectUri);
            }
        }
    }
}