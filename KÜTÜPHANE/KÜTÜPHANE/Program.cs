namespace KÜTÜPHANE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           kütüphane kayıt = new kütüphane();
            kayıt.Üye = "Muhammet";
            kayıt.Kitapad = "İnce Memed";
            kayıt.Kitapfiyat = 95;
            kayıt.yazdır();
            Console.ReadLine();
        }
    }
}