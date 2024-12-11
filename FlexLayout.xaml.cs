namespace UsoDeLayoutsDiaz;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private async void AbsoluteButton1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }

    private async void AbsoluteButton2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }

    private async void AbsoluteButton3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }

    private async void AbsoluteButton4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }
}// Modificado por Josue Cevallos 
