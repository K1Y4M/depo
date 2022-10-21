using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KÜTÜPHANE
{
    internal class kütüphane
    {
        private string üye;
        public string Üye
        {
            get { return üye; }
            set { üye = value; }
        }
        private string kitapad;
        public string Kitapad
        {
            get { return kitapad; }
            set { kitapad = value; }    
        }
        private int kitapfiyat;
        public int Kitapfiyat
        {
            get { return kitapfiyat; }  
            set { kitapfiyat = value; }
        }
        public void yazdır()
        {
            Console.WriteLine("Üye Adı       : " + Üye);
            Console.WriteLine("Kitap Adı     : " + Kitapad);
            Console.WriteLine("Kitap Fiyatı  : " + Kitapfiyat );
        }
    }


}
