using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XFEOpenMapsSample
{
    public partial class MainPage : ContentPage
    {
        private Placemark placemark = new Placemark
        {
            CountryName = "United States",
            AdminArea = "WA",
            Thoroughfare = "Microsoft Building 25",
            Locality = "Redmond"
        };

        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Map.OpenAsync(47.6529, -122.1422);
        }

        async void Button_Clicked1(System.Object sender, System.EventArgs e)
        {
            await Map.OpenAsync(47.6529, -122.1422, new MapLaunchOptions
            {
                Name = "Not Microsoft Campus",
                NavigationMode = NavigationMode.Driving
            });
        }

        async void Button_Clicked2(System.Object sender, System.EventArgs e)
        {
            await placemark.OpenMapsAsync();
        }
    }
}
