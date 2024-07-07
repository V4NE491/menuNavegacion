namespace menuNavegacion.Pages;

public partial class CalcularSuperficie : ContentPage
{
	public CalcularSuperficie()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(entryAltura.Text)&& !string.IsNullOrEmpty(entryBase.Text))
		{
			double altura, baseT, superficie;
			altura = Convert.ToDouble(entryAltura.Text);
			baseT = Convert.ToDouble(entryBase.Text);
			superficie = (baseT * altura) / 2;
			labelResultado.Text = superficie.ToString();
		}
    }
}