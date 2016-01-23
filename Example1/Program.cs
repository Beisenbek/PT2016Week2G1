using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{

    class Program
    {
        static void Main(string[] args)
        {
            F4();
        }

        static void F4()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();

            sr.Close();
            fs.Close();

            Console.WriteLine(text);
        }
        static void F3()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();

            sr.Close();
            fs.Close();


            string[] arr = line.Split(' ');
            int sum = 0;
            int x;

            for (int i = 0; i < arr.Length; ++i)
            {
                x = int.Parse(arr[i]);
                sum += x;
            }

            Console.WriteLine(sum);
        }
        static void F2()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();

            Console.WriteLine(line);

            sr.Close();
            fs.Close();
        }
        static void F1()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("hello world!");

            sw.Close();
            fs.Close();
        }
    }
}
