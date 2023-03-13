using listadeContactos.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace listadeContactos
{
    public partial class App : Application

    {
        public static ObservableCollection<Contacto> ListaContactosPrincipal { get; set; }
        public App()
        {
            InitializeComponent();
            ListaContactosPrincipal= new ObservableCollection<Contacto>();
            MainPage = new NavigationPage(new MainPage());
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
