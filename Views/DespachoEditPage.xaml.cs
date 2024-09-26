using MiAppCrud.Controllers;
using MiAppCrud.Models;

namespace MiAppCrud.Views
{
    public partial class DespachoEditPage : ContentPage
    {
        private Despacho _despacho;

        public DespachoEditPage(Despacho despacho = null)
        {
            InitializeComponent();
            _despacho = despacho ?? new Despacho();
            if (_despacho.Id != 0)
            {
                PersonaContactoEntry.Text = _despacho.PersonaContacto;
                DireccionEntry.Text = _despacho.Direccion;
                CelularEntry.Text = _despacho.Celular;
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _despacho.PersonaContacto = PersonaContactoEntry.Text;
            _despacho.Direccion = DireccionEntry.Text;
            _despacho.Celular = CelularEntry.Text;

            var controller = new DespachoController();
            if (_despacho.Id == 0)
                await controller.AddDespacho(_despacho);
            else
                await controller.UpdateDespacho(_despacho);

            await Navigation.PopAsync();
        }
    }
}
