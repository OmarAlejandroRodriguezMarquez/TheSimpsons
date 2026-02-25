[QueryProperty(nameof(PersonajeId), "id")]
public partial class DetailPage : ContentPage
{
    public int PersonajeId { get; set; }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        CargarPersonaje(PersonajeId);
    }

    private async void CargarPersonaje(int PersonajeId)
    {

    }
}