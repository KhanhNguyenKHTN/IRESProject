using IRESProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IRESProject
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new MainPage());
            btnLogin.Clicked += (sender, args) =>
            {
                ChangePage();
            };
            
        }
        public async void ChangePage()
        {
            try
            {
                await Navigation.PushAsync(new NavigationPage(new ScanQRPage()));
            }
            catch (Exception)
            {
                await Navigation.PushModalAsync(new ScanQRPage());
            }
        }
    }
}
