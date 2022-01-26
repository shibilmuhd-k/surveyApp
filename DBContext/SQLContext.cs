using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Survey.Models;

namespace Survey.DBContext
{
    public class SQLContext:DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options) : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TechSurvey>().HasData(
        //        new TechSurvey
        //        {
        //            id = "1",
        //            question = "1",
        //            type = "test name 1",
        //            createdDate = " test std 1",
        //            updateDate = ""
        //        }
        //    );
        //}
        public virtual DbSet<TechSurvey> TechSurvey { get; set; }
    }
}
