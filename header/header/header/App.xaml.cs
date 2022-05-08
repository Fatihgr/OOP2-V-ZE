using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace header
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new header();
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
