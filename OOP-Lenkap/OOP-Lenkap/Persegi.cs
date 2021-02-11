using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lenkap
{
    // inheritance
    class Persegi : BangunDatar
    {
       
        private int sisi;
        private int kelPersegi;
        private int luasPersegi;

        // enscaptulation
        public int Sisi
        {
            get { return sisi; }
            set { sisi = value; }
        }

        public void HitungPersegi(int sisi1, int sisi2, int sisi3, int sisi4)
        {
            this.kelPersegi = sisi1 + sisi2 + sisi3 + sisi4;
        }

        // overloading
        public void HitungPersegi(int sisi1, int sisi2)
        {
            this.luasPersegi = sisi1 * sisi2;
        }

        // overriding
        public override void Keliling()
        {
            Console.WriteLine("Keliling Persegi = " + kelPersegi);
        }

        // overriding
        public override void Luas()
        {
            Console.WriteLine("Luas Persegi = " + luasPersegi);
        }
    }
}
