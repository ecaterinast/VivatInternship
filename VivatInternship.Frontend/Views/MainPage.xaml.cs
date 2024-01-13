using VivatInternship.Frontend.ViewModels;

namespace VivatInternship.Frontend;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}

