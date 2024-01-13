using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using VivatInternship.Frontend.Controls;
using VivatInternship.Frontend.Models;
using VivatInternship.Frontend.Views;

namespace VivatInternship.Frontend.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
     {
          [ObservableProperty]
          private string _username;
          [ObservableProperty]
          private string _password;

          [RelayCommand]
          Task RegisterNavigation() => Shell.Current.GoToAsync(nameof(RegisterPage));

          [RelayCommand]
          async void Login()
          {
               if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
               {
                    //calling api
                    var userDetails = new UIUserModel()
                    {
                         Username = Username,
                         Password = Password
                    };
                    if (Preferences.ContainsKey(nameof(App.UserDetails)))
                    {
                         Preferences.Remove(nameof(App.UserDetails));
                    };

                    string userDetailsString = JsonConvert.SerializeObject(userDetails);
                    Preferences.Set(nameof(App.UserDetails), userDetailsString);
                    App.UserDetails = userDetails;
                    AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                    await Shell.Current.GoToAsync(nameof(MyCartPage));
               }
          }
          public MainPageViewModel() { }

     }
}
