using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job ()
        {
            this.Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType type, CoreCompetency coreCompetency ) : this()
        {
            string charString = "abcdefghijklmnopqrstuvwxyz";
            if (charString.Contains(name.ToLower()))
            {
                this.Name = "Data unavailable";
                this.EmployerName = employerName;
                this.EmployerLocation = employerLocation;
                this.JobType = type;
                this.JobCoreCompetency = coreCompetency;
            }
            else
            {
                this.Name = name;
                this.EmployerName = employerName;
                this.EmployerLocation = employerLocation;
                this.JobType = type;
                this.JobCoreCompetency = coreCompetency;
            }

        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string checkForThis = "Data unavailable";

            if ((this.Name.Contains(checkForThis)) && (this.EmployerName.Value.Contains(checkForThis)) && 
               (this.EmployerName.Value.Contains(checkForThis)) && (this.EmployerName.Value.Contains(checkForThis)) && (this.EmployerName.Value.Contains(checkForThis)))
            {
                return "***************\nID: " + this.Id + "\nWHOOPS! This job doesn't exist.\n***************";
            } 
            else
            {
                string id = "ID: " + this.Id + " ";
                string nom = "\nName: " + this.Name + " ";
                string empNom = "\nEmployer:" + this.EmployerName;
                string empLoc = "\nLocation:" + this.EmployerLocation;
                string posType = "\nPosition Type:" + this.JobType;
                string coreComp = "\nCore Competency:" + this.JobCoreCompetency;

                return id + nom + empNom + empLoc + posType + coreComp;
            }
            
            
                
        }


    }
}
