using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using MvvmCross;

namespace TipCalc.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			//MvvmCross.Mvx.RegisterType<Services.ICalculationService, Services.CalcurationService>();
			Mvx.IoCProvider.RegisterType<Services.ICalculationService, Services.CalcurationService>();

			RegisterAppStart<ViewModels.TipViewModel>();
		}

	}



}
