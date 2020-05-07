using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Launchwares_API.Firebase
{
    public static class FirebaseConnection
    {
        static readonly string authSecret = "YOUR AUTHSECRET HERE";
        static readonly string basePath = "YOUR BASEPATH HERE";

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = authSecret,
            BasePath = basePath
        };

        public static IFirebaseClient client = new FirebaseClient(config);
        public static FirebaseResponse response;
    }
}
