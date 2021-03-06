﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using ScotchMe.Authorization.Roles;
using ScotchMe.Authorization.Users;
using ScotchMe.Entities;
using ScotchMe.MultiTenancy;

namespace ScotchMe.EntityFramework
{
    public class ScotchMeDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Scotch> Scotches { get; set; }

        public IDbSet<ScotchRatingSource> ScotchRatingSources { get; set; }

        public IDbSet<ScotchRating> ScotchRatings { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ScotchMeDbContext()
            : base("Default")
        {
            
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ScotchMeDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ScotchMeDbContext since ABP automatically handles it.
         */
        public ScotchMeDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ScotchMeDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ScotchMeDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
