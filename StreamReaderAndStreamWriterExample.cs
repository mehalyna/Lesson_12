using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    public class StreamReaderAndStreamWriterExample
    {
        public static void WriteAndReadFile(string filePath)
        {
            string[] linesToWrite = { "First Line", "Second Line", "Third Line"};
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in linesToWrite)
                {
                    writer.WriteLine(line);                   
                }
            }

            Console.WriteLine($"Text written to {filePath}");

            Console.WriteLine($"Reading from file {filePath}");
            using (StreamReader reader = new StreamReader(filePath)) 
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
