using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BaseDatos : ContentPage
	{
		public BaseDatos ()
		{
			InitializeComponent ();
		}

        private async void LogOut(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}