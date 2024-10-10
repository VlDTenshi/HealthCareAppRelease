using HealthCare.MVVM.Views;

namespace HealthCare
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(HomeNavigationPage), typeof(HomeNavigationPage));

            Routing.RegisterRoute(nameof(ExercisesPage), typeof(ExercisesPage));
            Routing.RegisterRoute(nameof(ExerciseTypePage), typeof(ExerciseTypePage));
            Routing.RegisterRoute(nameof(ExerciseLocationTypePage), typeof(ExerciseLocationTypePage));
            Routing.RegisterRoute(nameof(ExercisesPage), typeof(ExercisesPage));
            Routing.RegisterRoute(nameof(AddExercisePage), typeof(AddExercisePage));
            Routing.RegisterRoute(nameof(AddNewExerciseTypePage), typeof(AddNewExerciseTypePage));
            Routing.RegisterRoute(nameof(AddNewExerciseLocationTypePage), typeof(AddNewExerciseLocationTypePage));

            Routing.RegisterRoute(nameof(HospitalsPage), typeof(HospitalsPage));

            Routing.RegisterRoute(nameof(MedicinesPage), typeof(MedicinesPage));

            Routing.RegisterRoute(nameof(ContactsPage), typeof(ContactsPage));
        }
        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Launcher.OpenAsync("https://www.youtube.com/@vladimirvld2020");
        }

        private void SignOutMenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
