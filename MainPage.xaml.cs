using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace confe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Btniniciar_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string ocupacion = Ocupacion.Text;
            string cumple = Cumple.Text;
            string email = Email.Text;
            string telefono = Telefono.Text;
            string nacionalidad = Nacionalidad.Text;
            string nivel = Nivel.Text;
            string perfil = Perfil.Text;
            Navigation.PushAsync(new Curriculum(nombre, ocupacion, cumple, email, telefono, 
                                                nacionalidad, nivel, perfil));
        }
    }
}
