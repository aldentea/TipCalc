using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.ViewModels;	// for MvxViewModel
using MvvmCross.Commands;	// for (I)MvxCommand

using MvvmCross.Navigation;	// for IMvxViewModel

namespace TipCalc.Core.ViewModels
{
	public class SecondViewModel : MvxViewModel
	{
		public IMvxCommand BackCommand
		{
			get
			{
				return _backCommand ?? (_backCommand = new MvxCommand(async () => await Close()));
			}
		}
		IMvxCommand _backCommand;

		readonly IMvxNavigationService _navigationService;
		public SecondViewModel(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;
		}


		public async Task Close()
		{
			// とりあえず値を返さない。
			await _navigationService.Close(this);
		}
	}
}
