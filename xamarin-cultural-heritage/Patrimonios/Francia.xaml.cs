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
    public partial class Francia : ContentPage
    {
        public Francia()
        {
            InitializeComponent();
        }
        
        private async void Button_Basilica(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasilicaFrancia());
        }
        private async void Button_Midi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MidiFrancia());
        }
        private async void Button_Faro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FaroFrancia());
        }
        private async void Button_Iglesia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IglesiaFrancia());
        }
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}