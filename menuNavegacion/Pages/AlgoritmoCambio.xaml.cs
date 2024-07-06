namespace menuNavegacion.Pages;

public partial class AlgoritmoCambio : ContentPage
{
	public AlgoritmoCambio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

		if(!string.IsNullOrEmpty(entryPrecio.Text)&& !string.IsNullOrEmpty(entryDinero.Text))
		{
			double precio, dinero, cambio;
			precio = Convert.ToDouble(entryPrecio.Text);
			dinero = Convert.ToDouble(entryDinero.Text);
			cambio = dinero - precio;
			labelCambio.Text = cambio.ToString();
		}

    }
}