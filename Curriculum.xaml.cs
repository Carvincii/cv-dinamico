using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace confe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Curriculum : ContentPage
	{
		public Curriculum (string nombre, string ocupacion, string cumple, string email, 
						string telefono, string nacionalidad, string nivel, string perfil)
		{
			InitializeComponent ();
            F_nombre.Text = nombre;
            F_ocupacion.Text = ocupacion;
            F_edad.Text = "|| " + cumple + " || " + nombre;
			F_email.Text = "E-mail: " + email;
			F_telefono.Text = "Telefono: " + telefono;
			F_pais.Text = "Nacionalidad: " + nacionalidad;
			F_level.Text = "Ingles: " + nivel;
			F_perfil.Text = perfil;
        }

        private void btnregresar_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}
