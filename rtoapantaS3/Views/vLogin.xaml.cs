namespace rtoapantaS3.Views;

public partial class vLogin : ContentPage
{
	string usuario, contrasenia;

    public vLogin()
    {
        InitializeComponent();
    }

    public vLogin(string usuario, string contrasenia)
	{
		InitializeComponent();
		this.usuario = usuario;
		this.contrasenia = contrasenia;
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }

    private void btnIniciarSesión_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngreso = txtUsuario.Text;
            string password = txtContrasenia.Text;

            if (usuarioIngreso == this.usuario && password == this.contrasenia)
            {
                Navigation.PushAsync(new vReporte(usuarioIngreso));
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");

        }
    }
}