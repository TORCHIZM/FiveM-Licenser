using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Launchwares_API.Firebase;

namespace Launchwares_API.Firebase
{
    public static class API
    {
        public static async void Push(string path, object obj)
        => FirebaseConnection.response = await FirebaseConnection.client.PushAsync(path, obj);

        public static async void Set(string path, object obj)
        => FirebaseConnection.response = await FirebaseConnection.client.SetAsync(path, obj);

        public static async void Delete(string path)
        => FirebaseConnection.response = await FirebaseConnection.client.DeleteAsync(path);

        public static Dictionary<string, T> Get<T>(string path)
        {
            FirebaseConnection.response = FirebaseConnection.client.Get(path);
            Dictionary<string, T> response = FirebaseConnection.response.ResultAs<Dictionary<string, T>>();
            return response;
        }
    }
}