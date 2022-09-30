namespace Alanlar
{
    public class Sekil
    {
        public static void Daire() 
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Çevre Hesaplama");
            Console.WriteLine("(2) Alan Hesaplama");
            Console.WriteLine("(3) Hacim Hesaplama");
            int secim=int.Parse(Console.ReadLine());
                switch (secim)
            {
                
                case 1:
                      Hesap.DaireCevre();
                    break;
                case 2:
                    Hesap.DaireAlan();
                     break;
                case 3:
                    Hesap.DaireHacim();
                     break;

            }
        }
        public static void Ucgen() 
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Çevre Hesaplama");
            Console.WriteLine("(2) Alan Hesaplama");
            Console.WriteLine("(3) Hacim Hesaplama");
            int secim=int.Parse(Console.ReadLine());
                switch (secim)
            {
                
                case 1:
                      Hesap.UcgenCevre();
                    break;
                case 2:
                    Hesap.UcgenAlan();
                     break;
                case 3:
                    Hesap.UcgenHacim();
                     break;

            }
        }
        public static void Kare() 
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Çevre Hesaplama");
            Console.WriteLine("(2) Alan Hesaplama");
            Console.WriteLine("(3) Hacim Hesaplama");
            int secim=int.Parse(Console.ReadLine());
                switch (secim)
            {
                
                case 1:
                      Hesap.KareCevre();
                    break;
                case 2:
                    Hesap.KareAlan();
                     break;
                case 3:
                    Hesap.KareHacim();
                     break;

            }
        }

        public static void Dikdörtgen() 
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Çevre Hesaplama");
            Console.WriteLine("(2) Alan Hesaplama");
            Console.WriteLine("(3) Hacim Hesaplama");
            int secim=int.Parse(Console.ReadLine());
                switch (secim)
            {
                
                case 1:
                      Hesap.DikdortgenCevre();
                    break;
                case 2:
                    Hesap.DikdortgenAlan();
                     break;
                case 3:
                    Hesap.DikdortgenHacim();
                     break;

            }
        }
    }
}