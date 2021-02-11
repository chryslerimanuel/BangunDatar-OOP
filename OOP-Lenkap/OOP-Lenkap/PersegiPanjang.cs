using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lenkap
{
    class PersegiPanjang : BangunDatar
    {
        private int panjang;
        private int lebar;
        private int kelPersegiPanjang;
        private int luasPersegiPanjang;

        public int Panjang
        {
            get { return panjang; }
            set { panjang = value; }
        }

        public int Lebar
        {
            get { return lebar; }
            set { lebar = value; }
        }

        public void HitungKelPersegiPanjang() 
        {
            this.kelPersegiPanjang = panjang + lebar + panjang + lebar;
        }

        public void HitungLuasPersegiPanjang()
        {
            this.luasPersegiPanjang = panjang * lebar;
        }

        // overriden
        public override void Keliling()
        {
            Console.WriteLine("Keliling Persegi Panjang = " + kelPersegiPanjang);
        }

        // overriden
        public override void Luas()
        {
            Console.WriteLine("Luas Persegi Panjang = " + luasPersegiPanjang);
        }
    }
}
