namespace TallerUsoLayouts;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

    private void Boton4_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}