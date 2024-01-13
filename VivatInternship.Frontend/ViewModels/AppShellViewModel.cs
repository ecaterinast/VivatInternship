using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivatInternship.Frontend.Views;

namespace VivatInternship.Frontend.ViewModels
{
     public partial class AppShellViewModel : BaseViewModel
     {
           [RelayCommand]
           Task ScannerNavigation() => Shell.Current.GoToAsync("ScannerPage");

           /*[RelayCommand]
           Task Logout() => Shell.Current.GoToAsync("MainPage");
           */
           [RelayCommand]
           Task MyCartNavigation() => Shell.Current.GoToAsync("MyCartPage");

          [RelayCommand]
          async void Logout()

          {
               if(Preferences.ContainsKey(nameof(App.UserDetails)))
               {
                    Preferences.Remove(nameof(App.UserDetails));
               }
               await Shell.Current.Navigation.PushAsync(new MainPage());

          }

          //public IRelayCommand LogoutCommand { get; set; } = new RelayCommand(() => Shell.Current.GoToAsync("MainPage"));

          public AppShellViewModel()
          {

          }


     }
}
