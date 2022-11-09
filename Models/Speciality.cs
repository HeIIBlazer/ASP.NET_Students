using System.Collections.Generic;

namespace StudentStore2022.Models
{
    public class Speciality
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students {  get; set; }

        public Speciality()
        {
            Students = new List<Student>();
        }

    }
}