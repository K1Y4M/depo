using System.Net;

namespace ÜRETİM
{
    public class Program
    {
        static void Main(string[] args)
        {
            İMALAT_TAKİP üretimkayıt = new İMALAT_TAKİP();
            üretimkayıt.Parcaad = "Sağ Takoz Braketi";
            üretimkayıt.Parcaadaet = 6000;
            üretimkayıt.Parcafiyat = 60000;
            
            


            {
                Console.WriteLine("Parça Adı      :" +üretimkayıt.Parcaad);
                Console.WriteLine("Parca Adedi    :" +üretimkayıt.Parcaadaet);
                Console.WriteLine("Parça  Fiyatı  :" +üretimkayıt.Parcafiyat);



            }
        }
    }
  
}
