using static menuNavegacion.Page1;

namespace menuNavegacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var stackLayout = new StackLayout();

            var button1 = new Button
            {
                Text = "EJERCICIO 1 - Articulo Vendido",
                FontSize = 20

            };

            button1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };

            var button2 = new Button
            {
                Text = "EJERCICIO 2 - Base y Altura del Triangulo",
                FontSize = 20
            };

            button2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page2());
            };

            var button3 = new Button
            {
                Text = "EJERCICIO 3 - Peso Expresado en Libras",
                FontSize = 20
            };

            button3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page3());
            };

            var button4 = new Button
            {
                Text = "EJERCICIO 4 - La Gasolinera",
                FontSize = 20
            };

            button4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page4());
            };

            stackLayout.Children.Add(button1);
            stackLayout.Children.Add(button2);
            stackLayout.Children.Add(button3);
            stackLayout.Children.Add(button4);

            Content = stackLayout;
        }
    }

    public class Page1 : ContentPage
    {
        public Page1()
        {
            {
                // Crear elementos de la interfaz de usuario
                var costEntry = new Entry { Placeholder = "Ingrese el costo del artículo", Keyboard = Keyboard.Numeric };
                var amountGivenEntry = new Entry { Placeholder = "Ingrese la cantidad de dinero entregada", Keyboard = Keyboard.Numeric };
                var calculateButton = new Button { Text = "Calcular Cambio" };
                var resultLabel = new Label { FontSize = 18, HorizontalOptions = LayoutOptions.Center };

                // Configurar el evento del botón
                calculateButton.Clicked += (sender, e) =>
                {
                    // Intentar convertir los textos a valores numéricos
                    if (double.TryParse(costEntry.Text, out double cost) && double.TryParse(amountGivenEntry.Text, out double amountGiven))
                    {
                        // Calcular el cambio
                        if (amountGiven >= cost)
                        {
                            double change = amountGiven - cost;
                            resultLabel.Text = $"El cambio a entregar es: {change:C2}"; // Usa formato de moneda
                        }
                        else
                        {
                            resultLabel.Text = "La cantidad de dinero entregada es menor que el costo.";
                        }
                    }
                    else
                    {
                        resultLabel.Text = "Por favor, ingrese valores numéricos válidos.";
                    }
                };

                Content = new Label
                {
                    Text = "PRACTICA 11 - NET. MAUI",
                    FontSize = 13
                };
                // Crear el diseño de la página
                Content = new StackLayout
                {
                    Padding = 20,
                    Children =
                {
                    new Label
                    {
                        Text = "Calculadora de Cambio",
                        FontSize = 24,
                        HorizontalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 20, 0, 20)
                    },
                    costEntry,
                    amountGivenEntry,
                    calculateButton,
                    resultLabel
                    }
                };
            }
        }

        public class Page2 : ContentPage
        {
            public Page2()
            {
                // Crear elementos de la interfaz de usuario
                var baseEntry = new Entry { Placeholder = "Ingrese la base del triángulo", Keyboard = Keyboard.Numeric };
                var heightEntry = new Entry { Placeholder = "Ingrese la altura del triángulo", Keyboard = Keyboard.Numeric };
                var calculateButton = new Button { Text = "Calcular Superficie" };
                var resultLabel = new Label { FontSize = 18, HorizontalOptions = LayoutOptions.Center };

                // Configurar el evento del botón
                calculateButton.Clicked += (sender, e) =>
                {
                    if (double.TryParse(baseEntry.Text, out double baseValue) && double.TryParse(heightEntry.Text, out double heightValue))
                    {
                        double area = (baseValue * heightValue) / 2;
                        resultLabel.Text = $"La superficie del triángulo es: {area}";
                    }
                    else
                    {
                        resultLabel.Text = "Por favor, ingrese valores numéricos válidos.";
                    }
                };

                Content = new Label
                {
                    Text = "PRACTICA 11 - NET. MAUI",
                    FontSize = 13
                };
                // Crear el diseño de la página
                Content = new StackLayout
                {
                    Padding = 20,
                    Children =
                {

                    new Label
                    {
                        Text = "Calculadora de Superficie de un Triángulo",
                        FontSize = 24,
                        HorizontalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 20, 0, 20)
                    },
                    baseEntry,
                    heightEntry,
                    calculateButton,
                    resultLabel
                    }
                };
            }
           
     
        }

        public class Page3 : ContentPage
        {

            public Page3()
            {
                var nameEntry = new Entry { Placeholder = "Ingrese el nombre del dinosaurio" };
                var weightEntry = new Entry { Placeholder = "Ingrese el peso en kilogramos", Keyboard = Keyboard.Numeric };
                var heightEntry = new Entry { Placeholder = "Ingrese la altura en metros", Keyboard = Keyboard.Numeric };
                var calculateButton = new Button { Text = "Calcular Conversión" };
                var resultLabel = new Label { FontSize = 18, HorizontalOptions = LayoutOptions.Center };

                // Configurar el evento del botón
                calculateButton.Clicked += (sender, e) =>
                {
                    string name = nameEntry.Text;

                    if (double.TryParse(weightEntry.Text, out double weightKg) && double.TryParse(heightEntry.Text, out double heightM))
                    {
                        double weightLbs = weightKg * 2.20462; // 1 kg = 2.20462 lbs
                        double heightCm = heightM * 100; // 1 m = 100 cm

                        resultLabel.Text = $"Dinosaurio: {name}\n" +
                                           $"Peso: {weightKg} kg ({weightLbs:F2} lbs)\n" +
                                           $"Altura: {heightM} m ({heightCm:F2} cm)";
                    }
                    else
                    {
                        resultLabel.Text = "Por favor, ingrese valores numéricos válidos para peso y altura.";
                    }
                };

                Content = new Label
                {
                    Text = "PRACTICA 11 - NET. MAUI",
                    FontSize = 13
                };
                // Crear el diseño de la página
                Content = new StackLayout
                {
                    Padding = 20,
                    Children =
                {
                    new Label
                    {
                        Text = "Información del Dinosaurio",
                        FontSize = 24,
                        HorizontalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 20, 0, 20)
                    },
                    nameEntry,
                    weightEntry,
                    heightEntry,
                    calculateButton,
                    resultLabel
                    }
                };
            }
        }

        public class Page4 : ContentPage
        {
            public Page4()
            {
                // Crear elementos de la interfaz de usuario
                var gallonsEntry = new Entry { Placeholder = "Ingrese la cantidad en galones", Keyboard = Keyboard.Numeric };
                var pricePerLiterEntry = new Entry { Placeholder = "Ingrese el precio por litro", Keyboard = Keyboard.Numeric };
                var calculateButton = new Button { Text = "Calcular Costo" };
                var resultLabel = new Label { FontSize = 18, HorizontalOptions = LayoutOptions.Center };

                // Configurar el evento del botón
                calculateButton.Clicked += (sender, e) =>
                {
                    if (double.TryParse(gallonsEntry.Text, out double gallons) && double.TryParse(pricePerLiterEntry.Text, out double pricePerLiter))
                    {
                        double liters = gallons * 3.78541; // 1 galón = 3.78541 litros
                        double totalCost = liters * pricePerLiter;

                        resultLabel.Text = $"Cantidad en litros: {liters:F2} L\nCosto total: {totalCost:C2}";
                    }
                    else
                    {
                        resultLabel.Text = "Por favor, ingrese valores numéricos válidos.";
                    }
                };


                // Crear el diseño de la página
                Content = new StackLayout
                {
                    Padding = 20,
                    Children =
                {
                    new Label
                    {
                        Text = "Calculadora de Costos de Gasolina",
                        FontSize = 24,
                        HorizontalOptions = LayoutOptions.Center,
                        Margin = new Thickness(0, 20, 0, 20)
                    },
                    gallonsEntry,
                    pricePerLiterEntry,
                    calculateButton,
                    resultLabel
                }
                };
            }
        }
    }
}
