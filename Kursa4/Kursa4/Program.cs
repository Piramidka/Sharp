using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Kursa4
{
    class Program
    {
        static void Main(string[] args)
        {

            int count;
            int answer;
            int globalAnswer = 0;
            bool returnWhile = true;
            Files file = new Files();
            Console.WriteLine("---------------------------------------------------------------------------");
            while (returnWhile)
            {
                Console.WriteLine("Выбирете что сделать дальше \n 1 - Прочитать значение из файла \n 2 - Записать новые значения ");
                globalAnswer = int.Parse(Console.ReadLine());
                switch (globalAnswer)
                {
                    case 1:
                        
                        file.createDirectory();
                        readFile(file);
                        break;

                    case 2:
                        Console.WriteLine("Введите кол - во кораблей: ");
                        do
                        {
                            count = int.Parse(Console.ReadLine());
                            if (count <= 0)
                            {
                                Console.WriteLine("Введено неверное число, попробуйте заново");
                            }
                        } while (count <= 0);

                        Ship[] ship = new Ship[count];
                        for (int i = 0; i < count; i++)
                        {
                            ship[i] = new Ship();
                            Console.WriteLine("----------------------------------------");
                        }
                        Console.WriteLine("Что вы хотите сделать? \n 1 - Изменить введеную ифнормациию \n 2 - Добавить информацию \n 3 - Удалить ифнормацию \n 0 - ПРОДОЛЖИТЬ ");
                        answer = int.Parse(Console.ReadLine());
                        do
                        {
                            switch (answer)
                            {
                                
                                case 1:
                                    do
                                    {
                                        answer = ChangeInfo.changeInfo(ship);
                                    } while (answer != 0);
                                    break;
                                
                                case 2:
                                    do
                                    {
                                        answer = ChangeInfo.AddInfo(ship);
                                    } while (answer != 0);
                                    break;
                               
                                case 3:
                                    do
                                    {
                                        answer = ChangeInfo.DeleteInfo(ship);
                                    } while (answer != 0);
                                    break;
                            }
                        } while (answer != 0);

                        writeInFileShip(count, ship, file);
                        break;
                    default:
                        returnWhile = false;
                        break;
                }
            }
        }
        static public void writeInFileShip(int count, Ship[] ship, Files file)
        {
            file.createDirectory();
            file.cleanDirectory();
            for (int i = 0; i < count; i++)
            {
                DirectoryInfo dir;
                dir = Directory.CreateDirectory($@"{file.dir}\DIRECTORY\Ship{i}");


                //file.fileWriterShip($"ship{i}\\ship{i}", ship[i]);
                //for (int j = 0; j < ship[i].ports.Count; j++)
                //{
                //   file.fileWriterPort($"ship{i}\\ship{i}port{j}", ship[i].ports[j]);
                //}
                //for (int j = 0; j < ship[i].portvisits.Count; j++)
                //{
                //   file.fileWriterPortVisit($"ship{i}\\ship{i}portvisit{j}", ship[i].portvisits[j]);
                //}
            }
            Console.WriteLine("Запись завершена!");
        }
        static public void readFile(Files file)
        {
            int i = 0;
            foreach (DirectoryInfo d in file.directory.GetDirectories())
            {
                Console.WriteLine($"Корабль № {i}");
                Console.WriteLine("========================");
                file.fileReaderShip($"ship{i}\\ship{i}");
                Console.WriteLine("========================");
                string[] searchPort = Directory.GetFiles($@"{file.dir}\DIRECTORY\ship{i}\", $"ship{i}port{i}*");
                string[] searchPortVisit = Directory.GetFiles($@"{file.dir}\DIRECTORY\ship{i}\", $"ship{i}portvisit{i}*");
                int j = 0;
                foreach (string f in searchPort)
                {
                    Console.WriteLine($"Порт № {j}");
                    file.fileReaderPort($"ship{i}\\ship{i}port{j}");
                    Console.WriteLine("========================");
                    j++;
                }
                Console.WriteLine("ПОСЕЩЕНИЕ ПОРТОВ:");
                Console.WriteLine();
                j = 0;
                foreach (string f in searchPortVisit)
                {
                    Console.WriteLine($"Посещение портов № {j}");
                    file.fileReaderPortVisit($"ship{i}\\ship{i}portvisit{j}");
                    Console.WriteLine("========================");
                    j++;
                }
                i++;
            }
            Console.WriteLine("Чтение завершено");
        }
    }
}
