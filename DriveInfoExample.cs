using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    public class DriveInfoExample
    {
        public static void ListAllDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Drive: {drive.Name}");
                Console.WriteLine($"Drive Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"  Volume label: {drive.VolumeLabel}");
                    Console.WriteLine($"  File system: {drive.DriveFormat}");
                    Console.WriteLine($"  Available space to user: {drive.AvailableFreeSpace}");
                    Console.WriteLine($"  Total available space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"  Total size: {drive.TotalSize} bytes");

                }
            }
        }
    }
}
