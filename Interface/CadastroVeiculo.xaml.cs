namespace Interface;

using Modelos;
public partial class CadastroVeiculo : ContentPage
{
	public CadastroVeiculo()
	{
		InitializeComponent();
	}

	private void OnCadastrarVeiculoBtnClicked(object sender, EventArgs e)
    {
        Veiculo veiculo = new Veiculo(PlacaEntry.Text, ModeloEntry.Text);

        resultado.Text = veiculo.ToString();
        try{

            DisplayAlert("Cadastro concluído!",$"Veiculo cadastrado com sucesso! seja bem-vindo!" , "OK");
        }catch (Exception ex)
        {
            DisplayAlert ("Erro",ex.Message, "Fechar");
        }

    }
}