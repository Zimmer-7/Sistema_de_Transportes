namespace Interface;

using Modelos;

public partial class CadastroCliente : ContentPage
{
	public CadastroCliente()
	{
		InitializeComponent();
	}

	private void OnCadastrarClienteBtnClicked(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente(NomeEntry.Text, EmailEntry.Text, TelefoneEntry.Text);

        // cliente.IdCliente = 1;  
        //cliente.Nome = NomeEntry.Text;
        //cliente.Email = EmailEntry.Text;
        //cliente.Telefone = TelefoneEntry.Text;

        resultado.Text = cliente.ToString();
        try{

            DisplayAlert("Cadastro concluído!",$"Cliente {cliente.Nome} cadastrado com sucesso! seja bem-vindo!" , "OK");
        }catch (Exception ex)
        {
            DisplayAlert ("Erro",ex.Message, "Fechar");
        }

    }
}