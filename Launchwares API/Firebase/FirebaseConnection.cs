using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Launchwares_API.Firebase
{
    public static class FirebaseConnection
    {
        static readonly string authSecret = new Cryptology().Decrypt("jfOnLKTJqIUlz+U7VXzOyTsRlrS5MCi7ZwyYj9zvzEhmvbYGOwFb0PzmXPGqmRim");
        static readonly string basePath = new Cryptology().Decrypt("CiaZSO7VS5rbgs1rjsGUOj856Y2q9aot3sl7VgQpMR21GQacU7Wb1BcCdhEf79FA");

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = authSecret,
            BasePath = basePath
        };

        public static IFirebaseClient client = new FirebaseClient(config);
        public static FirebaseResponse response;
    }
}
