using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class btap9
    {
        
        public void run()
        {
            btap6 bt6 = new btap6();

            phanso ps1, ps2;
            Console.WriteLine("nhap phan so thu 1:");
            bt6.nhap(out ps1);
            bt6.xuat(ps1);
            Console.WriteLine("nhap phan so thu 2:");
            bt6.nhap(out ps2);
            bt6.xuat(ps2);  


            
            

        }
    }
}
