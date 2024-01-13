using System.Net.Http.Json;
using System.Text.Json;
using VivatInternship.Frontend.Models;

namespace VivatInternship.Frontend.Clients
{
    public class ScannerService
     {
          HttpClient _client;
          JsonSerializerOptions _serializerOptions;

          public ScannerService()
          {
               _client = new HttpClient();
               _serializerOptions = new JsonSerializerOptions
               {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
               };
          }
          public async Task<UIItemModel> FindItemAsync(string basket)
          {
               Uri uri = new Uri("https://localhost:7269/api/Item?barcode="+basket);

               try
               {
                    HttpResponseMessage response = await _client.GetAsync(uri);
                    var data = response.Content.ReadFromJsonAsync<UIItemModel>();
                    return data.Result;
               }
               catch (Exception ex)
               {
                    //Debug.WriteLine(@"\tERROR {0}", ex.Message);
                    return null;
               }
          }

          public async void SendItemToDatabaseAsync(UIItemModel itemBarcode)
          { 
               var response = await _client.PostAsJsonAsync("https://localhost:7269/api/Item", itemBarcode);
               
          }
     }
}

