using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class btap3
    {
        public void NgayHomQua(ref int ngay,ref  int thang,ref int nam)
        {
            btap1 bt1 = new btap1();
            ngay--;
            if (ngay == 0)
            {
                if (thang == 1)
                {
                    ngay = bt1.NgayCuaThang(thang, nam);
                    nam--;
                    thang = 12;
                }
                else
                {
                    ngay = bt1.NgayCuaThang(thang - 1, nam);
                    thang--;
                }
              
                
            }
        }
        public void run()
        {
            int ngay, thang, nam;
            Console.WriteLine("nhập ngày:");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập tháng:");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập năm :");
            nam=int.Parse(Console.ReadLine());
            btap1 bt1 = new btap1();
            if (bt1.kiemtrangay( ngay,  thang,  nam) == true)
            {
                Console.WriteLine("ngày hợp lệ");
                NgayHomQua(ref ngay, ref thang,ref  nam);
                Console.WriteLine("ngày hôm qua:{0}/{1}/{2}",ngay,thang,nam);

            }
            else
                Console.WriteLine("ngày không hợp lệ");
        }
    }
}
