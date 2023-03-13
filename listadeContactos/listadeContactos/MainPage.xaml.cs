using listadeContactos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace listadeContactos
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Contacto> ListadoContactos { get; set; }
        public MainPage()
        {
            InitializeComponent();

            ListadoContactos = App.ListaContactosPrincipal;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }
    }
}
