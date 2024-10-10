using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthCare.DbContext;
using HealthCare.MVVM.Models;
using HealthCare.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.MVVM.ViewModels
{
    public partial class ExerciseLocationTypeViewModel : ObservableObject
    {
        public ObservableCollection<ExerciseLocationType> ExerciseLocationTypes { get; set; } = new ObservableCollection<ExerciseLocationType>();

        public ExerciseLocationTypeViewModel()
        {

        }

        [RelayCommand]
        public async Task AddNewExerciseLocationType()
        {
            await AppShell.Current.GoToAsync(nameof(AddNewExerciseLocationTypePage));
        }
    }
}
