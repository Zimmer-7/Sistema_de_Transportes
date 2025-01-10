namespace Modelos.Veiculo
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }
        public int Capacidade { get; set; }
        public StatusVeiculo Status { get; set; }
    }

    public enum StatusVeiculo
    {
        Disponivel,
        EmViagem,
        EmManutencao
    }
}