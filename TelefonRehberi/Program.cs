using System;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryManager manager = new DirectoryManager();
            int durum = 1;
            while (durum == 1)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Lutfen islem seciniz");
                Console.WriteLine("(1) Yeni numara ekle");
                Console.WriteLine("(2) Numara sil");
                Console.WriteLine("(3) Numara guncelle");
                Console.WriteLine("(4) Rehberi listele");
                Console.WriteLine("(5) Rehberde arama yapmak");
                Console.WriteLine("(6) Cikis");
                Console.Write("Secim : ");
                int secim = int.Parse(Console.ReadLine());

                


                switch (secim)
                {
                    case 1:
                        manager.Insert();
                        break;
                    case 2:
                        Console.Write("İsim : ");
                        string isim = Console.ReadLine();
                        manager.Delete(isim);
                        break;
                    case 3:
                        Console.Write("İsim : ");
                        isim = Console.ReadLine();
                        manager.Update(isim);
                        break;
                    case 4:
                        manager.PhoneBookList();
                        break;
                    case 5:
                        manager.Search();
                        break;
                    case 6:
                        Console.WriteLine("Cikis Yapildi");
                        durum = 0;
                        break;
                }

            }


        }
    }
}
