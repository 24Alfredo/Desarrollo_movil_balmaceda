using MiAppCrud.Controllers;
using Microsoft.Maui.Controls;

namespace MiAppCrud.Views
{
    public partial class RegisterPage : ContentPage
    {
        private readonly LoginController _loginController;

        public RegisterPage(LoginController loginController)
        {
            InitializeComponent();
            _loginController = loginController;
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            var nombreUsuario = NombreUsuarioEntry.Text;
            var email = EmailEntry.Text; // Debe coincidir con el nombre en el XAML
            var contrasena = ContrasenaEntry.Text;

            // Validación de campos
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contrasena))
            {
                MensajeLabel.Text = "Todos los campos son obligatorios.";
                MensajeLabel.IsVisible = true;
                return;
            }

            // Llamar al método RegistrarUsuarioAsync
            if (await _loginController.RegistrarUsuarioAsync(nombreUsuario, email, contrasena))
            {
                await DisplayAlert("Éxito", "¡Registro exitoso!", "OK");
                await Navigation.PushAsync(new LoginPage(_loginController));
            }
            else
            {
                MensajeLabel.Text = "El nombre de usuario ya existe.";
                MensajeLabel.IsVisible = true;
            }
        }
    }
}
