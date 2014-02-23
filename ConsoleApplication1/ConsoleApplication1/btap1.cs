using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    
    class btap1 
    {
        public int NgayCuaThang(int thang, int nam)
        {
            int[] a = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                a[2] = 29;
            else
                 a[2] = 28;
            return a[thang];
                
        }
        public bool kiemtrangay( int ngay ,int thang ,int nam)
        {
           if(ngay<1 || ngay > NgayCuaThang(thang,  nam))
            return false;
            if(thang <0 ||thang > 12)
                return false;
            if(nam <0 ||nam >3000)
                return false;
            return true;
        }

        public void run()
        {
            int ngay, thang, nam;

            Console.WriteLine("nhap ngay:");
            ngay=int.Parse(Console.ReadLine());
            Console.WriteLine("nhap thang:");
            thang=int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nam:");
            nam=int.Parse(Console.ReadLine());

            if (kiemtrangay(ngay, thang, nam) == true)
                Console.WriteLine("ngay hop le");
            else
                Console.WriteLine("ngay k hop le");
            
            
        }  

    }
}
