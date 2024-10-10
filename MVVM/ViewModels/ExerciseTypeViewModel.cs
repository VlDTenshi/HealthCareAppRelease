using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HealthCare.DbContext;
using HealthCare.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.MVVM.ViewModels
{
    public partial class ExerciseTypeViewModel : ObservableObject
    {
        public ObservableCollection<ExerciseType> ExerciseTypes { get; set; } = new ObservableCollection<ExerciseType>();

        public ExerciseTypeViewModel()
        {
            LoadExerciseType();
        }

        public void LoadExerciseType()
        {
            ExerciseTypes.Clear();
            var allexercisetypes = App.Database.GetTableRows<ExerciseType>("ExerciseType").ToList();
            foreach(var exercisetype in allexercisetypes)
            {
                ExerciseTypes.Add(exercisetype);

            }
            
        }

        [RelayCommand]
        public async Task AddNewExerciseType()
        {
            await AppShell.Current.GoToAsync(nameof(AddNewExerciseTypePage));
        }
    }
    
}
