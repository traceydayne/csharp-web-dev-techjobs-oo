using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job TestJob;
        Employer Boss;
        Location Place;
        PositionType Type;
        CoreCompetency Skill;
        string Name = "Product Tester";


        [TestInitialize]
        public void CreateTestJob()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality Assurance");
            CoreCompetency skill = new CoreCompetency("persistence");
            

            this.Boss = employer;
            this.Place = location;
            this.Type = type;
            this.Skill = skill;
            this.TestJob = new Job(Name, employer, location, type, skill);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            Assert.AreEqual((testJob1.Id + 1), testJob2.Id);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(TestJob.EmployerName, Boss);
            Assert.AreEqual(TestJob.EmployerLocation, Place);
            Assert.AreEqual(TestJob.JobType, Type);
            Assert.AreEqual(TestJob.JobCoreCompetency, Skill);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job(Name, Boss, Place, Type, Skill);
            Job testJob2 = new Job(Name, Boss, Place, Type, Skill);

            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void TestToStringForBlanks()
        {
            string actualLocation = Place.ToString();
            Job jobWithABlank = new Job("", Boss, Place, Type, Skill);

            Assert.IsTrue(actualLocation.StartsWith(" ") && actualLocation.EndsWith(" "));
            Assert.IsTrue(jobWithABlank.ToString().Contains("Data unavailable"));
        
        }

        [TestMethod]
        public void TestToStringForLabels()
        {
            string actualEmployer = "\nEmployer:" + Boss.ToString();

            Assert.IsTrue(TestJob.ToString().Contains(actualEmployer));
        }

        [TestMethod]
        public void TestToStringForBonus()
        {
            Job blankJob = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            Assert.IsTrue(blankJob.ToString().Contains("WHOOPS! This job doesn't exist."));
        }

    }
}
