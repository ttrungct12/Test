using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    struct toado3
    {
        public int x, y, z;

    }
    
        
    
     
    
    class btap8
    {
        void nhap(out toado3 td)
        {
            Console.WriteLine("nhap x:");
            td.x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap y:");
            td.y = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap z:");
            td.z = int.Parse(Console.ReadLine());

        }
        void xuat(toado3 td)
        {
            Console.WriteLine("({0},{1},{2})", td.x, td.y, td.z);

        }
        /// <summary>
        /// chu vi tam giac
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <param name="c">c</param>
        /// <returns></returns>
        public int chuvi(int a, int b, int c)
        {

            return (a + b + c);
        }
        /// <summary>
        /// tinh dien tich tam giac
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <param name="c">c</param>
        /// <returns></returns>
        public float dientich(int a, int b, int c)
        {
            int p = chuvi(a, b, c)/2;
            float dt;
            dt = (p * (p - a) * (p - b) * (p - c));
            return (float)Math.Sqrt(dt);
            
        }
        public void run()
        {
            toado3 td;
            Console.WriteLine("nhap toa do 3 diem xyz");
            nhap(out td);
            xuat(td);
            int cv = chuvi(td.x, td.y, td.z);
            Console.WriteLine("chu vi: {0}", cv);
            float dt = dientich(td.x, td.y, td.z);
            Console.WriteLine("dien tich:{0}", dt);



        }
        
        
    }
}
