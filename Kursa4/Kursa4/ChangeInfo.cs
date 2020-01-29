using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursa4
{
    class ChangeInfo
    {
        static public int changeInfo(Ship[] ship)
        {
            int answer = 0;
            int answerShip = 0;
            int answerPort = 0;
            int answerPortVisit = 0;
            Console.WriteLine("Хотите изменить информацию о кораблях, портах и посещении портов? 1 - корабль  2 - порт  3 - посещение портов  4 - продолжить  0 - выход");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine("Введите какой корабль изменить?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;
                    ship[answerShip] = new Ship();
                    break;

                case 2:
                    Console.WriteLine("Введите какой корабль изменить?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какой порт изменить?");
                    answerPort = int.Parse(Console.ReadLine()) - 1;
                    ship[answerShip].ports[answerPort] = new Port();
                    break;

                case 3:
                    Console.WriteLine("Введите какой корабль изменить?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какое посещение портов изменить?");
                    answerPortVisit = int.Parse(Console.ReadLine()) - 1;
                    ship[answerShip].portvisits[answerPortVisit] = new PortVisit();
                    break;

                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
        static public int AddInfo(Ship[] ship)
        {

            int answer = 0;
            int answerShip = 0;
            Console.WriteLine("Вы хотите добавить информацию? 1 - корабль, 2 - порт, 3 - посещение портов, 4 - продолжить, 0 - выход ");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Добавление кораблей:");
                    Array.Resize(ref ship, ship.Length + 1);
                    ship[ship.Length] = new Ship();
                    break;
                case 2:
                    Console.WriteLine("Введите к какому кораблю добавить порт?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Добавление портов:");
                    ship[answerShip].ports.Add(new Port());
                    break;
                case 3:
                    Console.WriteLine("Введите к какому кораблю добавить посещение портов?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Введите какое посещение портов удалить?");
                    ship[answerShip].portvisits.Add(new PortVisit());
                    break;
                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
        static public int DeleteInfo(Ship[] ship)
        {

            int answer = 0;
            int answerShip = 0;
            int answerPort = 0;
            int answerPortVisit = 0;
            Console.WriteLine("Вы хотите удалить информацию? 1 - корабль, 2 - порт, 3 - посещение портов, 4 - продолжить, 0 - выход  ");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Введите какой корабль удалить?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;
                    Array.Clear(ship, answerShip, 1);
                    break;
                case 2:
                    Console.WriteLine("Введите какой корабль удалить?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какой порт удалить?");
                    answerPort = int.Parse(Console.ReadLine()) - 1;
                    ship[answerShip].ports.RemoveAt(answerPort);
                    break;
                case 3:
                    Console.WriteLine("Введите какой корабль удалить?");
                    answerShip = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какое посещение портов удалить?");
                    answerPortVisit = int.Parse(Console.ReadLine()) - 1;
                    ship[answerShip].portvisits.RemoveAt(answerPortVisit);
                    break;
                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
    }
}
