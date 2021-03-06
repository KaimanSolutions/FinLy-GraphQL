using System.Linq;
using finly.Data;
using finly.Models;
using HotChocolate;
using HotChocolate.Data;

namespace finly.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Profile> GetProfile([ScopedService] AppDbContext context)
        {
            return context.Profiles;
        }

        
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Client> GetClients([ScopedService] AppDbContext context)
        {
            return context.Clients;
        }
    }
}