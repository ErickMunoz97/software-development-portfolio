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
    public partial class México : ContentPage
    {
        public México()
        {
            InitializeComponent();
        }
        private async void Button_Zacatecas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ZacatecasMexico());
        }
        private async void Button_Maya(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MayaMexico());
        }
        private async void Button_Campeche(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CampecheMexico());
        }
        private async void Button_Tequila(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TequilaMexico());
        }
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}