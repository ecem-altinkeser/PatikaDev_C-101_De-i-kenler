using System;

namespace variable
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            
            byte b =  1;
            sbyte c = 1;

            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 4;
            Int32 i32 = 4;
            Int64 i64 = 8;

            uint ui = 4;
            long l = 8;
            ulong ul = 8;

            //Reel sayılar
            float f = 4;
            double d = 8;
            decimal de = 16;

            char ch = '2';
            string str = "Ecem";

            bool b1 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(b1);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "Ecem";
            string ad = "ecem";
            string soyad = "a";
            string tamIsim = ad + " " + soyad;

            int i1 = 5;
            int i2 = 3;
            int i3 = i1 + i2;

            bool bool1 = 10>2;

            string str20 = "20";
            int int20 = 20;
            string newValue = str20 + int20.ToString();
            Console.WriteLine(newValue);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.MM.yy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);



        }
    }
}
