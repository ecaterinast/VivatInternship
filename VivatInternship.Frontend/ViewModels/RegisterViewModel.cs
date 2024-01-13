using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net.Http.Json;
using System.Text.Json;
using VivatInternship.Frontend.Models;

namespace VivatInternship.Frontend.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public UIRegisterModel RegisterModel { get; set; }
        public IRelayCommand RegisterCommand { get; set; }

        public RegisterViewModel()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            RegisterModel = new UIRegisterModel();

            RegisterCommand = new RelayCommand(async () =>
            {
                var username = RegisterModel.Username;
                var password = RegisterModel.Password;
                var confirmed = RegisterModel.ConfirmedPassword;
                string result = string.Empty;
                if (confirmed != password)
                {
                    result = string.IsNullOrEmpty(RegisterModel.ConfirmedPassword) ? string.Empty : "The passwords do not match";
                }
                else
                {
                    await RegisterUser(RegisterModel);
                    await Shell.Current.DisplayAlert("Success", $"The user {username} was created successfully!", "OK");
                }
            });
        }

        public async Task<Object> RegisterUser(UIRegisterModel registerModel)
        {
            Uri uri = new Uri("https://localhost:7269/api/register");

            try
            {
                HttpResponseMessage response = await _client.PostAsJsonAsync(uri, registerModel);
                var data = response.Content.ReadFromJsonAsync<UIRegisterModel>();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
