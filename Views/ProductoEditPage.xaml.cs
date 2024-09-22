using MiAppCrud.Controllers;
using MiAppCrud.Models;

namespace MiAppCrud.Views
{
    public partial class ProductoEditPage : ContentPage
    {
        private Producto _producto;

        public ProductoEditPage(Producto producto = null)
        {
            InitializeComponent();
            _producto = producto ?? new Producto();
            if (_producto.Id != 0)
            {
                NombreEntry.Text = _producto.Nombre;
                PrecioEntry.Text = _producto.Precio.ToString();
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _producto.Nombre = NombreEntry.Text;
            _producto.Precio = decimal.Parse(PrecioEntry.Text);

            var controller = new ProductoController();
            if (_producto.Id == 0)
                controller.AddProducto(_producto);
            else
                controller.UpdateProducto(_producto);

            await Navigation.PopAsync();
        }
    }
}