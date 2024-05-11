using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    internal interface IPurse
    {
        double Summ {get;set;}
        void AddMoney(double addedSumm);
        double DecMoney(double decSumm);
    }
}
