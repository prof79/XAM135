// MainPage.xaml.cs

namespace TipCalculator.UWP
{
    public sealed partial class MainPage
	{
		public MainPage()
		{
			this.InitializeComponent();

			LoadApplication(new TipCalculator.App());
		}
	}
}
