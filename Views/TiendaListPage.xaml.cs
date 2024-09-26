using MiAppCrud.Controllers;
using MiAppCrud.Models;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace MiAppCrud.Views
{
    public partial class TiendaListPage : ContentPage
    {
        private readonly TiendaController _controller;

        public TiendaListPage()
        {
            InitializeComponent();
            _controller = new TiendaController();
            LoadTiendas();
        }

        private async void LoadTiendas()
        {
            TiendasListView.ItemsSource = await _controller.GetAllTiendas();
        }

        private async void OnTiendaTapped(object sender, ItemTappedEventArgs e)
        {
            var tienda = (Tienda)e.Item;
            await Navigation.PushAsync(new TiendaEditPage(tienda));
        }

        private async void OnAddTiendaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TiendaEditPage());
        }
    }
}
