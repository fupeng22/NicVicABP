using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace NicVicABP.EntityFramework.Repositories
{
    public abstract class NicVicABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<NicVicABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected NicVicABPRepositoryBase(IDbContextProvider<NicVicABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class NicVicABPRepositoryBase<TEntity> : NicVicABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected NicVicABPRepositoryBase(IDbContextProvider<NicVicABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
