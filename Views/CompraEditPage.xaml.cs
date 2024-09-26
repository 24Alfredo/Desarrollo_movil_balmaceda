using MiAppCrud.Controllers;
using MiAppCrud.Models;
using Microsoft.Maui.Controls;
using System;

namespace MiAppCrud.Views
{
    public partial class CompraEditPage : ContentPage
    {
        private Compra _compra;
        private readonly CompraController _controller;

        public CompraEditPage(Compra compra = null)
        {
            InitializeComponent();
            _controller = new CompraController();
            _compra = compra ?? new Compra();

            if (_compra.Id != 0)
            {
                TipoEntregaEntry.Text = _compra.TipoEntrega;
                PrecioTotalEntry.Text = _compra.PrecioTotal.ToString();
                FechaCompraPicker.Date = _compra.FechaCompra;
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _compra.TipoEntrega = TipoEntregaEntry.Text;
            _compra.PrecioTotal = decimal.Parse(PrecioTotalEntry.Text);
            _compra.FechaCompra = FechaCompraPicker.Date;

            if (_compra.Id == 0)
                await _controller.AddCompra(_compra);
            else
                await _controller.UpdateCompra(_compra);

            await Navigation.PopAsync();
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            if (_compra.Id != 0)
                await _controller.DeleteCompra(_compra.Id);

            await Navigation.PopAsync();
        }
    }
}
