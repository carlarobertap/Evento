namespace Evento.Models
{
    public class Festa
    {
        public Local LocalSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public int Dias
        {
            get => DataFim.Subtract(DataInicio).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * LocalSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * LocalSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Dias;

                return total;
            }
        }
    }
}
