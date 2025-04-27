namespace DERS_NOTU_HESAPLAMA_VE_HARF_NOTU_BELİRLEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ders adı giriniz");
            string dersAdi = Console.ReadLine();

            double vizeCarpani = 0.4;
            double finalCarpani = 0.6;

            Console.Clear();

        vizeGirisi:
            Console.WriteLine("Vize Notunuzu Giriniz");
            int vizeNotu = Convert.ToInt32(Console.ReadLine());
                if (vizeNotu<0 || vizeNotu > 100)
                {
                    Console.WriteLine("Lütfen 0 ile 100 arasında bir not giriniz");
                    goto vizeGirisi;
                }

            Console.Clear();

        finalGirisi:
            Console.WriteLine("Final notunuzu giriniz");
            int finalNotu = Convert.ToInt32(Console.ReadLine());
               if(finalNotu<0 || finalNotu > 100)
                {
                    Console.WriteLine("Lütfen 0 ile 100 arasında bir not giriniz");
                    goto finalGirisi;
                }

            Console.Clear();
            
            double ortalama = (vizeNotu * vizeCarpani) + (finalNotu * finalCarpani);
            string harfNotu = "";

            if (ortalama < 50)
            {
                harfNotu = "D";
            }
            else if (ortalama>=50 && ortalama <= 59)
            {
                harfNotu = "C2";
            }
            else if (ortalama >=60 && ortalama <= 64)
            {
                harfNotu = "C1";
            }
            else if (ortalama >= 65 && ortalama <= 69)
            {
                harfNotu = "B2";
            }
            else if (ortalama >= 70 && ortalama <= 74)
            {
                harfNotu = "B1";
            }
            else if (ortalama >= 75 && ortalama <= 84)
            {
                harfNotu = "A2";
            }
            else
            {
                harfNotu = "A1";
            }

            Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız {harfNotu}");
            Console.WriteLine((ortalama >= 50) ? "Geçtiniz" : "Kaldınız");
        }
    }
}
