using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class btap2 

    {
        public void ngayketiep(ref int ngay,ref int thang, ref int nam)
        {
            btap1 bt1 = new btap1();
            ngay++;
            
            if (ngay > bt1.NgayCuaThang(thang, nam))
            {
                ngay = 1;
                if (thang == 12)
                {
                    thang = 1;
                    nam++;
                }
                else
                    thang++;
            }
           

            
            
            
        }


        public void run()
        {
            int ngay, thang, nam;

            Console.WriteLine("nhap ngay:");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap thang:");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nam:");
            nam = int.Parse(Console.ReadLine());
            btap1 bt1 = new btap1();

            if (bt1.kiemtrangay(ngay, thang, nam) == true)
            {
                Console.WriteLine("ngay hop le");
                ngayketiep(ref ngay, ref thang, ref nam);
                Console.WriteLine("ngay ke tiep {0}/{1}/{2}", ngay, thang, nam);
            }
            else
                Console.WriteLine("ngay k hop le");
            
        }


    }
}
