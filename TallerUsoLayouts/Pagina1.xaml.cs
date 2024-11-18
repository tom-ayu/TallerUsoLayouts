namespace TallerUsoLayouts;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}

    private void Boton2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Pagina2());
    }
}