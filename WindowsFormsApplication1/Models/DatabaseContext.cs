using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
  public class DatabaseContext:System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {
        }
        public DatabaseContext()
            : base()
        {
        }

        public object Person { get; set; }
        public System.Data.Entity.DbSet<Person>Persons{ get; set; }
    }        
}


