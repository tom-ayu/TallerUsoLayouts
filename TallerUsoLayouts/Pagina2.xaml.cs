namespace TallerUsoLayouts;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}

    private void Boton3_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Pagina3());
    }
}