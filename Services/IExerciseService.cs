using HealthCare.DbContext;
using HealthCare.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Services
{
    public interface IExerciseService
    {
        Task<List<Exercise>> GetExercisesList();

        Task<int> AddExercise(Exercise exercise);

        Task<int> DeleteExercise(Exercise exercise);

        Task<int> UpdateExercise(Exercise exercise);
    }
}
