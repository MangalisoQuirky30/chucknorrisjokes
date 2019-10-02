using System.Windows;

namespace ChuckNorrisJokesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            string randomJoke = await jokeGenerator.GetRandomJoke();


        }
    }
}
