namespace Modelos.Cliente

public class Cliente
{
    public Cliente() {}
    public Cliente(string nome, string email, string telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }

    public int ?IdCliente { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public override bool Equals(object obj)
    {   
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        var other = (Cliente)obj;

        return base.Equals(IdCliente.HasValue && other.IdCliente.HasValue 
                            && IdCliente == other.IdCliente);
    }

    public override int GetHashCode()
    {
        return IdCliente.HasValue ? IdCliente.GetHashCode() : 0;
    }

    public override string ToString()
    {
        return $"[{IdCliente}, {Nome}, {Email}, {Telefone}]"; 
    }
}