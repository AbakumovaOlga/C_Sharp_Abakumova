using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3
{
    public class PlayContext : DbContext
    {
        public PlayContext()
           : base("MyDbConnection")
        { }

        public DbSet<PlayDB> Plays { get; set; }
    }
}
