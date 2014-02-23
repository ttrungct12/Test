using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
     struct hocsinh 
        {
          public  string hoten;
          public   float toan, van, dtb;
            

        };

    class btap5
    {
         
            
      public  void nhap(out hocsinh hs)       
    {
        Console.WriteLine("nhap ho ten sv:");
        hs.hoten = Console.ReadLine();
        Console.WriteLine("nhap diem toan:");
        hs.toan = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap diem van:");
        hs.van = int.Parse(Console.ReadLine());
          
          hs.dtb = (hs.van + hs.toan) / 2;
          
         

        

    }
      static void xuat(hocsinh hs)
      {
          Console.WriteLine("ho ten sv: "+ hs.hoten);
          Console.WriteLine("diem toan: {0}", hs.toan);
          Console.WriteLine("diem van: {0}", hs.van);
          Console.WriteLine("diem tb: {0:0.00}", hs.dtb);
      }
        

      public  void run()
        {
            hocsinh hs;
            nhap(out hs);
            xuat(hs);


        }
    }
}
