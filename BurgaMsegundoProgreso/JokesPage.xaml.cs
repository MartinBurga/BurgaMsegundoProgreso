namespace BurgaMsegundoProgreso;

public partial class JokesPage : ContentPage
{
	private readonly JokesService _jokesService;
    public JokesPage()
	{
		InitializeComponent();
		var httpClient = new HttpClient();
        _jokesService = new JokesService(httpClient);
		LoadJoke();
    }

    private async Task LoadJoke()
    {
        try
        {
            var joke = await _jokesService.GetRandomJokeAsync();
            if (joke != null)
            {
                SetupLabel.Text = joke.setup;
                PunchlineLabel.Text = joke.punchline;
            }
            else
            {
                SetupLabel.Text = "No hay bromas disponibles.";

            }
        }
        catch (Exception ex)
        {
            SetupLabel.Text = "Error loading joke: " + ex.Message;
        }
    }

    public void ChisteButton_Clicked(object sender, EventArgs e)
    {
        LoadJoke();
    }

    private void Return_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}