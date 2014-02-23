using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class btap4
    {
        public bool KiemTraGio(int gio, int phut, int giay)
        {
            if ((gio > 24 || phut > 60 || giay > 60)&&(gio<0||phut<0||giay<0))
                return false;
            return true;
        }
        public void run()
        {
            int h, p, s;
            Console.WriteLine("nhap gio");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap phut");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap giay");
            s = Convert.ToInt16(Console.ReadLine());
            if (KiemTraGio(h, p, s) == true)
            {
                Console.WriteLine("GIỜ ĐÃ NHẬP={0}:{1}:{2}", h, p, s);
            }
            else
                Console.WriteLine("gio k hop le");


        }
    }
}
