using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace BSU.ASP._15._01.Day14.Bunjak.Models
{
    public class TrainingContext : DbContext
    {
        public DbSet<Training> Tranings { get; set; }
        public DbSet<RegistrationStudent> Students { get; set; }
    }
}