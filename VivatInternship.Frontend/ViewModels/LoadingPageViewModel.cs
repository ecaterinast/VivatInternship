using Newtonsoft.Json;
using VivatInternship.Frontend.Controls;
using VivatInternship.Frontend.Models;

namespace VivatInternship.Frontend.ViewModels
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }
        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");
            if (string.IsNullOrWhiteSpace(userDetailsStr))
            {
                await Shell.Current.GoToAsync("MainPage");
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UIUserModel>(userDetailsStr);
                App.UserDetails = userInfo;
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                await Shell.Current.GoToAsync("MyCartPage");
            }
        }
    }
}
