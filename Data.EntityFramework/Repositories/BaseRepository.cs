using System.Data.Entity;

namespace Data.EntityFramework.Repositories
{
    public abstract class BaseRepository<T>
        where T : DbContext
    {
        protected readonly T Context;

        protected BaseRepository(T context)
        {
            Context = context;
        }
    }
}
