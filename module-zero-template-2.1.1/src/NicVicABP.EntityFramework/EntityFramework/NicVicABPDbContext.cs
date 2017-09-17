using System.Data.Common;
using Abp.Zero.EntityFramework;
using NicVicABP.Authorization.Roles;
using NicVicABP.Authorization.Users;
using NicVicABP.MultiTenancy;

namespace NicVicABP.EntityFramework
{
    public class NicVicABPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public NicVicABPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in NicVicABPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of NicVicABPDbContext since ABP automatically handles it.
         */
        public NicVicABPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public NicVicABPDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public NicVicABPDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
