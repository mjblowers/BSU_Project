//using System;
//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Auth.OAuth2.Flows;
//using Google.Apis.Util.Store;

//namespace BSU_Git_Backpack.Services
//{
//    public class AppFlowMetadata : FlowMetadata
//    {
//        private static readonly IAuthorizationCodeFlow flow =
//            new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
//            {
//                ClientSecrets = new ClientSecrets
//                {
//                    ClientId = "1006440881603-vdgjf88tq641i1r6o9k1m3skgom2k1qj.apps.googleusercontent.com",
//                    ClientSecret = "-mSBi_zdIjboFhYvi1CFww0G"
//                },
//                Scopes = new[] { "Email" },
//                DataStore = new FileDataStore("Drive.Api.Auth.Store")
//            });

//        public override string GetUserId(Controller controller)
//        {
//            var user = controller.Session["user"];
//            if (user == null)
//            {
//                user = Guid.NewGuid();
//                controller.Session["user"] = user;
//            }
//            return user.ToString();
//        }

//        public override IAuthorizationCodeFlow Flow
//        {
//            get { return flow; }
//        }

//    }
//}