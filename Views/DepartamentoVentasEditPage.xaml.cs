using MiAppCrud.Controllers;
using MiAppCrud.Models;
using System;

namespace MiAppCrud.Views
{
    public partial class DepartamentoVentasEditPage : ContentPage
    {
        private DepartamentoVentas _departamento;

        public DepartamentoVentasEditPage(DepartamentoVentas departamento = null)
        {
            InitializeComponent();
            _departamento = departamento ?? new DepartamentoVentas();
            if (_departamento.Id != 0)
            {
                NombreEntry.Text = _departamento.Nombre;
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _departamento.Nombre = NombreEntry.Text;

            var controller = new DepartamentoVentasController();
            if (_departamento.Id == 0)
                controller.AddDepartamentoVentas(_departamento);
            else
                controller.UpdateDepartamentoVentas(_departamento);

            await Navigation.PopAsync();
        }
    }
}
