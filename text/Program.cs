using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "Log/file.txt";

            if (!File.Exists(path))
            {
                File.Create(path);

            }


            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = random.Next(-100, 100);

            }
            using (StreamWriter sw = new StreamWriter(path, false))

                foreach (int i in numbers)
                {
                    sw.Write("{0,-5}", random.Next(-100, 100));

                }

            Process.Start("C:\\Автоматизация bim проектирования\\С#\\Домашка 8\\Lab8\\text\\bin\\Debug\\Log\\file.txt");


            int Sum = 0;

            foreach (string line in File.ReadLines("C:\\Автоматизация bim проектирования\\С#\\Домашка 8\\Lab8\\text\\bin\\Debug\\Log\\file.txt"))
            {
                Console.WriteLine(line);
                string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in parts)
                {
                    Sum += int.Parse(str);

                }
                Console.WriteLine(Sum);

            }

            Console.ReadKey();
        }


    }
}
