using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBack.Models
{
    public class SeedData
    {
        public static void SeedDatabase(MarketContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                var Admin = new User
                {
                    FirstName = "Mohammed",
                    LastName = "Rabee",
                    Username = "MhdRab",
                    Password = "123456789"
                };
                context.SaveChanges();
            }
            
        }
    }
}
