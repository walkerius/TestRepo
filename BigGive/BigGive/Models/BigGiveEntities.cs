using System.Data.Entity;

namespace BigGive.Models
{
    public class BigGiveEntities : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SubmitForm> Forms { get; set; }
    }
}
