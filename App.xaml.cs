using MiAppCrud.Views;

namespace MiAppCrud
{
    public partial class App : Application
    {
        // Cambia esta variable para elegir la vista inicial
        private readonly bool _mostrarCategorias = true; // Cambia a false para mostrar productos

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(_mostrarCategorias ? new Views.CategoriaListPage() : new Views.ProductoListPage());
        }
    }
}
