using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Data.EntityFramework.Entities;

namespace Data.EntityFramework.Context
{
    public class TitlesContext : DbContext
    {
        public DbSet<Title> Title { get; set; }

        static TitlesContext()
        {
            Database.SetInitializer<TitlesContext>(null);
        }

        public TitlesContext(string connectionString)
            : base(connectionString)
        {
        }        

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errors = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                
                var fullErrorMessage = string.Join("; ", errors);

                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors, ex);
            }
        }
    }
}
