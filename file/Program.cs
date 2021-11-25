using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "C:\\Автоматизация BIM проектирования\\";
            string root = ".";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName, root, SearchOption.AllDirectories);
                foreach (string s in dirs)
                {

                    Console.WriteLine(s);
                }
                Console.WriteLine();

                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName, root, SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();



        }
    }
}
