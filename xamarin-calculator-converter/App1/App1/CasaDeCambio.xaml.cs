using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1 {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CasaDeCambio : ContentPage {
        // Demonstration rate, NOT a real-time exchange rate.
        private const decimal PesosPerDollar = 19.30m;
        public CasaDeCambio() { InitializeComponent(); }

        private void Dolares_Clicked(object sender, EventArgs e) { ConvertCurrency(true); }
        private void Pesos_Clicked(object sender, EventArgs e) { ConvertCurrency(false); }

        private void ConvertCurrency(bool pesosToDollars) {
            decimal amount;
            if (!decimal.TryParse(dinero.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out amount)
                || amount < 0) {
                Resultado.Text = "Introduce una cantidad válida, mayor o igual a cero.";
                return;
            }
            decimal value = pesosToDollars ? amount / PesosPerDollar : amount * PesosPerDollar;
            Resultado.Text = string.Format(CultureInfo.CurrentCulture,
                "{0:N2} {1} equivalen a {2:N2} {3} (tasa de ejemplo: 19.30 MXN/USD).",
                amount, pesosToDollars ? "pesos mexicanos" : "dólares estadounidenses",
                value, pesosToDollars ? "dólares estadounidenses" : "pesos mexicanos");
        }
    }
}
