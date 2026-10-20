namespace rtoapantaS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioNuevo = txtUsuario.Text;
			string contrasenia = txtContrasenia.Text;
			Navigation.PushAsync(new vLogin(usuarioNuevo, contrasenia));
			DisplayAlertAsync("Alerta", "Usuario Guardado", "Cerrar");
        }
        catch(Exception ex)
		{

		}
    }
}