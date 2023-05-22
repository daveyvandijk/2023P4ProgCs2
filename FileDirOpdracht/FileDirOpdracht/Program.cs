namespace FileDirOpdracht;
using System.IO;


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DirectoryInfo dir = new DirectoryInfo(@"C:\\Users\\davey\\Documents\\ma\\progameren\\programeren2\\2023P4ProgCs2\\FileDirOpdracht\\FileDirOpdracht\\bin\\Debug\\net7.0");
            Console.WriteLine(dir.FullName);
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] directories = dir .GetDirectories();
            foreach (var file in files)
             {
                   Console.WriteLine(file.FullName);
             }
            foreach (var file in directories)
             {
                 Console.WriteLine(file.FullName);
             }
        }
    }
