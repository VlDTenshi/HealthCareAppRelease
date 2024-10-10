using HealthCare.MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DbContext
{
    public class ApplicationDbContext
    {
        public SQLiteAsyncConnection _dbConnection;

        //App Database
        public readonly static string nameSpace = "HealthCare.DbContext";

        public const string DatabaseFilename = "Health.db3";

        public string dbasePath = Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

        public const SQLite.SQLiteOpenFlags Flags =
            //opening database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            //Creating dbase if it does not exist
            SQLite.SQLiteOpenFlags.Create |
            //enable multi-threaded dbase access
            SQLite.SQLiteOpenFlags.SharedCache;

        public ApplicationDbContext()
        {

            if (_dbConnection == null)
            {
                //string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Health.db3");
                _dbConnection = new SQLiteAsyncConnection(dbasePath, Flags);
                _dbConnection.CreateTableAsync<Exercise>().Wait();
                _dbConnection.CreateTableAsync<ExerciseType>().Wait();
                _dbConnection.CreateTableAsync<ExerciseLocationType>().Wait();
            }
        }
        public async Task<int> CreateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            return await _dbConnection.InsertAsync(entity);
        }

        public List<T> GetTableRows<T>(string  tableName)
        {
            object[] obj = new object[] { };
            TableMapping map = new TableMapping(Type.GetType(nameSpace + tableName));
            string query = "SELECT + FROM[" + tableName + "]";

            return _dbConnection.QueryAsync(map, query, obj).Result.Cast<T>().ToList();
        }
    }
}

