using System.Text;
using System.Text.Json;
using VivatInternship.Frontend.Interfaces;
using VivatInternship.Frontend.Models;

namespace VivatInternship.Frontend.Clients
{
    public class BasketService : IBasketService
     {
          HttpClient _client;
          JsonSerializerOptions _serializerOptions;
          public BasketService()
          {
               _client = new HttpClient();
               _serializerOptions = new JsonSerializerOptions
               {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
               };
          }
          public async Task SaveBasketAsync(UIBasketModel basket, bool isNewItem = false)
          {
               Uri uri = new Uri("https://localhost:8980/mainpage");

               try
               {
                    string json = JsonSerializer.Serialize<UIBasketModel>(basket, _serializerOptions);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await _client.PostAsync(uri, content);
               }
               catch (Exception ex) { }
          }
     }
}
