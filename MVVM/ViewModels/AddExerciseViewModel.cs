using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthCare.DbContext;
using HealthCare.MVVM.Views;
using HealthCare.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.MVVM.ViewModels
{
    [QueryProperty(nameof(AddExercisePage),"AddExercisePage")]
    public partial class AddExerciseViewModel : ObservableObject
    {
        [ObservableProperty]
        private Exercise exerciseDetails = new Exercise();

        private readonly IExerciseService _exerciseService;

        public AddExerciseViewModel(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;

            
        }

        

        [RelayCommand]
        public async Task AddExercise()
        {
            var response = await _exerciseService.AddExercise(ExerciseDetails);

            if(response > 0)
            {
                await Shell.Current.DisplayAlert("It's added", "Exercise Details Successfully submitted", "Ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not added", "Something went wrong", "Ok");
            }
        }

        
    }

}
