using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
         public int Id { get; set; }
         public static int nextId = 1;
         public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            string charString = "abcdefghijklmnopqrstuvwxyz";
            if (charString.Contains(value.ToLower()))
            {
                Value = "Data unavailable";
            }
            else
            {
                Value = value;
            }
        }


        public override bool Equals(Object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return " " + Value + " ";
        }

    }
}
