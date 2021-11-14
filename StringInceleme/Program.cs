using System;

namespace StringInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'A';
            string s = "A"; // aslında string tip bir char dizisidir. bize aşaıdaki kolaylığı sağlar

            char[] isim = { 'e', 'k', 'r', 'e', 'm' };
            string isim1 = "ekrem"; // unutmayın... string char dizisidir..

            Console.WriteLine(isim[isim.Length - 1]); // isim dizsinin son elemanı...
            Console.WriteLine(isim1[isim1.Length - 1]);


            foreach (char item in isim1)
                Console.WriteLine(item);




            Console.WriteLine("lütfen 3 harfli bir palindrome kelime yazınız...");
            string kelime = Console.ReadLine();


            // Palindrome... iki, ütü, ata vb..........

            int f = 0, l = kelime.Length - 1;

            if (kelime.Length == 3)
            {
                if (kelime[f] == kelime[l])
                {
                    Console.WriteLine("bravo....terst ve düzden okunuşu aynı kelime girdiniz...");
                }
            }
            else
            {
                kelime = "kavak";
                if (kelime[f] == kelime[l]) // k karşılaştır
                {
                    if (kelime[f++] == kelime[l--]) // a karşılaştır..
                    {

                    }
                }
            }

            string cumle = "bu gün hava çok güzel....arkadaşlar ile kavak olan bir yere gittik. tabi gitmeden ütü yaptım. orada ata bindim....";
            string alfave = "a,b,c,e,d,f,g";
            string rakam = "0,1,2,3,4,5,6,7,8,9";


            string[] rakamlar = rakam.Split(',');// split metodu string içerisindeki metni belirtilen karaktere göre diziye çevirr...

            string[] cumleler = cumle.Split(' '); // boşluğa göre dizi oluştur....


            foreach (var item in cumleler)
            {
                Console.WriteLine(item);

                // tam burada bu cümle içrisindeki palindrome kelimeleri ekrana yazdırınız...
                // ütü - palindromdur...
            }


            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            Console.WriteLine("birşeyler yaz");
            string birseyler = Console.ReadLine().ToLower(); // ekrem

            int sesliSayisi = 0;

            for (int i = 0; i < birseyler.Length; i++)
            {
                char okunanKararker = birseyler[i];

                if (Array.IndexOf(sesliler, okunanKararker) > -1) // aranan eleman dizide vardır...
                {
                    sesliSayisi++;
                }
            }

            sesliSayisi = 0;
            foreach (char iteö in birseyler)
            {
                if (Array.IndexOf(sesliler, iteö) > -1)
                {
                    sesliSayisi++;
                }
            }

            Console.WriteLine($"cümle içinde geçen sesli sayısı = {sesliSayisi}");

            Console.ReadKey();
        }
    }
}
