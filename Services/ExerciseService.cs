using HealthCare.DbContext;
using HealthCare.MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Services
{
    public class ExerciseService : IExerciseService
    {
        private SQLiteAsyncConnection _dbConnection;

        public ExerciseService(string dbPath)
        {
            //SetUpDatabase();
            _dbConnection  = new SQLiteAsyncConnection(dbPath);
            _dbConnection.CreateTableAsync<Exercise>().Wait();

        }

        //private async Task SetUpDatabase()
        //{
        //    if (_dbConnection == null)
        //    {
        //        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Exercise.db3");
        //        _dbConnection = new SQLiteAsyncConnection(dbPath);
        //        await _dbConnection.CreateTableAsync<Exercise>();
        //    }
        //}

        public async Task<int> AddExercise(Exercise exercise)
        {
            //await SetUpDatabase();
            if (exercise.Id != 0)
            {
                return await _dbConnection.UpdateAsync(exercise);
            }
            else
            {
                return await _dbConnection.InsertAsync(exercise);
            }
           
        }
        public async Task<int> DeleteExercise (Exercise exercise)
        {
            //await SetUpDatabase();
            return await _dbConnection.DeleteAsync(exercise);
        }
        public async Task<List<Exercise>> GetExercisesList()
        {
            //await SetUpDatabase();
            var exerciseList =  await _dbConnection.Table<Exercise>().ToListAsync();
            return exerciseList;
        }
        public async Task<int> UpdateExercise(Exercise exercise)
        {
            //await SetUpDatabase();
            return await _dbConnection.UpdateAsync(exercise);
        }
    }
}
