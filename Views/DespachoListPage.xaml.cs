using MiAppCrud.Controllers;
using MiAppCrud.Models;

namespace MiAppCrud.Views
{
    public partial class DespachoListPage : ContentPage
    {
        private readonly DespachoController _controller;

        public DespachoListPage()
        {
            InitializeComponent();
            _controller = new DespachoController();
            LoadDespachos();
        }

        private async void LoadDespachos()
        {
            DespachoListView.ItemsSource = await _controller.GetAllDespachos();
        }

        private async void OnDespachoTapped(object sender, ItemTappedEventArgs e)
        {
            var despacho = (Despacho)e.Item;
            await Navigation.PushAsync(new DespachoEditPage(despacho));
        }

        private async void OnAddDespachoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DespachoEditPage());
        }
    }
}
