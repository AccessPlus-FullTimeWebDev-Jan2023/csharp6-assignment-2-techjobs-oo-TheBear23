
using TechJobsOOAutoGraded6;

namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing objects
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        // Test the Empty Constructor
        [TestMethod]
        public void TestSettingJobId()
        {
            // Check that the ID values for the two empty constructor Job objects are NOT the same and differ by 1
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }

        // Test the Full Constructor
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            // Check that the object is assigned the correct properties
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }

        // Test the Equals() Method
        [TestMethod]
        public void TestJobsForEquality()
        {
            // Check that two Job objects with different fields are not considered equal
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            
            Job job = new Job();
           
            string jobString = job.ToString();
            
            Assert.IsTrue(jobString.StartsWith("\n"));
            Assert.IsTrue(jobString.EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string result = job.ToString();

            Assert.IsTrue(result.Contains("ID: "));
            Assert.IsTrue(result.Contains("Name: Product tester"));
            Assert.IsTrue(result.Contains("Employer: ACME"));
            Assert.IsTrue(result.Contains("Location: Desert"));
            Assert.IsTrue(result.Contains("Position Type: Quality control"));
            Assert.IsTrue(result.Contains("Core Competency: Persistence"));
            Assert.IsTrue(result.StartsWith("\n"));
            Assert.IsTrue(result.EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job job = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string result = job.ToString();
            string expected = "\nID: " + job.Id + "\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n";
            Assert.AreEqual(expected, result);
            Assert.IsTrue(result.StartsWith("\n"));
            Assert.IsTrue(result.EndsWith("\n"));
        }
    }
}

