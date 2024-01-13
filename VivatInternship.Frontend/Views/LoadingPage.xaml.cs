using VivatInternship.Frontend.ViewModels;

namespace VivatInternship.Frontend.Views;

public partial class LoadingPage : ContentPage
{
    public LoadingPage()
    {
        InitializeComponent();
        BindingContext = new LoadingPageViewModel();
    }
}