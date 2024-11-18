using Evento.Models;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Evento.Views;

public partial class ContratacaoEvento : ContentPage
{
    App ProprieddesApp;
    public ContratacaoEvento()
    {
        InitializeComponent();

        ProprieddesApp = (App)Application.Current;

        pck_local.ItemsSource = ProprieddesApp.lista_local;

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_fim.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_fim.MaximumDate = dtpck_inicio.Date.AddMonths(6);


    }
    
              private async void Button_Clicked(object sender, EventArgs e)
    {

        try
        {
            Festa f = new Festa
            {
                LocalSelecionado = (Local)pck_local.SelectedItem,
                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                DataInicio = dtpck_inicio.Date,
                DataFim = dtpck_fim.Date,

            };

            await Navigation.PushAsync(new EventoContratado()
            {
                BindingContext = f
            });

        }catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtpck_fim.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_fim.MaximumDate = data_selecionada_inicio.AddMonths(6);
    }
}