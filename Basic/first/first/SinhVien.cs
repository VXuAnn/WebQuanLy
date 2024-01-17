using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class SinhVien
    {
        #region variable
        private int maSv;
        private string tenSv;
        private float score;
        #endregion

        #region contructors
        public SinhVien()
        {
            this.maSv = 0;
            this.tenSv = "trung";
            this.score = 0;
        }
        
        public SinhVien(int maSv, string tenSv, float score)
        {
            this.maSv= maSv;
            this.tenSv = tenSv;
            this.score = score;
        }
        #endregion

        #region properties
        public int MaSv
        {
            get { return this.maSv; }
            set { this.maSv = value; }
        }

        public string TenSv
        {
            get { return this.tenSv; }
            set { this.tenSv = value; }
        }

        public float Score
        {
            get { return this.score; }
            set { this.score = value; }
        #endregion

        #region do
        public override string ToString()
        {
            return MaSv + " " + TenSv;
        }
        #endregion

        #region support method
        private bool Check()
        {
            return (this.score -21 >= 0);
        }
        #endregion

        #region service method
        public void Outp()
        {
            if (Check() == false)
            {
                Console.WriteLine("kiem tra lai");
            }
            else
                Console.WriteLine(ToString());
                
        }
        #endregion

    }

}
