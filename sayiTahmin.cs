using System;

class Program
{
    static void Main()
    {
        // Konsol Başlığını Değiştirme;
        Console.Title = "Number Forecast - FRTSOFT";

        // Oyunu yeniden başlatmak için kullanıcıdan gelen cevaba göre program döngüsü başlatılır.
        bool tekrarOyna = true;

        while (tekrarOyna)
        {
            // Konsol ekranını temizler.
            Console.Clear();

            // Rastgele sayı üretici oluşturulur.
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(1, 101);  // 1 ile 100 arasında bir sayı üretilir.
            int tahmin = 0;  // Kullanıcının tahminini tutacak değişken.
            int tahminSayisi = 0;  // Kaç tahminde bulunulduğunu tutan değişken.

            // Program mesajları için rengi mavi olarak ayarla
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin et!");
            Console.WriteLine("Tahmin yapmak için bir sayı girin:");
            Console.ResetColor();  // Rengi eski haline döndür

            // Doğru tahmin edilene kadar döngü devam eder.
            while (tahmin != rastgeleSayi)
            {
                // Kullanıcının girdiği tahmini alır ve sayıya çevirir.
                // Geçersiz bir giriş durumunda hata mesajı verir.
                try
                {
                    // Tahmin girişleri için sarı renk ayarla
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();  // Rengi eski haline döndür
                }
                catch
                {
                    // Hata mesajları için kırmızı renk ayarla
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir sayı girin.");
                    Console.ResetColor();  // Rengi eski haline döndür
                    continue;  // Geçersiz girişte döngü tekrar eder.
                }

                // Tahmin sayısı her girişte artırılır.
                tahminSayisi++;

                // Kullanıcının tahminine göre geri bildirimde bulunulur.
                if (tahmin > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1-100 Arası Sayılar Deneyiniz!");
                    Console.ResetColor();  // Rengi eski haline döndür
                }
                if (tahmin < rastgeleSayi)
                {
                    // Program mesajları için mavi renk ayarla
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Daha büyük bir sayı deneyin.");
                    Console.ResetColor();  // Rengi eski haline döndür
                }
                else if (tahmin > rastgeleSayi && tahmin <= 100)
                {
                    // Program mesajları için mavi renk ayarla
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Daha küçük bir sayı deneyin.");
                    Console.ResetColor();  // Rengi eski haline döndür
                }
                else if(tahmin ==  rastgeleSayi)
                {
                    // Program mesajları için yeşil renk ayarla
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    Console.WriteLine($"Toplamda {tahminSayisi} tahmin yaptınız.");
                    Console.ResetColor();  // Rengi eski haline döndür
                }
            }

            // Oyun bittiğinde kullanıcıya yeniden oynamak isteyip istemediği sorulur.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Tekrar oynamak ister misiniz? (E/H)");
            Console.ResetColor();  // Rengi eski haline döndür
            string cevap = Console.ReadLine().ToUpper();  // Kullanıcının girdiği cevap büyük harfe çevrilir.

            // Kullanıcının cevabı 'E' ise oyun yeniden başlar, aksi takdirde oyun biter.
            if (cevap == "E")
            {
                tekrarOyna = true;  // Döngü yeniden başlar.
            }
            else
            {
                tekrarOyna = false;  // Döngü sona erer ve program kapanır.
                // Program mesajları için yeşil renk ayarla
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Oyun bitti. Tekrar görüşmek üzere!");
                Console.ResetColor();  // Rengi eski haline döndür
            }
        }
    }
}