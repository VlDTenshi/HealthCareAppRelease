using HealthCare.DbContext;
using HealthCare.MVVM.Views;

namespace HealthCare
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Database = new ApplicationDbContext();

            MainPage = new AppShell();
        }
        protected override async void OnStart()
        {
            base.OnStart();

            MainPage = new NavigationPage(new LoadingPage());

            await Task.Delay(5000);

            MainPage = new AppShell();
        }
        public static ApplicationDbContext Database { get; private set; }
    }
}
