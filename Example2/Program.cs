using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void ShowInfo(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine(directory.FullName  + ": " + directory.GetFiles().Length);

            DirectoryInfo[] d =  directory.GetDirectories();

            for(int i = 0; i < d.Length; ++i)
            {
                Console.WriteLine(d[i].FullName + ": " + d[i].GetFiles().Length);

                DirectoryInfo[] d2 = d[i].GetDirectories();

                for (int j = 0; j < d2.Length; ++j)
                {
                    Console.WriteLine(d2[j].FullName + ": " + d2[j].GetFiles().Length);
                }
            }

        }

        static void ShowInfoRecursive(string path)
        {
            try {
                DirectoryInfo directory = new DirectoryInfo(path);
                Console.WriteLine(directory.FullName + ": " + directory.GetFiles().Length);

                DirectoryInfo[] d = directory.GetDirectories();

                for (int i = 0; i < d.Length; ++i)
                {
                    ShowInfoRecursive(d[i].FullName);
                }
            }catch(Exception)
            {

            }
        }

        static void Main(string[] args)
        {
         
            ShowInfoRecursive(@"C:\work");
        }
    }
}
