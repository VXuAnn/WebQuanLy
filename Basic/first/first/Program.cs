using System;
using System.Linq;

namespace first
{
    internal class Program
    {   
        
       

        static void Main(string[] args)
        {
            #region create
            SinhVien sinhvien1 = new SinhVien();
            SinhVien sinhvien2 = new SinhVien();
            #endregion

            #region do
            sinhvien1.MaSv = 1;
            //Console.ReadLine(sinhvien1.TenSv);
            Console.WriteLine(sinhvien1.MaSv);
            Console.WriteLine(sinhvien1);
            #endregion 
        }

        // The youngest child is: John
    }
}

