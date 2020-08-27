using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitedYouthOrchestra6.Models;

namespace UnitedYouthOrchestra6.Data
{
    public class UnitedYouthOrchestra6Context : DbContext
    {
        public UnitedYouthOrchestra6Context (DbContextOptions<UnitedYouthOrchestra6Context> options)
            : base(options)
        {
        }

        public DbSet<UnitedYouthOrchestra6.Models.Instrument> Instrument { get; set; }

        public DbSet<UnitedYouthOrchestra6.Models.SchoolYear> SchoolYear { get; set; }

        public DbSet<UnitedYouthOrchestra6.Models.Member> Member { get; set; }
    }
}
