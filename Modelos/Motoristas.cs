namespace Modelos.Motorista
{
    public class Motorista
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string CNH { get; set; } = string.Empty;
        public DateTime ValidadeCNH { get; set; }
        public StatusMotorista Status { get; set; }
    }

    public enum StatusMotorista
    {
        Disponivel,
        EmViagem,
        LicencaSuspensa
    }
}