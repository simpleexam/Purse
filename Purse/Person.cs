using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    internal class Person : IPurse
    {
        public string? Name { get; set; }    //имя пользователя
        private double _summ; //закрытое поле суммы
        public double Summ { get => _summ; set => _summ=value; } //свойство суммы

        public void AddMoney(double addedSumm) //добавление денег на счет
        {
            Summ += addedSumm;
        }

        public double DecMoney(double decSumm) //снятие денег со счета
        {
            Summ-= decSumm;
            return Summ;
        }
    }
}
