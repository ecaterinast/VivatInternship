using CommunityToolkit.Mvvm.Input;

namespace VivatInternship.Frontend.ViewModels
{
    public partial class ScannerViewModel : BaseViewModel
    {
        [RelayCommand]
        Task MyCartNavigation() => Shell.Current.GoToAsync("MyCartPage");

        [RelayCommand]
        Task AddItemManual() => Shell.Current.DisplayAlert("Success!", "Item X was added to cart!", "OK");
    }
}
