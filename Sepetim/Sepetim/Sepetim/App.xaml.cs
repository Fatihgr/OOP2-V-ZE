using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sepetim
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SepetimUI();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
