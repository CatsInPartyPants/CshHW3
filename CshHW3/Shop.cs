using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW3
{
    internal class Shop
    {
        private string _name;
        private string _adress;
        private string _discription;
        private string _phone;
        private string _email;

        public Shop(string name)
        {
            _name = name;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }

        public void SetAdress(string adr)
        {
            _adress = adr;
        }

        public void SetDiscription(string discr)
        {
            _discription = discr;
        }

        public void SetPhone(string ph)
        {
            _phone = ph;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }


        public void ShowShopInfo()
        {
            Console.WriteLine($"Информация о магазине {_name}");
            Console.WriteLine($"Магазин расположен по адресу {_adress}");
            Console.WriteLine($"Для связи с руководством используйте телефон {_phone} " +
                $"или email {_email}");
            Console.WriteLine($"Описание магазина: {_discription}");
        }

    }
}
