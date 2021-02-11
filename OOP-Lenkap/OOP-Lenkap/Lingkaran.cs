using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lenkap
{
    class Lingkaran : BangunDatar
    {
        private double pi = 3.14;
        private int jari2;

        // enscaptulation
        public int Jari2
        {
            get { return jari2; }
            set { jari2 = value; }
        }

        //public int R2 {get; set;}

        //public int hitung()
        //{
        //    return (R2 + R2);
        //}

        // polymorph overriding
        public override void Keliling()
        {
            double Keliling = 2 * pi * this.jari2;  
            Console.WriteLine("Keliling Lingkaran = " + Keliling);
        }

        // polymorph overriding
        public override void Luas()
        {
            double Luas = pi * (this.jari2 * this.jari2);
            Console.WriteLine("Luas Lingkaran = " + Luas);
        }

    }
}
