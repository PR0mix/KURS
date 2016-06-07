using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FB
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class AnyCompany
    {
        string CompanyName;
        double SharePrice, ValueChange;
        int NumbersShares;
        public int YouShares;
       
        public AnyCompany(string CompanyName, float SharePrice, int NumbersShares, int YouShares)
        {
            this.CompanyName = CompanyName;
            this.SharePrice = SharePrice;

            this.NumbersShares = NumbersShares;
            this.YouShares = YouShares;
            Random RandomNumber1 = new Random();
         
            this.ValueChange =RandomNumber1.Next(-15, 15) * this.SharePrice * 0.01; 

        }

        public void nextday()
        {
            Random RandomNumber1 = new Random();

            System.Threading.Thread.Sleep(55);
                double k= RandomNumber1.Next(-15, 15) * (this.SharePrice) * 0.01;
            this.SharePrice = this.SharePrice + k;
           
          
            this.ValueChange = k;
        }
        public string cn()
        {
            return CompanyName;
        }
        public double sp()
        {
            return SharePrice;
        }

        public double vc()
        {
            return ValueChange;
        }

        public int ns()
        {
            return NumbersShares;
        }

        public int ys()
        {
            return YouShares;
        }

       
    }
}


