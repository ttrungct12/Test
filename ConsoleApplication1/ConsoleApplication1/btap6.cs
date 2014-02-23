using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    struct phanso
    {
       public int mau, tu;

    }
    /// <summary>
    /// phan so
    /// </summary>
    class btap6
    {
        /// <summary>
        /// ham nhap phan so
        /// </summary>
        /// <param name="ps">phan so</param>
       public void nhap(out phanso ps)
        {
            Console.WriteLine("nhap tu so");
            ps.tu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau so");
            ps.mau = int.Parse(Console.ReadLine());

        }
       public void xuat(phanso ps)
        {
            if (ps.tu  %ps.mau == 0)
                Console.WriteLine("{0}", ps.tu / ps.mau);
            else
                Console.WriteLine("{0}/{1}", ps.tu, ps.mau);
        }
        /// <summary>
        /// ham tim uoc so chung lon nhat cua 2 so nguyen
        /// </summary>
        /// <param name="a">so nguyen thu 1</param>
        /// <param name="b">so nguyen thu 2</param>
        /// <returns></returns>tra ve uoc so chung lon nhat
       public  int USCLN(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        /// <summary>
        /// ham rut gon phan so
        /// </summary>
        /// <param name="ps">phan so muon rut gon</param>
        /// <returns></returns>tra ve phan so sau khi rut gon
        public phanso rutgon( phanso ps)
        {
            int kq=USCLN(ps.tu,ps.mau);
            phanso tmp;
            tmp.tu = ps.tu / kq;
            tmp.mau = ps.mau / kq;
            

            return tmp;


        }
        public void run()
        {
            phanso ps;
            nhap(out ps);
            Console.WriteLine("phan so sau khi da nhap ");
            xuat(ps);
            ps = rutgon(ps);
            Console.WriteLine("phan so sau khi rut gon");
            xuat(ps);



        }


        
    }
}
