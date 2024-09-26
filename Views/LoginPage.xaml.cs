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
            string email = EmailEntry.Text; // Aseg�rate de que tienes un campo de texto llamado EmailEntry
            string password = PasswordEntry.Text; // Aseg�rate de que tienes un campo de texto llamado PasswordEntry

            // Llama al m�todo AutenticarUsuarioAsync en el LoginController
            var isAuthenticated = await _loginController.AutenticarUsuarioAsync(email, password);

            if (isAuthenticated)
            {
                // L�gica de inicio de sesi�n exitosa
                await DisplayAlert("�xito", "Inicio de sesi�n correcto", "OK");
                // Aqu� puedes navegar a otra p�gina o realizar otra acci�n
            }
            else
            {
                // Mostrar mensaje de error
                await DisplayAlert("Error", "Email o contrase�a incorrectos", "OK");
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Navega a la p�gina de registro
            await Navigation.PushAsync(new RegisterPage(_loginController));
        }
    }
}
