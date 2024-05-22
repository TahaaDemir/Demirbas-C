using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Dikdörtgen
    {
        private double kk;
        private double uk;

        public Dikdörtgen(double kk, double uk)
        {
            this.kk = kk;
            this.uk = uk;
        }
        public double K
        {
            get { return kk; }
            set { kk = value; }
        }
        public double U
        {
            get { return uk; }
            set { uk = value; }
            }
            public double köseuzunluk()
        { 
            return Math.Sqrt(Math.Pow(kk,2) + Math.Pow(uk,2));

            }
        public double Cevre()
        {
            return 2 * kk + 2 * uk;
        }
        public double Alan()
        {
            return kk * uk;
        }

    }
}
