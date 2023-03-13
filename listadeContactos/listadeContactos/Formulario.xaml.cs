using listadeContactos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace listadeContactos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class Formulario : ContentPage
    {

        public Contacto contacto { get; set; }

      
        public Formulario()
        {
            InitializeComponent();
            contacto = new Contacto();
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.ListaContactosPrincipal.Add(contacto);
            Navigation.PopAsync();
        }
    }
}