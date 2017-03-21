using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace ISoftware.Xamarin.Platforms.Model
{
    public class PlatformPageMenu
    {
        public string Message { get; set; }

        public List<PlatformMenuItem> Items { get; set; }

        public PlatformPageMenu()
        {
            Items = new List<PlatformMenuItem>();
        }

        public static PlatformPageMenu Load(string filename)
        {
            string filePath = $"ISoftware.Xamarin.Platforms.Model.Data.PageMenu{filename}.json";

            using (Stream stream = typeof(PageMenu).GetTypeInfo().Assembly.GetManifestResourceStream(filePath))
            {
                StreamReader reader = new StreamReader(stream);
                string jsonString = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<PlatformPageMenu>(jsonString);
            }
        }
    }
}
