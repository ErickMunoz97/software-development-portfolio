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
    public partial class Italia : ContentPage
    {
        public Italia()
        {
            InitializeComponent();
        }
        
        private async void Button_CastelDelMonte(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CastelDelNorteItalia());
        }
        private async void Button_ValCamonica(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArteValCamonica());
        }
        private async void Button_VillaRomana(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VillaRomanaCasale());
        }
        private async void Button_MantuaYSabbionetta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MantuaYSabbionetta());
        }
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}