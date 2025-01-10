using System;

namespace Modelos;

public class Viagem
{
    public Viagem(DateTime partida, decimal valor)
    {
        Partida = partida;
        Valor = valor;
    }

    public int ?IdViagem { get; set; }
    //public Motorista Motorista { get; set; }
    //public Veiculo Veiculo { get; set; }
    public DateTime Partida { get; set; }
    public DateTime ?Chegada { get; set; }
    //public StatusViagem Status
    public decimal Valor { get; set; }
    ICollection<Cliente>? Clientes { get; set; }

    public override bool Equals(object obj)
    {   
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }
        
        var other = (Viagem)obj;

        return base.Equals(IdViagem.HasValue && other.IdViagem.HasValue 
                            && IdViagem == other.IdViagem);
    }

    public override int GetHashCode()
    {
        return IdViagem.HasValue ? IdViagem.GetHashCode() : 0;
    }

    public override string ToString()
    {
        return $"[{IdViagem}, {Partida}, {Chegada}, {Valor}]";
    }
}
