using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Directory(Info) ****\n");
            //ShowWindowsDirectoryInfo();
            Console.WriteLine();
            //DisplayImageFiles();
            //ModifyAppDirectory();
            FunWithDirectoryType();

            #region File(Info) snippets
            // Obtain FileStream object via File.Create().
            using (FileStream fs = File.Create(@"C:\Test,dat"))
            { }

            // Obtain FileStream object via File.Open().
            using (FileStream fs2 = File.Open(@"C:\Test2.dat",
                FileMode.OpenOrCreate, FileAccess.ReadWrite,
                FileShare.None))
            { }

            // Get a FileStream object with read-only permissions.
            using (FileStream readOnlyStream = File.OpenRead(@"C:\Test3.dat"))
            { }

            // Get a FileStream object with write-only permissions.
            using(FileStream writeOnlyStream = File.OpenWrite(@"C:\Test4.dat"))
            { }

            // Get a streamReader object.
            using(StreamReader sreader = File.OpenText(@"C:\boot.ini"))
            { }

            // Get some StreamWriters. 
            using (StreamWriter swriter = File.CreateText(@"C:\Test5.txt"))
            { }

            using (StreamWriter swriterAppend = File.AppendText(@"C:\FinalText.txt"))
            { }
            #endregion

                Console.ReadLine();
        }



        static void FunWithDirectoryType()
        {
            // List all drives on current computer
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are your drives:");
            foreach(string s in drives)
                Console.WriteLine("--> {0}", s);

            // Delete what was created.
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"C:\MyFolder");
                // the second parameter specifies whether you wish
                // to destroy any subdirectories
                Directory.Delete(@"C:\MyFolder2", true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");

            // Create \MyFolder off application directory.
            dir.CreateSubdirectory("MyFolder");

            // Create \MyFolder2\Data off application directory.
            // and capture returned directoryInfo object.
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");

            // Prints path to ..\MyFolder2\Data.
            Console.WriteLine("New Folder is: {0}", myDataFolder);
        }

        static void ShowWindowsDirectoryInfo()
        {
            // Dump directory information
            DirectoryInfo dir = new DirectoryInfo(@"C:\Window");
            Console.WriteLine("**** Directory Info *****");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
            Console.WriteLine("**********************************\n");
        }

        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            // Get all files with a *.jpg extension.
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            // How many were found?
            Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);

            // Now print out info for each file.
            foreach(FileInfo f in imageFiles)
            {
                Console.WriteLine("**********************");
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes);
                Console.WriteLine("***********************\n");
            }
        }
    }
}
