using VivatInternship.Frontend.ViewModels;
using VivatInternship.Frontend.Views;

namespace VivatInternship.Frontend;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        BindingContext = new AppShellViewModel();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(MyCartPage), typeof(MyCartPage));
        Routing.RegisterRoute("RegisterPage", typeof(RegisterPage));
        Routing.RegisterRoute("ScannerPage", typeof(ScannerPage));
    }
}
