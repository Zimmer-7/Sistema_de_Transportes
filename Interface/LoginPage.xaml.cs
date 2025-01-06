using Microsoft.Maui.Controls;

namespace Interface;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        
        string username = entryUsername.Text;
        string password = entryPassword.Text;

        if (username == "admin" && password == "1234") 
        {
           
            //await Navigation.PushAsync(new CadastroCidadesPage());
        }
        else
        {
            lblErrorMessage.Text = "Usuário ou senha inválidos.";
            lblErrorMessage.IsVisible = true;
        }
    }
}