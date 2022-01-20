using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Al");
            list.Add("Mamun");
            list.Add("Shuvo");
            list.Add("Al1");
            list.Add("Imran");
            list.Add("Shuvo1");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
           
            list.Remove("Al1");

            Console.WriteLine("\n");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }



            //Console.WriteLine("--------------------------");

            //list.Reverse();

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //string name = "Kashem";

            //string result = Reverse(name);

            //Console.WriteLine(result);

            //bool isExists = list.Contains("Imran5");
            //Console.WriteLine(isExists);

            //Console.WriteLine(list[1]);
            //Console.WriteLine(list.Count);
            //Console.ReadLine();
            Console.ReadKey();
        }

        //public static string Reverse(string text)
        //{
        //    char[] cArray = text.ToCharArray();
        //    string reverse = String.Empty;
        //    for (int i = cArray.Length - 1; i > -1; i--)
        //    {
        //        reverse += cArray[i];
        //    }
        //    return reverse;
        //}
    }
}
