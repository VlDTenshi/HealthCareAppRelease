using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DbContext
{
    public class ExerciseLocationType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string LocationName { get; set; }
    }
}
