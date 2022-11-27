using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BankCheck
    {
         A number;
        double balance;
        string name;

        public A Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string GetInfo()
        {
            return $"{Number} Остаток по счету: {Balance}тыс$ ФИО: {Name}";
        }
    }
}
