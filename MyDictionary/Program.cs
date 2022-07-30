using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {


            MyDictionary<int, string> list = new MyDictionary<int, string>();
            list.Add(1, "Ömer");
            list.Add(1, "Sude Nur");
            list.Add(2, "Sude Nur");

            //Aynı key değerine sahip 2 veri var ise hata verir. Ekleme Yapmaz!

            list.Show();
            Console.WriteLine(list.Count+" Veri Bulundu!"); 

        }
    }

}