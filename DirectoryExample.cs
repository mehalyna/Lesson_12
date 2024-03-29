using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    public class DirectoryExample
    {
        public static void CreateAndDeleteDirectory()
        {
            string path = @"C:\Temp\ExampleDirectory";
            if (!Directory.Exists(path))
            { 
                Directory.CreateDirectory(path);
                Console.WriteLine($"{path} has been created.");
            }

            Directory.Delete(path, true);
            Console.WriteLine($"{path} has been deleted");
        }
    }
}
