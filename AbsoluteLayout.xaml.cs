namespace UsoDeLayoutsDiaz;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    private async void GridLayoutButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayout());
    }
}