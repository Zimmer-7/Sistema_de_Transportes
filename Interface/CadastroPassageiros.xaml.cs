namespace Interface;

using Modelos;

public partial class CadastroPassageiro : ContentPage
{
    public CadastroPassageiro()
    {
        InitializeComponent();
    }

    private void OnCadastrarPassageiroBtnClicked(object sender, EventArgs e)
    {
        try
        {
            Passageiro passageiro = new Passageiro(
                NomeEntry.Text, 
                CpfEntry.Text, 
                TelefoneEntry.Text
            );

            resultado.Text = passageiro.ToString();

            DisplayAlert("Cadastro concluído!", $"Passageiro {passageiro.Nome} cadastrado com sucesso!", "OK");
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "Fechar");
        }
    }
}
