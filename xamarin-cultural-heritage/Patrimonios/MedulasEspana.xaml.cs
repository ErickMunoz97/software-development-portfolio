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
    public partial class MedulasEspana : ContentPage
    {
        public MedulasEspana()
        {
            InitializeComponent();
        }
        
        private async void Button_Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}