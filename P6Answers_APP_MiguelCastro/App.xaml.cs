using P6Answers_APP_MiguelCastro.Views;
namespace P6Answers_APP_MiguelCastro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BienvenidaPage());
        }
    }
}
