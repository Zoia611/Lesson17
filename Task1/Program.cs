using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCheck<int> BС1 = new BankCheck<int>();
            BС1.Number = 1;
            BС1.Balance = 300;
            BС1.Name = "Иванов Иван";
            Console.WriteLine(BС1.GetInfo());

            BankCheck<string> BС2 = new BankCheck<string>();
            BС2.Number = 2;
            BС2.Balance = 250;
            BС2.Name = "Петров Петр";
            Console.WriteLine(BС2.GetInfo());

            BankCheck<double> BС3 = new BankCheck<double>();
            BС3.Number = 3;
            BС3.Balance = 150;
            BС3.Name = "Викторов Виктор";
            Console.WriteLine(BС3.GetInfo());

            Console.ReadKey();
        }

        private class BankCheck<T>
        {
            internal bool GetInfo()
            {
                throw new NotImplementedException();
            }
        }
    }
}
