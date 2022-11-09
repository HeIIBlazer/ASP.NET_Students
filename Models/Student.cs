using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentStore2022.Models
{
    public class Student
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }

        public string Aadress { get; set; }

        public int? SpecialityId { get; set; }

        public Speciality Speciality { get; set; }
    }
}