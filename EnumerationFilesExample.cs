using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    public class EnumerationFilesExample
    {
        public static void ListFilesAndDirectories(string path)
        { 
            string[] directories = Directory.GetDirectories(path);
            Console.WriteLine("Directories:");
            foreach (string dir in directories) 
            {
                Console.WriteLine($"     {dir}");
            }

            string[] files = Directory.GetFiles(path);
            Console.WriteLine("Files:");

            foreach (string file in files)
            { 
                Console.WriteLine($"          {file}");
            }
        }
    }
}
