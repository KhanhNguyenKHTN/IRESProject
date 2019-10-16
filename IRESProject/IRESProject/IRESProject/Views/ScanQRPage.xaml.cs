using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace IRESProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScanQRPage : ContentPage
	{
        public ScanQRPage ()
		{
			InitializeComponent ();
            btnScan.Clicked += (sender, e) => {
                Scan();
            };
        }
        private async void Scan()
        {
            try
            {
                var options = new MobileBarcodeScanningOptions
                {
                    AutoRotate = false,
                    UseFrontCameraIfAvailable = false,
                    TryHarder = true
                };

                var overlay = new ZXingDefaultOverlay
                {
                    TopText = "Please scan QR code",
                    BottomText = "Align the QR code within the frame"
                };
                var grid = new Grid();
                RowDefinition row1 = new RowDefinition() { Height = 200 };
                RowDefinition row2 = new RowDefinition();
                RowDefinition row3 = new RowDefinition() { Height = 200 };

                grid.RowDefinitions.Add(row1);
                grid.RowDefinitions.Add(row2);
                grid.RowDefinitions.Add(row3);
                Label edit = new Label()
                {
                    Text = "Test layout Scan" + Environment.NewLine +  "(Mr.Khanh)",
                    FontSize = 24,
                    HorizontalTextAlignment = TextAlignment.Center,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalTextAlignment= TextAlignment.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    TextColor = Color.Red,
                };
                Grid.SetRow(edit, 0);
                grid.Children.Add(edit);

                var QRScanner = new ZXingScannerPage(options, grid);

                await Navigation.PushModalAsync(QRScanner);

                QRScanner.OnScanResult += (result) =>
                {
                    // Stop scanning
                    QRScanner.IsScanning = false;

                    // Pop the page and show the result
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        try
                        {
                            Navigation.PopModalAsync(true);
                            //strAccessToken.Text = result.Text.ToUpper().Trim();
                            //DisplayAlert("Scanned Barcode", result.Text, "OK");
                            txtBarcode.Text = result.Text;
                            //Navigation.PushModalAsync(new ScanQRPage() { txtBarcode.Text = result.Text;});
                        }
                        catch
                        {
                            Navigation.PopModalAsync(true);
                        }
                        
                        
                    });

                };

            }
            catch (Exception ex)
            {
                // GlobalScript.SeptemberDebugMessages("ERROR", "BtnScanQR_Clicked", "Opening ZXing Failed: " + ex);
                Device.BeginInvokeOnMainThread(() => {
                    DisplayAlert("Scanned Barcode", ex.ToString(), "OK");
                });
            }
        }
    }
	
}