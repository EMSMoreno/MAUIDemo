namespace MauiDemo;

public partial class MinhaPagina : ContentPage
{
	public MinhaPagina()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MinhaPagina());
    }
}