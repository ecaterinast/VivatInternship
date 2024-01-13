using IronBarCode;
using System;
using VivatInternship.Frontend.Clients;
using VivatInternship.Frontend.Models;
using VivatInternship.Frontend.ViewModels;

namespace VivatInternship.Frontend.Views;

public partial class ScannerPage : ContentPage
{
    ScannerService scannerService = new ScannerService();
    public ScannerPage()
    {
        InitializeComponent();
        BindingContext = new ScannerViewModel();
    }

    private async void SelectBarcode(object sender, EventArgs e)
    {
        var images = await FilePicker.Default.PickAsync(new PickOptions
        {
            PickerTitle = "Pick image",
            FileTypes = FilePickerFileType.Images
        });
        var imageSource = images.FullPath.ToString();
        barcodeImage.Source = imageSource;
        var result = BarcodeReader.Read(imageSource).First().Text;
        outputText.Text = result;

        UIItemModel item = await scannerService.FindItemAsync(result);
        if (item != null)
        {
            DataStoreService.CartList.Add(item);
        }
    }

    private async void CopyEditorText(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(outputText.Text);
        await DisplayAlert("Success", "Text is copied!", "OK");
    }
}