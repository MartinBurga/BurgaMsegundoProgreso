namespace BurgaMsegundoProgreso
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Jokes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JokesPage());
        }


        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
    }
}

