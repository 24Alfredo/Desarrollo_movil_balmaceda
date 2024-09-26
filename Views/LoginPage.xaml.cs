using MiAppCrud.Controllers;
using Microsoft.Maui.Controls;

namespace MiAppCrud.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly LoginController _loginController;

        public LoginPage()
        {
        }

        public LoginPage(LoginController loginController)
        {
            InitializeComponent();
            _loginController = loginController;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text; // Asegúrate de que tienes un campo de texto llamado EmailEntry
            string password = PasswordEntry.Text; // Asegúrate de que tienes un campo de texto llamado PasswordEntry

            // Llama al método AutenticarUsuarioAsync en el LoginController
            var isAuthenticated = await _loginController.AutenticarUsuarioAsync(email, password);

            if (isAuthenticated)
            {
                // Lógica de inicio de sesión exitosa
                await DisplayAlert("Éxito", "Inicio de sesión correcto", "OK");
                // Aquí puedes navegar a otra página o realizar otra acción
            }
            else
            {
                // Mostrar mensaje de error
                await DisplayAlert("Error", "Email o contraseña incorrectos", "OK");
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Navega a la página de registro
            await Navigation.PushAsync(new RegisterPage(_loginController));
        }
    }
}
