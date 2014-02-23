using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    struct toado2
    {
        public int x, y;
    }
    class btap7
    {
        /// <summary>
        /// ham nhap toa do
        /// </summary>
        /// <param name="td">toa do</param>
        void nhap(out toado2 td)
        {
            Console.WriteLine("nhap hoanh do:");
            td.x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap tung do:");
            td.y = int.Parse(Console.ReadLine());
            

            
        }
        void xuat(toado2 td)
    {
        Console.WriteLine("({0},{1})", td.x, td.y);

    }
        /// <summary>
        /// ham tinh khaong cach tu toa do diem 1 den toa do diem 2
        /// </summary>
        /// <param name="td1">toa do 1</param>
        /// <param name="td2">toa do 2</param>
        /// <returns></returns>khoang cach giua 2 diem
        static float khoangcach(toado2 td1, toado2 td2)
        {
            float kc;
            kc =    (td1.x - td2.x) * (td1.x - td2.x)+ (td1.y - td2.y) * (td1.y - td2.y);
          
            return (float)Math.Sqrt(kc);
           

        }
        public void run()
        {
            toado2 a, b;
            
            Console.WriteLine("nhap toa do a");
            nhap(out a);
            xuat(a);
            Console.WriteLine("nhap toa do b");
            nhap(out b);
            xuat(b);
            float kq = khoangcach(a, b);
            Console.WriteLine("khoang cach giua diem a va b: {0}", kq);


        }
    }
   

}
