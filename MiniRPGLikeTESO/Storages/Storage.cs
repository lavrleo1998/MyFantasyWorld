using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MiniRPGLikeTESO.Storages
{
    public static class Storage
    {
        public static void Save<T>(T objectForJSON)
        {
            WriteFile(JsonConvert.SerializeObject(objectForJSON), typeof(T).Name + ".txt");
        }

        public static T Get<T>(string fileAddress)
        {
            var historiList = JsonConvert.DeserializeObject<T>(ReadFile(fileAddress));
            return historiList;
        }

        private static void WriteFile(string stringToWrite, string fileAddress)
        {
            using (StreamWriter file = new StreamWriter(fileAddress, true, System.Text.Encoding.Default))
            {
                file.WriteLine(stringToWrite);
            }
        }
        private static string ReadFile(string fileAddress)
        {
            using (StreamReader file = new StreamReader(fileAddress))
            {
                string result = file.ReadToEnd();
                return result;
            }
        }
    }
}
