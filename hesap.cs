namespace Alanlar
{
    public class Hesap
    {
            
        public static void DaireCevre() 
        {
            Console.WriteLine("Lütfen YarıÇap giriniz..: ");
            double r=double.Parse(Console.ReadLine());
            double sonuc= 2*Math.PI*r;
            Console.WriteLine("Daire Çevre:"+sonuc);
        }
        public static void DaireAlan() 
        {
            Console.WriteLine("Lütfen YarıÇap giriniz..: ");
            double r=double.Parse(Console.ReadLine());
            double sonuc= Math.PI*r*r;
            Console.WriteLine("Daire Alan:"+sonuc);
        }  
        public static void DaireHacim() 
        {
            Console.WriteLine("Lütfen yarıçapı giriniz..: ");
            int r=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Yükseklik giriniz giriniz..: ");
            int h=int.Parse(Console.ReadLine());
            double sonuc= Math.PI*h*r/4;
            Console.WriteLine("Daire Hacim:"+sonuc);
        }
        public static void KareCevre() 
        {
            Console.WriteLine("Lütfen bir kenar giriniz..: ");
            int kenar=int.Parse(Console.ReadLine());
            int sonuc= kenar*4;
            Console.WriteLine("Kare Çevre:"+sonuc);
        }
        public static void KareAlan() 
        {
            Console.WriteLine("Lütfen Kenar giriniz");
            int kenar=int.Parse(Console.ReadLine());
            int sonuc= kenar*kenar;
             Console.WriteLine("Karenin Alanı:"+sonuc);
        }  
        public static void KareHacim() 
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int kenar=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen yükseklik giriniz..: ");
            int h=int.Parse(Console.ReadLine());
            int sonuc= kenar*kenar*h;
            Console.WriteLine("Kare Hacim :"+sonuc);
        }   
        public static void UcgenCevre() 
        {
            
             Console.WriteLine("Lütfen Karşı kenarı giriniz..: ");
            int karsi=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Komşu Kenarı giriniz..: ");
            int komsu=int.Parse(Console.ReadLine());
            int kokhipotenus=(karsi*karsi)+(komsu*komsu);
            double hipotenus=Math.Sqrt(kokhipotenus);
            double sonuc= karsi+komsu+hipotenus;
            Console.WriteLine("Ucgen Cevre:"+sonuc);
        }
        public static void UcgenAlan() 
        {
            Console.WriteLine("Lütfen Karşı kenarı giriniz..: ");
            int karsi=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Komşu Kenarı giriniz..: ");
            int komsu=int.Parse(Console.ReadLine());
            int sonuc= (karsi*komsu)/2;
            Console.WriteLine("Ucgenin Alanı:"+sonuc);

        }  
        public static void UcgenHacim() 
        {
            Console.WriteLine("Lütfen dik Kenarı giriniz..: ");
            int dik=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Yan kenarı giriniz..: ");
            int yan=int.Parse(Console.ReadLine());
            int sonuc=dik*yan/2;
            Console.WriteLine("Dikdortgen Cevre:"+sonuc);

        }  
        public static void DikdortgenCevre() 
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int uzun=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kısa Kenarı giriniz..: ");
            int kisa=int.Parse(Console.ReadLine());
            int sonuc= (kisa+uzun)*2;
            Console.WriteLine("Dikdortgen Cevre:"+sonuc);
        }
        public static void DikdortgenAlan() 
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int uzun=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kısa Kenarı giriniz..: ");
            int kisa=int.Parse(Console.ReadLine());
            int sonuc= uzun*kisa;
            Console.WriteLine("Dikdörtgen Alanı:"+sonuc);

        }  
        public static void DikdortgenHacim() 
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int uzun=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kısa kenarı giriniz..: ");
            int kisa=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Yükseklik giriniz..: ");
            int h=int.Parse(Console.ReadLine());
            int sonuc= uzun*kisa*h;
            Console.WriteLine("Dikdörtgen Hacim:"+sonuc);
        }   
    }
}