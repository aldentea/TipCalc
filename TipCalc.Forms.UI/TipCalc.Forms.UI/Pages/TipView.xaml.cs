using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvvmCross.Forms.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.Forms.UI.Pages
{
	public partial class TipView : MvxContentPage<TipViewModel>
	{
		public TipView()
		{
			InitializeComponent();
		}
	}
}