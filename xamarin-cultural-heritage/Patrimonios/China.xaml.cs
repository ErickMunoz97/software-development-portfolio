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
    public partial class China : ContentPage
    {
        public China()
        {
            InitializeComponent();
        }
        
        private async void Button_Palacios(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Palacios_Imperiales());
        }
        private async void Button_Grutas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GrutasDeMogaoChina());
        }
        private async void Button_MonteTaishan(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MonteTaishanChina());
        }
        private async void Button_GranMuralla(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LaGranMurallaChina());
        }
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
}