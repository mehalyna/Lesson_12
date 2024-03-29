using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    public class FileExample
    {
        public static void WriteAndReadFile()
        {
            string filePath = @"C:\Temp\ExampleFile.txt";

            string contentToWrite = "Hello, World!";
            File.WriteAllText(filePath, contentToWrite);
            Console.WriteLine($"Text written to {filePath}");

            string contentRead = File.ReadAllText(filePath);
            Console.WriteLine($"Text read from {filePath}: {contentRead}");
            
        }
    }
}
