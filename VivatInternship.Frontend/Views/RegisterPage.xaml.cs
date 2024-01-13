using VivatInternship.Frontend.ViewModels;

namespace VivatInternship.Frontend.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = new RegisterViewModel();
    }
}