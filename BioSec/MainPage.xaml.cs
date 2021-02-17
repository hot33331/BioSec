using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using Xamarin.Forms;

namespace BioSec
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(Object sender, EventArgs e)
        {
            AuthenticationRequestConfiguration conf =
      new AuthenticationRequestConfiguration("Write your title here",
                                             "Write you reason here");

            var result = await CrossFingerprint.Current.AuthenticateAsync(conf);

            if (result.Authenticated)
            {
                await DisplayAlert("Authenticated", "Congrats you were authenticated!", "Ok");
            }
            else
            {
                await DisplayAlert("Sorry", "You were not authenticated", "Ok");
            }

        }
    }
}
