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
    public partial class España : ContentPage
    {
        public España()
        {
            InitializeComponent();
        }
        private async void Button_Aragon(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AragonEspana());
        }
        private async void Button_Burgos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BurgosEspana());
        }
        private async void Button_Medulas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedulasEspana());
        }
        private async void Button_MurallaLugo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MurallaLugoEspana());
        }
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        
    }
}