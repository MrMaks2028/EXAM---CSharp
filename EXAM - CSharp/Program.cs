using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace EXAM___CSharp
{
    internal class Program
    {
        static char[] f00(string s)
        {
            s.ToCharArray();
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]) == true)
                {
                    count++;
                }
            }
            List<char> list = new List<char>(count);
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]) == true)
                {
                    list.Add(s[i]);
                }
                continue;
            }
            list.Sort();
            list.ToString();
            char[] arr = new char[list.Count];
            for(int i = 0; i < list.Count; i++)
            {
                arr[i] += list[i];
            }
            arr.ToString();
            return arr;
        }
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("C:\\Users\\С - 15\\Documents\\Бутаков Максим\\task1.txt");
            file.Create();

            Console.WriteLine("Задание 1");

            Console.WriteLine("Введите строку, состоящую из букв и чисел -> ");
            char[] result = f00(Console.ReadLine());
            Console.WriteLine("\nРезультат: ");
            Console.Write(result);
            //using (StreamWriter sw = new StreamWriter("C:\\Users\\С - 15\\Documents\\Бутаков Максим\\task1.txt)", false)
            //{

            //}
            Console.ReadKey();
            
        }
    }
}
