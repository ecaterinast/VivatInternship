using System.Collections.ObjectModel;
using VivatInternship.Frontend.Models;

namespace VivatInternship.Frontend.Clients
{
    public static class DataStoreService
     {
         public static ObservableCollection<UIItemModel> CartList = new ObservableCollection<UIItemModel>();
     }
}
