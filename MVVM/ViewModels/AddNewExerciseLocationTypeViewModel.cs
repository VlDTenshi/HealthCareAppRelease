using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthCare.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.MVVM.ViewModels
{
    public partial class AddNewExerciseLocationTypeViewModel: ObservableObject
    {
        
        public AddNewExerciseLocationTypeViewModel()
        {
            ExerciselocationtypeDetails = new ExerciseLocationType();
        }
        public ExerciseLocationType ExerciselocationtypeDetails { get; set; }

        [RelayCommand]
        public async Task AddNewExerciseLocationType()
        {
            var exerciselocationtypedata = this.ExerciselocationtypeDetails;

            var response = await App.Database.CreateAsync(exerciselocationtypedata);

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("ExerciseLocationType saved", "ExerciseLocationType Details Successfully submitted", "Ok");

                //Redirect to our list page
                await Shell.Current.GoToAsync($"..");
            }
            else
            {
                await Shell.Current.DisplayAlert("ExerciseLocationType not saved", "Something went wrong", "Ok");
            }
        }
    }
}
