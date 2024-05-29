using System.Diagnostics;
using System.Text;

namespace RestaurantFis.Models.Domain.Models
{
    public class FileLogger
    {
      private static StringBuilder StringBuilder = new StringBuilder();
      public static string File = "./";
      public static void Write(string data)
        {
            StringBuilder.AppendLine(data);
            System.Console.WriteLine(data);
            System.Diagnostics.Debug.WriteLine(data);
            
        }
        public static void Save(string data)
        {

        }
    }
}
