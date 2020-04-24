using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalc.Core.Services
{
	public interface ICalculationService
	{
		double TipAmount(double subTotal, int generosity);
	}


	public class CalcurationService : ICalculationService
	{
		public double TipAmount(double subTotal, int generosity)
		{
			return subTotal * (double)generosity / 100.0;
		}
	}

}
