using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Evento.Views;

public partial class ContratacaoEvento : ContentPage
{
	public ContratacaoEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        try
        {
            Navigation.PushAsync(new EventoContratado()); //botão avançar

        }catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}