using MiAppCrud.Controllers;
using MiAppCrud.Models;
using Microsoft.Maui.Controls;
using System;

namespace MiAppCrud.Views
{
    public partial class TiendaEditPage : ContentPage
    {
        private Tienda _tienda;
        private readonly TiendaController _controller;

        public TiendaEditPage(Tienda tienda = null)
        {
            InitializeComponent();
            _controller = new TiendaController();
            _tienda = tienda ?? new Tienda();

            if (_tienda.Id != 0)
            {
                NombreTiendaEntry.Text = _tienda.NombreTienda;
                UbicacionEntry.Text = _tienda.Ubicacion;
                Direccion1Entry.Text = _tienda.Direccion1;
                Direccion2Entry.Text = _tienda.Direccion2;
                TituloEntry.Text = _tienda.Titulo;
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _tienda.NombreTienda = NombreTiendaEntry.Text;
            _tienda.Ubicacion = UbicacionEntry.Text;
            _tienda.Direccion1 = Direccion1Entry.Text;
            _tienda.Direccion2 = Direccion2Entry.Text;
            _tienda.Titulo = TituloEntry.Text;

            if (_tienda.Id == 0)
                await _controller.AddTienda(_tienda);
            else
                await _controller.UpdateTienda(_tienda);

            await Navigation.PopAsync();
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            if (_tienda.Id != 0)
                await _controller.DeleteTienda(_tienda.Id);

            await Navigation.PopAsync();
        }
    }
}
