using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

    public class TimeManagementContext : DbContext
    {
        public TimeManagementContext (DbContextOptions<TimeManagementContext> options)
            : base(options)
        {
        }

        // db sets of tables created in the database

        public DbSet<ST10084788_PROG6212_POE.Model.Semester> Semester { get; set; }

        public DbSet<ST10084788_PROG6212_POE.Model.Module> Module { get; set; }

        public DbSet<ST10084788_PROG6212_POE.Model.StudySession> StudySession { get; set; }

        public DbSet<ST10084788_PROG6212_POE.Model.Notification> Notification { get; set; }
    }
