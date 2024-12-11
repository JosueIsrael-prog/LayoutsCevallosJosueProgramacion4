namespace UsoDeLayoutsDiaz;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    private async void FlexButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new FlexLayout());
    }
}// Modificado por Josue Cevallos 
