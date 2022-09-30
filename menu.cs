namespace Alanlar
{
    public class alan
    {
        public static void menuler()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Daire");
            Console.WriteLine("(2) Üçgen");
            Console.WriteLine("(3) Kare");
            Console.WriteLine("(4) Dikdörtgen");
            int secim=int.Parse(Console.ReadLine());
            switch (secim)
            {
                
                case 1:
                     Sekil.Daire();
                    break;
                case 2:
                    Sekil.Ucgen();
                     break;
                case 3:
                    Sekil.Kare();
                     break;
                case 4:
                     Sekil.Dikdörtgen();
                     break;

            }

        }
    }
}