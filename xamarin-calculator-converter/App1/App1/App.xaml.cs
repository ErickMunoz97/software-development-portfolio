using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
[assembly:ExportFont ("digital-7.ttf")]
namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}