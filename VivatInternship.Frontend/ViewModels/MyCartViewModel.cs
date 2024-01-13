using CommunityToolkit.Mvvm.Input;
using VivatInternship.Frontend.Clients;
using VivatInternship.Frontend.Models;

namespace VivatInternship.Frontend.ViewModels
{
    public partial class MyCartViewModel : BaseViewModel
    {
        public List<UIItemModel> Items { get; set; }
        public double Total { get; set; }

        [RelayCommand]
        async void RemoveItem(String name)
        {
            var n = DataStoreService.CartList.Where(x => x.Name == name).First();
            DataStoreService.CartList.Remove(n);
        }
        public MyCartViewModel() { }
    }
}
