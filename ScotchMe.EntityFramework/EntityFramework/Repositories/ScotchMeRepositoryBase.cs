using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ScotchMe.EntityFramework.Repositories
{
    public abstract class ScotchMeRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ScotchMeDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ScotchMeRepositoryBase(IDbContextProvider<ScotchMeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ScotchMeRepositoryBase<TEntity> : ScotchMeRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ScotchMeRepositoryBase(IDbContextProvider<ScotchMeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
