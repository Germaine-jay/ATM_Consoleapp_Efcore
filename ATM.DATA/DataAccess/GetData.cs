using ATM.DATA.Database;
using ATM.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ATM.DATA.DataAccess
{
    public class GetData
    {
        public static AtmDbContext _dbContext;

        public static IEnumerable <Customer> UserQuaery()
        {
            AtmDbContextFactory AtmDbContextfactory = new AtmDbContextFactory();
            var dbcontext = AtmDbContextfactory.CreateDbContext(null);
            _dbContext = dbcontext;

            IQueryable<Customer> userQuery = dbcontext.Customers.Include(u => u.Account);

            return userQuery;
        }
    }
}
