using System;
using System.Net;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Servidores : ContentPage
	{
        public Servidores()
        {
            InitializeComponent();
            GetListado();

        }       

        private async void GoToDataBase(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BaseDatos());
        }
        private async void LogOut(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        public class DemoAPI
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        private async void GetListado()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://jsonplaceholder.typicode.com/users");
            request.Method=HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage respose = await client.SendAsync(request);
            if (respose.StatusCode==HttpStatusCode.OK)
            {
                string content = await respose.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<DemoAPI>>(content);

                ListDemo.ItemsSource = result;

            }

        }

        private void DomainUpDown1_SelectedItemChanged(Object sender, EventArgs e)
        {
            MessageBox.Show("You are in the DomainUpDown.SelectedItemChanged event.");
        }


    }
}