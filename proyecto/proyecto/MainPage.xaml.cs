using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace proyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
         private async void NavigateTo(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Servidores());
        }



    }
}
