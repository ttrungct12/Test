using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    /// <summary>
    /// liet ke so nguyen to dau tien
    /// </summary>
    class btap10
    {
        public bool ktnguyento(int n)
        {
            if (n < 2)
                return false;
            for (int i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        public void lietkesnt(int n)
        {
            Console.WriteLine("cac so nguyen to dau tien");
            for (int i = 1; i <= n; i++)
            {
               

               
            }
        }
        public void run()
        {
            
            Console.WriteLine("nhap so nguyen n");
            int n = int.Parse(Console.ReadLine());
            lietkesnt(n);

        }
       
    }
}
