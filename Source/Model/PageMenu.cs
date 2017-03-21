using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ISoftware.Xamarin.Platforms.Model
{
    public class PageMenu : Page
    {
        public string Message { get; set; }

        public List<MenuItem> Items { get; set; }

        public PageMenu()
        {
            Items = new List<MenuItem>();
        }

        public static PageMenu Load(string filename)
        {
            string filePath = $"ISoftware.Xamarin.Platforms.Model.Data.{filename}.json";

            using (Stream stream = typeof(PageMenu).GetTypeInfo().Assembly.GetManifestResourceStream(filePath))
            {
                StreamReader reader = new StreamReader(stream);
                string jsonString = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<PageMenu>(jsonString);
            }
        }
    }
}
