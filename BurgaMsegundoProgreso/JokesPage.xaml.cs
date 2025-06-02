namespace BurgaMsegundoProgreso;

public partial class JokesPage : ContentPage
{
	private readonly JokesService _jokesService;
    public JokesPage()
	{
		InitializeComponent();
		var httpClient = new HttpClient();
        _jokesService = new JokesService(httpClient);
		loadJoke();
    }

	private async Task<> loadJoke()
    {
        try
        {
            var joke = await _jokesService.GetRandomJokeAsync();
            if (joke != null)
            {
                jokeLabel.Text = $"{joke.setup}\n\n{joke.punchline}";
                se
            }
            else
            {
                jokeLabel.Text = "No joke available at the moment.";
            }
        }
        catch (Exception ex)
        {
            jokeLabel.Text = "Error loading joke: " + ex.Message;
        }
    }


}