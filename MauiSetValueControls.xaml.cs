using Microsoft.Maui.Controls;
using System.Globalization;

namespace MauiDemo;

public partial class MauiSetValueControls : ContentPage
{
	public MauiSetValueControls()
	{
		InitializeComponent();
	}

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
		{
			await DisplayAlert("CheckBox", "Marcado", "Ok");
		}
		else
		{
			// CheckBox foi desselecionado
            await DisplayAlert("CheckBox", "Desmarcado", "Ok");
        }
    }

    private async void CheckBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "Ok");
        }
        else
        {
            // CheckBox foi desselecionado
            await DisplayAlert("CheckBox", "Desmarcado", "Ok");
        }
    }

    private async void CheckBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "Ok");
        }
        else
        {
            // CheckBox foi desselecionado
            await DisplayAlert("CheckBox", "Desmarcado", "Ok");
        }
    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = Math.Round(slider1.Value, 2);
        lblSlider.Text = valor.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        lblStepper.Text = string.Format($"Valor do Stepper {value}");
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            // Switch is on
            await DisplayAlert("Switch", "On", "Ok");
        }
        else
        {
            // Switch is off
            await DisplayAlert("Switch", "Off", "Ok");
        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        var data = ((DatePicker)sender).Date;
        var dataselecionada = data.ToString(culture);
        await DisplayAlert("Data Selecionada", dataselecionada, "Ok");
    }

    private async void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (time1 != null)
        {
            var horaSelecionada = time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Hora Selecionada", horaSelecionada, "Ok");
        }
    }
}