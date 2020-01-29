using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursa4
{
    class Files
    {
        public string dir;
        public DirectoryInfo directory;
        public void createDirectory()
        {
            dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            directory = Directory.CreateDirectory("DIRECTORY");
        }
        public void cleanDirectory()
        {
            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                cleanFiles(d);
                d.Delete();
            }
        }
        public void cleanFiles(DirectoryInfo dir)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                f.Delete();
            }
        }

        /*public void fileWriterShip(string filePath, Ship Ship)
        {
            StreamWriter sw = new StreamWriter("DIRECTORY\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"Название корабля : {Ship.shipName}");
            sw.WriteLine($"Тип корабля : {Ship.typeOfShip}");
            sw.WriteLine($"Водоизмещение : {Ship.displacement}");
            sw.WriteLine($"Порт приписки : {Ship.homePort}");
            sw.WriteLine($"Капитан : {Ship.captain}");
            sw.Close();
        }
        public void fileWriterPort(string filePath, Port Port)
        {
            StreamWriter sw = new StreamWriter("DIRECTORY\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"название порта : {Port.getPortName()}");
            sw.WriteLine($"Страна : {Port.getCountry()}");
            sw.WriteLine($"Категория : {Port.getPortCategory()}");
            sw.Close();
        }
        public void fileWriterPortVisit(string filePath, PortVisit PortVisit)
        {
            StreamWriter sw = new StreamWriter("DIRECTORY\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"Дата посещения порта : {PortVisit.getDateOfVisit()}");
            sw.WriteLine($"Дата убытия : {PortVisit.getDateOfDeparture()}");
            sw.WriteLine($"Номер причала : {PortVisit.getBerthNumber()}");
            sw.WriteLine($"Цель посещения : {PortVisit.getVisitPurpose()}");
            sw.Close();
        }*/

        public void fileReaderShip(string filePath)
        {
            StreamReader sr = new StreamReader("DIRECTORY\\" + filePath + ".txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
        public void fileReaderPort(string filePath)
        {
            StreamReader sr = new StreamReader("DIRECTORY\\" + filePath + ".txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
        public void fileReaderPortVisit(string filePath)
        {
            StreamReader sr = new StreamReader("DIRECTORY\\" + filePath + ".txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    } 
}
