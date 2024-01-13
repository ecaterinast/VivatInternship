using Microsoft.Maui.Platform;
using VivatInternship.Frontend.Handlers;
using VivatInternship.Frontend.Models;

namespace VivatInternship.Frontend;

public partial class App : Application
{
     public static UIUserModel UserDetails;
     public App()
     {
          InitializeComponent();
          Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(""); ;
          //Borderless entry
          Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
               {
                    if (view is BorderlessEntry)
                    {
#if __ANDROID__
		               handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif __IOS__
                         handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
                    }

               });

          MainPage = new AppShell();
     }
}
