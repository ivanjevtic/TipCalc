using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalc.Core.Interface;

namespace TipCalc.Core.Classes
{
    public class Calculation : ICalculation
    {
        public double TipAmount(double subTotal, int generosity)
        {
            return subTotal * (double)generosity/(double)100.0;
        }
    }
}
