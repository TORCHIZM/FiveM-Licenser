using System.Collections.Generic;

namespace Launchwares_API.Firebase
{
    public static class API
    {
        /// <summary>
        /// Push to firebase
        /// </summary>
        /// <param name="path">Firebase path</param>
        /// <param name="obj">Object</param>
        public static async void Push(string path, object obj)
        => FirebaseConnection.response = await FirebaseConnection.client.PushAsync(path, obj);

        /// <summary>
        /// Sets specified object to specified path
        /// </summary>
        /// <param name="path">Firebase path</param>
        /// <param name="obj">Object</param>
        public static async void Set(string path, object obj)
        => FirebaseConnection.response = await FirebaseConnection.client.SetAsync(path, obj);

        /// <summary>
        /// Deletes specified path
        /// </summary>
        /// <param name="path">Firebase path</param>
        public static async void Delete(string path)
        => FirebaseConnection.response = await FirebaseConnection.client.DeleteAsync(path);

        /// <summary>
        /// Returns object you gave from path
        /// </summary>
        /// <typeparam name="T">Object type or class</typeparam>
        /// <param name="path">Firebase path</param>
        /// <returns></returns>
        public static Dictionary<string, T> Get<T>(string path)
        {
            FirebaseConnection.response = FirebaseConnection.client.Get(path);
            Dictionary<string, T> response = FirebaseConnection.response.ResultAs<Dictionary<string, T>>();
            return response;
        }
    }
}