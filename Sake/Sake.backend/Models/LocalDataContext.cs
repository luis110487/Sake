
namespace Sake.backend.Models

{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sake.Common.Models.Product> Products { get; set; }
    }
}