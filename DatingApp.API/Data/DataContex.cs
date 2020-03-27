using Microsoft.EntityFrameworkCore;
using DatingApp.API.models;

namespace DatingApp.API.Data
{
    public class DataContex : DbContext 
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options) {}
        public DbSet<Value> Values { get; set; }

    }
}