namespace Interface;

using Modelos;

public partial class CadastroMotorista : ContentPage
{
	public CadastroMotorista()
	{
		InitializeComponent();
	}

	private void OnCadastrarMotoristaBtnClicked(object sender, EventArgs e)
    {
        Motorista motorista = new Motorista(NomeEntry.Text, CpfEntry.Text, CnhEntry.Text);

        resultado.Text = motorista.ToString();
        try{

            DisplayAlert("Cadastro concluído!",$"Motorista {motorista.Nome} cadastrado com sucesso! seja bem-vindo!" , "OK");
        }catch (Exception ex)
        {
            DisplayAlert ("Erro",ex.Message, "Fechar");
        }

    }
}