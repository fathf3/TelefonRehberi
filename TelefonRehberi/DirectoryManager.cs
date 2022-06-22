using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class DirectoryManager
    {
        List<Contact> contacts = new List<Contact>();

        public DirectoryManager()
        {
            contacts.Add(new Contact("Fatih", "Mutlu", 1111));
            contacts.Add(new Contact("Ismail", "Mutlu", 2222));
            contacts.Add(new Contact("Gulsum", "Mutlu", 3333));
            contacts.Add(new Contact("Mithat", "Mutlu", 1111));
            contacts.Add(new Contact("Ervanur", "Mutlu", 5555));
            contacts.Add(new Contact("Ervanur", "Mutlu", 5555));
        }

        public void Insert()
        {
            Contact contact = new Contact();
            Console.Write("Lutfen isim giriniz : ");
            contact.name = Console.ReadLine();
            Console.Write("Lutfen soyisim giriniz : ");
            contact.lastName = Console.ReadLine();
            Console.Write("Lutfen telefon numarasi giriniz : ");
            contact.phoneNumber = int.Parse(Console.ReadLine());
            contacts.Add(contact);

        }

        public void Delete(string data)
        {
            int durum = 2;

            while (durum == 2)
            {

                if (isValid(data))
                {

                    Console.Write(data + "  kisi rehberden silinmek uzere, onayliyor musunuz ? (y / n) : ");
                    if (Convert.ToChar(Console.ReadLine()) == 'y')
                    {
                        Console.WriteLine(data + " rehberden silindi");
                        foreach (var item in contacts)
                        {
                            if (item.name.ToLower() == data.ToLower())
                            {
                                contacts.RemoveAt(contacts.IndexOf(item));
                                break;
                            }
                        }

                        durum = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("İslem iptal edildi");
                        durum = 0;
                        break;
                    }

                }
                else if (!isValid(data))
                {
                    Console.WriteLine("Aradiginiz kriterlere uygun biri bulunamadi");
                    Console.WriteLine("Sonlandirmak icin : (1)");
                    Console.WriteLine("Yeniden denemek icin : (2)");
                    durum = int.Parse(Console.ReadLine());
                    if (durum == 2)
                    {
                        Console.WriteLine("Yeni isim giriniz ");
                        data = Console.ReadLine();
                    }
                    else
                    {
                        durum = 0;
                        break;
                    }
                }
                else
                {
                    durum = 0;
                    break;
                }



            }
           


        }


        public void Update(string data)
        {
            int durum = 2;

            while (durum == 2)
            {

                if (isValid(data))
                {

                    Console.Write(data + "  numarasi guncelleniyor, onayliyor musunuz ? (y / n) : ");
                    if (Convert.ToChar(Console.ReadLine()) == 'y')
                    {
                        
                        foreach (var item in contacts)
                        {
                            if (item.name.ToLower() == data.ToLower())
                            {
                                Console.WriteLine("Yeni Numarayi Giriniz : ");
                                item.phoneNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine(data + " numarasi guncellendi");
                                break;
                            }
                        }

                        durum = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("İslem iptal edildi");
                        durum = 0;
                        break;
                    }

                }
                else if (!isValid(data))
                {
                    Console.WriteLine("Aradiginiz kriterlere uygun biri bulunamadi");
                    Console.WriteLine("Sonlandirmak icin : (1)");
                    Console.WriteLine("Yeniden denemek icin : (2)");
                    durum = int.Parse(Console.ReadLine());
                    if (durum == 2)
                    {
                        Console.WriteLine("Yeni isim giriniz ");
                        data = Console.ReadLine();
                    }
                    else
                    {
                        durum = 0;
                        break;
                    }
                }
                else
                {
                    durum = 0;
                    break;
                }



            }



        }


        public void PhoneBookList()
        {
            Console.WriteLine("**********************");
            foreach(var item in contacts)
            {
                Console.WriteLine("Isim : " + item.name);
                Console.WriteLine("Soyisim : " + item.lastName);
                Console.WriteLine("Telefon numarasi : " + item.phoneNumber);
                Console.WriteLine("-----------------------");
            }

        }


        public void Search()
        {
            Console.WriteLine("isime gore 1");
            Console.WriteLine("telefona gore 2");
            Console.Write("Secim : ");
            int secim = int.Parse(Console.ReadLine());
            if(secim == 1)
            {
                string isim;
                Console.Write("İsim giriniz : ");
                isim = Console.ReadLine();

                foreach(var item in contacts)
                {
                    if(isim.ToLower() == item.name.ToLower())
                    {
                        Console.WriteLine();
                        Console.WriteLine("Isim : " + item.name); 
                        Console.WriteLine("Soyisim : " + item.lastName); 
                        Console.WriteLine("Telefon Numarasi : " + item.phoneNumber);
                        Console.WriteLine("************************ \n");

                    }
                }
            }
            else
            {
                int tel;
                Console.Write("Telefon giriniz : ");
                tel = int.Parse(Console.ReadLine());

                foreach (var item in contacts)
                {
                    if (tel == item.phoneNumber)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Isim : " + item.name);
                        Console.WriteLine("Soyisim : " + item.lastName);
                        Console.WriteLine("Telefon Numarasi : " + item.phoneNumber);
                        Console.WriteLine("************************ \n");

                    }
                }

            }

        }

        //public void Search(string data) { }

        //public void Search(int data) { }
        


        public bool isValid(string data)
        {
            foreach (var item in contacts)
                if (data.ToLower() == item.lastName.ToLower() || data.ToLower() == item.name.ToLower())
                {
                    return true;
                }

            return false;

        }

    }



}
