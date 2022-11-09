using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentStore2022.Models
{
    public class StudentsStoreContext:DbContext
    {
        public DbSet<Student> Students {  get; set; }

        public DbSet<Speciality> Specialities { get; set; }
    }
}