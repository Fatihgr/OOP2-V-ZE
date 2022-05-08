using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProfileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileUI : ContentPage
    {
        public ProfileUI()
        {
            InitializeComponent();
        }
    }
}