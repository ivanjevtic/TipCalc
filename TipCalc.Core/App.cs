using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalc.Core.Classes;
using TipCalc.Core.Interface;
using TipCalc.Core.Models;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipCalcModel>());
        }
    }
}
