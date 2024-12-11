namespace UsoDeLayoutsDiaz;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private async void InfoButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Informacion de mi", "Mi nombre es [Daniel Diaz]", "Cerrar");
    }

    private async void StackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayout());
    }

    private void GitHubButton_Clicked(object sender, EventArgs e)
    {
        var githubUrl = "https://github.com/Ptrickill/UsoDeLayoutsDiaz.git";
        Launcher.Default.OpenAsync(githubUrl);
    }

    private void FavoriteSongButton_Clicked(object sender, EventArgs e)
    {
        var songUrl = "https://www.youtube.com/watch?v=iX-QaNzd-0Y&pp=ygUMc3RvbGVuIGRhbmNl";
        Launcher.Default.OpenAsync(songUrl);
    }
}// Modificado por Josue Cevallos 
