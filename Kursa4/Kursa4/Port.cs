using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursa4
{
    class Port
    {
        private string portName;
        private string Country;
        private string PortCategory;

        public Port()
        {
            Console.WriteLine("Введите название порта : ");
            do
            {
                portName = Console.ReadLine();    
                if (String.IsNullOrEmpty(portName))
                {
                    Console.WriteLine("Название порта не указано, попробуйте еще раз :");
                }
            } while (String.IsNullOrEmpty(portName));

            Console.WriteLine("Введите страну : ");
            do
            {
                Country = Console.ReadLine();
                if (String.IsNullOrEmpty(Country))
                {
                    Console.WriteLine("Название страны не указано, попробуйте еще раз :");
                }
            } while (String.IsNullOrEmpty(Country));

            Console.WriteLine("Введите категорию порта : ");
            do
            {
                PortCategory = Console.ReadLine();
                if (String.IsNullOrEmpty(PortCategory))
                {
                    Console.WriteLine("Категория порта не указана, попробуйте еще раз :");
                }
            } while (String.IsNullOrEmpty(PortCategory));
        }
        public void printInformationPort()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Название порта : {portName} \n Страна : {Country} \n Категория порта : {PortCategory}");
            Console.WriteLine("===============================================");
        }

        public string getPortName()
        {
            return portName;
        }

        public string getCountry()
        {
            return Country;
        }

        public string getPortCategory()
        {
            return PortCategory;
        }
    }
}
