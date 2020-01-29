using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursa4
{
    class Ship
    {
        public string shipName;
        public string typeOfShip;
        public float displacement;
        public string homePort;
        public string captain;
        public List<Port> ports;
        public List<PortVisit> portvisits;

        public Ship()
        {
            InputData();
            printInformationShip();
            Console.WriteLine("информация о портах :");
            createPort();
            printPort();
            Console.WriteLine("информация о посещении портов :");
            createPortVisit();
            printInformationShip();
            printPort();
            printPortVisit();
        }
        void InputData()
        {
            Console.WriteLine("Введите название корабля : ");
            do
            {
                shipName = Console.ReadLine();
                if (String.IsNullOrEmpty(shipName))
                {
                    Console.WriteLine("Название корабля не указано, попробуйте еще раз :");
                }
            } while (String.IsNullOrEmpty(shipName));

            Console.WriteLine("Укажите тип корабля : ");
            do
            {
                typeOfShip = Console.ReadLine();
                if (String.IsNullOrEmpty(typeOfShip))
                {
                    Console.WriteLine("Название порта не указано, попробуйте еще раз :");
                }
            } while (String.IsNullOrEmpty(typeOfShip));

            Console.WriteLine("Введите водоизмещение: ");
            do
            {
                displacement = int.Parse(Console.ReadLine());
                if (displacement <= 0)
                {
                    Console.WriteLine("Неверно задано водоизмещение, попробуйте еще раз :");
                }
            } while (displacement <= 0);

            Console.WriteLine("Введите порт приписки : ");
            do
            {
                homePort = Console.ReadLine();
                if (String.IsNullOrEmpty(homePort))
                {
                    Console.WriteLine("Название порта не указано, попробуйте еще раз :");
                }
            } while (String.IsNullOrEmpty(homePort));

            Console.WriteLine("Укажите фамилию капитана : ");
            do
            {
                captain = Console.ReadLine();
                if (String.IsNullOrEmpty(captain))
                {
                    Console.WriteLine("Название порта не указано, попробуйте еще раз :");
                }
            } while (String.IsNullOrEmpty(captain));
        }

        public void createPort()
        {
            ports = new List<Port>();
            ports.Add(new Port());
        }
        public void createPortVisit()
        {
            int answer = 0;
            portvisits = new List<PortVisit>();
            do
            {
                portvisits.Add(new PortVisit());
                Console.WriteLine("Ввести еще одну информацию о посещении портов? 1 - да   0 - нет");
                answer = int.Parse(Console.ReadLine());
            } while (answer != 0);
        }
        public void printPort()
        {
            int i = 0;
            foreach (var val in ports)
            {
                ports[i].printInformationPort();
                i++;
            }
        }
        public void printPortVisit()
        {
            int i = 0;
            foreach (var val in ports)
            {
                portvisits[i].printInformationPortVisit();
                i++;
            }
        }
        public void printInformationShip()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Название корабля : {shipName} \n Тип корабля : {typeOfShip} \n Водоизмещение : {displacement} \n Порт приписки : {homePort} \n Капитан : {captain}");
            Console.WriteLine("===============================================");
        }
    }
}
