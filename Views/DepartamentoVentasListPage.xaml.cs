using MiAppCrud.Controllers;
using MiAppCrud.Models;
using System;

namespace MiAppCrud.Views
{
    public partial class DepartamentoVentasListPage : ContentPage
    {
        private readonly DepartamentoVentasController _controller;

        public DepartamentoVentasListPage()
        {
            InitializeComponent();
            _controller = new DepartamentoVentasController();
            LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            DepartamentosListView.ItemsSource = await _controller.GetAllDepartamentosVentas();
        }

        private async void OnDepartamentoTapped(object sender, ItemTappedEventArgs e)
        {
            var departamento = (DepartamentoVentas)e.Item;
            await Navigation.PushAsync(new DepartamentoVentasEditPage(departamento));
        }

        private async void OnAddDepartamentoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DepartamentoVentasEditPage());
        }
    }
}
