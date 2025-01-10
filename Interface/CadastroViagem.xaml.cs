namespace Interface;

using Modelos;

public partial class CadastroViagem : ContentPage
{
	public CadastroViagem()
	{
		InitializeComponent();
	}

	private void OnCadastrarViagemBtnClicked(object sender, EventArgs e)
    {
        //Viagem viagem = new Viagem(PartidaEntry, ValorEntry.Text);

        //resultado.Text = viagem.ToString();
        try{

            DisplayAlert("Cadastro concluído!",$"Viagem cadastrada com sucesso! seja bem-vindo!" , "OK");
        }catch (Exception ex)
        {
            DisplayAlert ("Erro",ex.Message, "Fechar");
        }

    }
}