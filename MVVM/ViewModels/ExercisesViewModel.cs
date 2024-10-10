
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthCare.DbContext;
using HealthCare.MVVM.Views;
using HealthCare.Services;
using System.Collections.ObjectModel;

namespace HealthCare.MVVM.ViewModels
{
    public partial class ExercisesViewModel : ObservableObject
    {
        public ObservableCollection<Exercise> Exercises { get; set; } = new ObservableCollection<Exercise>();

        private readonly IExerciseService _exerciseService;
        public ExercisesViewModel(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [RelayCommand]
        public async Task GetExercisesList()
        {
            var exercises = await _exerciseService.GetExercisesList();
            if (exercises?.Count > 0)
            {
                exercises.Clear();
                foreach(var exercise in exercises)
                {
                    Exercises.Add(exercise);
                }
            }
        }

        [RelayCommand]
        public async Task AddUpdateExercise()
        {
            await AppShell.Current.GoToAsync(nameof(AddExercisePage));
        }

        [RelayCommand]
        public async Task ScreenAction(Exercise exercise)
        {
            var response = await Shell.Current.DisplayActionSheet("Select Option", "Ok", null, "Edit", "Delete");

            if (response == "Edit")
            {
                var param = new Dictionary<string, object>(); //{{"Exercise", exercise}};
                param.Add("AddExercisePage", exercise);

                await AppShell.Current.GoToAsync(nameof(AddExercisePage), param);
            }
            if (response == "Delete")
            {
                var deleteResponse = await _exerciseService.DeleteExercise(exercise);

                if (deleteResponse > 0)
                {
                    await GetExercisesList();
                }
            }
        }
    }
}
