namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listing all drives!");
            DriveInfoExample.ListAllDrives();

            Console.WriteLine("Working with directories!");
            DirectoryExample.CreateAndDeleteDirectory();

            Console.WriteLine("Working with files simple read/write!");
            FileExample.WriteAndReadFile();


            Console.WriteLine("Listing directories and files!");
            string path = @"C:\Users\hmeln\Documents\Univer2023";
            EnumerationFilesExample.ListFilesAndDirectories(path);

            Console.WriteLine("Write and Read with StreamWriter and StreamReader");
            string filePath = @"C:\Temp\ExampleFile.txt";
            StreamReaderAndStreamWriterExample.WriteAndReadFile(filePath);

            Console.ReadKey();  
           
        }
    }
}