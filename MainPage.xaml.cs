using TheSimpsons.Services;

namespace TheSimpsons
{
    public partial class MainPage : ContentPage
    {
        private readonly IPersonajes personajes;

        public MainPage(IPersonajes personajes)
        {
            InitializeComponent();
            this.personajes = personajes;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CargarMenu();
        }

        private async void CargarMenu()
        {
            var resultado = await personajes.GetPersonajesAsync();

            foreach (var personaje in resultado)
            {
                ImageButton imageButton = new ImageButton
                {
                    Source = $"https://cdn.thesimpsonsapi.com/200{personaje.PortraitPath}",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HeightRequest = 50,
                    WidthRequest = 50,
                };
                stcMenu.Children.Add(imageButton);
            }
        }
    }
}