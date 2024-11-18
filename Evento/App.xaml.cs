using Evento.Models;
using Microsoft.Maui.Controls;

namespace Evento
{
    public partial class App : Application
    {
        public List<Local> lista_local = new List<Local>
        {
            new Local()
            {
                Descricao = "Salão Girassol",
                ValorDiariaAdulto = 30,
                ValorDiariaCrianca = 15
            },
             new Local()
            {
                Descricao = "Salão Violeta",
                ValorDiariaAdulto = 45,
                ValorDiariaCrianca = 20
            },
              new Local()
            {
                Descricao = "Salão Lírio",
                ValorDiariaAdulto = 60,
                ValorDiariaCrianca = 20

            },
               new Local()
            {
                Descricao = "Salão Rosa",
                ValorDiariaAdulto = 75,
                ValorDiariaCrianca = 30
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
            
        }
    }
}