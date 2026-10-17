using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Patrimonios
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void Button_Italia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Italia());
        }
        private async void Button_China(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new China());
        }
        
        private async void Button_Alemania(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Alemania());
        }

        private async void Button_España(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new España());
        }
        private async void Button_Francia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Francia());
        }
        private async void Button_México(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new México());
        }
        private async void Button_Inglaterra(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inglaterra());
        }
    }
}