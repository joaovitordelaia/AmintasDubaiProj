namespace AmintasDubaiProj;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void GenerateLuckNumber()
    {
        ContainerLuckNumbers.IsVisible = true;
        NameAppTile.IsVisible = true;



    }

    private void ButtonLuckGeneretor_Clicked(object sender, EventArgs e)
    {
        GenerateLuckNumber();
    }

}