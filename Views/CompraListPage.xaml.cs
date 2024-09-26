using MiAppCrud.Controllers;
using MiAppCrud.Models;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace MiAppCrud.Views
{
    public partial class CompraListPage : ContentPage
    {
        private readonly CompraController _controller;

        public CompraListPage()
        {
            InitializeComponent();
            _controller = new CompraController();
            LoadCompras();
        }

        private async void LoadCompras()
        {
            ComprasListView.ItemsSource = await _controller.GetAllCompras();
        }

        private async void OnCompraTapped(object sender, ItemTappedEventArgs e)
        {
            var compra = (Compra)e.Item;
            await Navigation.PushAsync(new CompraEditPage(compra));
        }

        private async void OnAddCompraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CompraEditPage());
        }
    }
}
