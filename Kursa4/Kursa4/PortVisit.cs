using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursa4
{
    class PortVisit
    {
        private DateTime dateOfVisit;
        private DateTime dateOfDeparture;
        private int berthNumber;
        private string visitPurpose;

        public PortVisit()
        {
            int day = 0;
            int month = 0;
            Console.WriteLine("Введите день посещения порта: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц посещения порта: ");
            month = int.Parse(Console.ReadLine());
          
            dateOfVisit = new DateTime(2019, month, day);

            Console.WriteLine("Введите день убытия: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц убытия: ");
            month = int.Parse(Console.ReadLine());
            
            dateOfDeparture = new DateTime(2019, month, day);

            Console.WriteLine("Введите номер причала: ");
            do
            {
                berthNumber = int.Parse(Console.ReadLine());
                if (berthNumber <= 0)
                {
                    Console.WriteLine("Неверно задан номер причала, попробуйте еще раз :");
                }
            } while (berthNumber <= 0);

            Console.WriteLine("Введите цель посещения :");
            visitPurpose = Console.ReadLine();
            if (String.IsNullOrEmpty(visitPurpose))
            {
                visitPurpose = "Цель посещения не известна";
                Console.WriteLine("Задано значение по умолчанию.");
            }
        }
        public void printInformationPortVisit()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Дата посещения порта : {dateOfVisit.ToString("d")} \n Дата убытия : {dateOfDeparture.ToString("d")} \n Номер причала : {berthNumber} \n Цель посещения : {visitPurpose}");
            Console.WriteLine("===============================================");
        }

        public DateTime getDateOfVisit()
        {
            return dateOfVisit;
        }

        public DateTime getDateOfDeparture()
        {
            return dateOfDeparture;
        }

        public int getBerthNumber()
        {
            return berthNumber;
        }

        public string getVisitPurpose()
        {
            return visitPurpose;
        }
    }
}
