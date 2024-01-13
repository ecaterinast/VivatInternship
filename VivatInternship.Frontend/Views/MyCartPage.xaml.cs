using CommunityToolkit.Mvvm.Input;
using VivatInternship.Frontend.ViewModels;

namespace VivatInternship.Frontend.Views;

public partial class MyCartPage : ContentPage
{
    public MyCartPage()
    {
        InitializeComponent();
        BindingContext = new MyCartViewModel();
    }
}