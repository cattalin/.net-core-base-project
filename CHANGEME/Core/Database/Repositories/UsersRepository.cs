﻿using Core.Database.Context;
using Core.Database.Entities;
using Infrastructure.Base;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Database.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        private readonly IServiceScope scope;
        private readonly DatabaseContext context;

        public UsersRepository(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            scope = serviceProvider.CreateScope();
            context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
        }
    }
}
