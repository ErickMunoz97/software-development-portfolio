using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Patrimonios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alemania : ContentPage
    {
        public Alemania()
        {
            InitializeComponent();
        }
        private async void Button_Abadia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbadiaYAltenmuscherAlemania());
        }
        private async void Button_Spira(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CatedralSpiraAlemania());
        }
        private async void Button_Bamberg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BambergAlemania());
        }
        private async void Button_Wartburgo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FortalezaWartburgoAlemania());
        }
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}