namespace rtoapantaS3.Views;

public partial class vReporte : ContentPage
{
	public vReporte(string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Bienvenido", usuario, "Cerrar");
    }
}