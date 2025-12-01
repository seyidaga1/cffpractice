using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Models;
using Newtonsoft.Json;

namespace MiniProject.Services
{
    sealed class FileManager
    {
        public static string path = "C:\\Users\\DELL\\Desktop\\MiniProject\\MiniProject\\Data\\data.json";
        public static void Add(List<Book> books)
        {
            try
            {
                var json = JsonConvert.SerializeObject(books, Formatting.Indented);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(json);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static List<Book> Show()
        {
            try
            {
                string result;
                using (StreamReader sr = new StreamReader(path))
                {
                    result = sr.ReadToEnd();
                }

                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(result);

                return books;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
