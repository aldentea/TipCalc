using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TipCalc.Core.Services;

using MvvmCross.ViewModels; // for MvxViewModel
using MvvmCross.Navigation; // for IMvxViewModel
using MvvmCross.Commands; // for (I)MvxCommand

namespace TipCalc.Core.ViewModels
{
	public class TipViewModel : MvxViewModel
	{
		#region SubTotalプロパティ
		public double SubTotal
		{
			get => _subTotal;
			set
			{
				_subTotal = value;
				RaisePropertyChanged(() => SubTotal);
				Recalculate();
			}
		}
		double _subTotal;
		#endregion

		#region GenerosityTotalプロパティ
		public int Generosity
		{
			get => _generosity;
			set
			{
				_generosity = value;
				RaisePropertyChanged(() => Generosity);
				Recalculate();
			}
		}
		int _generosity;
		#endregion

		#region Tipプロパティ
		public double Tip
		{
			get => _tip;
			set
			{
				_tip = value;
				RaisePropertyChanged(() => Tip);
			}
		}
		double _tip;
		#endregion

		readonly ICalculationService _calculationService;
		readonly IMvxNavigationService _navigationService;

		public TipViewModel(ICalculationService calculationService, IMvxNavigationService navigationService)
		{
			_calculationService = calculationService;
			_navigationService = navigationService;
		}

		public async override Task Initialize()
		{
			await base.Initialize();

			_subTotal = 100;
			_generosity = 10;
			Recalculate();

		}

		private void Recalculate()
		{
			Tip = _calculationService.TipAmount(SubTotal, Generosity);
		}

		public IMvxCommand GoToSecondCommand
		{
			get
			{
				return _goToSecondCommand ?? (_goToSecondCommand = new MvxCommand(async () => await _navigationService.Navigate<SecondViewModel>()));
			}
		}
		private IMvxCommand _goToSecondCommand;
	}
}
