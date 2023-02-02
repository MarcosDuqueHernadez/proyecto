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
        public IList<servidores> servidores { get; private set; }
        public IList<BasesDatos> basesDatos { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            servidores = new List<servidores>();
            servidores.Add(new servidores { id = "1", nombre = "Servidor001-01" });
            servidores.Add(new servidores { id = "2", nombre = "Servidor002-02" });
            servidores.Add(new servidores { id = "3", nombre = "Servidor003-03" });
            servidores.Add(new servidores { id = "4", nombre = "Servidor004-04" });
            basesDatos = new List<BasesDatos>();
            basesDatos.Add(new BasesDatos { id = "1", nombre = "Base001-01" });
            basesDatos.Add(new BasesDatos { id = "2", nombre = "Base002-02" });
            basesDatos.Add(new BasesDatos { id = "3", nombre = "base003-03" });

            BindingContext = this;
        }


        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            servidores selectedItem = e.SelectedItem as servidores;
        }

        private void ListView_ItemSelected_base(object sender, SelectedItemChangedEventArgs e)
        {
            BasesDatos selectedItem = e.SelectedItem as BasesDatos;
        }



        private void Button_clicked(object sender, EventArgs e)
        {

        }
    }
}
