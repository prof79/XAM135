// MainPage.xaml.cs

namespace Alignment.UWP
{
    public sealed partial class MainPage
	{
		public MainPage()
		{
			this.InitializeComponent();

			LoadApplication(new Alignment.App());
		}
	}
}
