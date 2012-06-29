using System.IO;
using System.Text;

namespace Service.Rest
{
    class Conversion
    {
        public static string ToApp(Stream instance)
        {
            var streamReader = new StreamReader(instance);
            return streamReader.ReadToEnd();
        }

        public static Stream ToWeb(string instance)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(instance));
        }
    }
}