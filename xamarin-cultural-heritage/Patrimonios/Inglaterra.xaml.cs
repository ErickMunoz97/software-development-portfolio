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
    public partial class Inglaterra : ContentPage
    {
        public Inglaterra()
        {
            InitializeComponent();
        }
        private async void Button_Calzada(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalzadaIngalterra());
        }
        private async void Button_Cuevas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CuevasInglaterra());
        }
        private async void Button_Observatorio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ObservatorioInglaterra());
        }
        private async void Button_Palacio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PalacioInglaterra());
        }
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}