using System;
using System.Collections.Generic;
using System.Text;

namespace ca{
    internal class Kikötő{

        public int[] Hajok = { 0,0,5,2,11,4,5,3,7,7,9,10};           
        public int LépesekSzáma;
        Random rand = new Random();

        public void Mutat(){for (int i = 2; i < 12; i++) Console.WriteLine($"{i}: "+new string('H', Hajok[i]));}

        /// <summary>
        /// Visszaadja a kikötőben levő hajók számát
        /// </summary>
        public int HajokSzama() {
            int ÖsszHajó = 0;
            for(int i = 2; i < Hajok.GetLength(0); i++) ÖsszHajó += Hajok[i];  
            return ÖsszHajó;
        }

        public void Sorsol(){
            int kocka1 = rand.Next(1,7);
            int kocka2 = rand.Next(1,7);
            int index = kocka1 + kocka2;
            if (Hajok[index] > 0) Hajok[index]--;
            LépesekSzáma++;
        }
    }
}
