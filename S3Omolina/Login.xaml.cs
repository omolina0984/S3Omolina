using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S3Omolina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtLogin_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string pass = "uisrael2022";

            if (usuario== txtUsuario.Text && pass== txtPass.Text)
            {
                Navigation.PushAsync(new Registro(txtUsuario.Text));
          //      Navigation.PushModalAsync(new Registro());
                txtUsuario.Text = "";
                txtPass.Text = "";
            }
            else
            {
                DisplayAlert("Acceso incorrecto", "Las credenciales son invalidas", "Salir");
            }
            }
    }
}