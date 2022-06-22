using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Contact
    {

        private string isim;
        private string soyIsim;
        private int telefonNumarasi;
        

        public string name
        {
            get { return isim; }
            set { isim = value; }
        }

        public string lastName
        {

            get { return soyIsim; }
            set { soyIsim = value; }
        }

        public int phoneNumber
        {
            get { return telefonNumarasi; }
            set { telefonNumarasi = value; }
        }

        public Contact() 
        {
            
        
        }

        public Contact(string name, string lastName, int telNo)
        {
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = telNo;
        }

       



    }
}
