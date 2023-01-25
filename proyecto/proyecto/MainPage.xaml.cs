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
        //public IList<grid> dataGrids { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }
        public class Card
        {
            public string Id { get; set; }
            public string nombre { get; set; }
        }
    }
}
