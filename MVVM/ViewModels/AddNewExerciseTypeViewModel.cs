using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthCare.DbContext;
using HealthCare.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.MVVM.ViewModels
{
    public partial class AddNewExerciseTypeViewModel : ObservableObject
    {
        public AddNewExerciseTypeViewModel()
        {
            ExercisetypeDetails = new ExerciseType();
        }
        
        public ExerciseType ExercisetypeDetails { get; set; }

        [RelayCommand]
        public async Task AddNewExerciseType()
        {
            var exercisetypedata = this.ExercisetypeDetails;

            var response = await App.Database.CreateAsync(exercisetypedata);

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("ExerciseType saved", "ExerciseType Details Successfully submitted", "Ok");
                
                //Redirect to our list page
                await Shell.Current.GoToAsync($"..");
            }
            else
            {
                await Shell.Current.DisplayAlert("ExerciseType not saved", "Something went wrong", "Ok");
            }
        }
    }
}
