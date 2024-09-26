using MiAppCrud.Views;
using Microsoft.Maui.Controls;

namespace MiAppCrud
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Establece AppShell como la página principal
            MainPage = new AppShell();
        }
    }
}
