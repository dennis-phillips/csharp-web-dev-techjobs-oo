using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http.Headers;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job newJob1 = new Job();
            Job newJob2 = new Job();
            Assert.AreNotEqual(newJob1.Id, newJob2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer newEmployer = new Employer("ACME");
            Location newLocation = new Location("Desert");
            PositionType newPosition = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            

            Job newJob1 = new Job("Product Tester",newEmployer,newLocation,newPosition,coreCompetency);
            Assert.AreEqual("Product Tester", newJob1.Name);
            Assert.AreEqual(newEmployer.Value, newJob1.EmployerName.Value);
            Assert.AreEqual(newLocation.Value, newJob1.EmployerLocation.Value);
            Assert.AreEqual(newPosition.Value, newJob1.JobType.Value);
            Assert.AreEqual(coreCompetency.Value, newJob1.JobCoreCompetency.Value);
            
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer newEmployer = new Employer("ACME");
            Location newLocation = new Location("Desert");
            PositionType newPosition = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            
            Job newJob1 = new Job("Product Tester", newEmployer, newLocation, newPosition, coreCompetency);
            Job newJob2 = new Job("Product Tester", newEmployer, newLocation, newPosition, coreCompetency);
            Assert.IsFalse(newJob1.Equals(newJob2));
            Assert.IsFalse(newJob2.Equals(newJob1));
        }
        [TestMethod]
        public void TestStringMethodIsCalled()
        {
            Employer newEmployer = new Employer("ACME");
            
            Location newLocation = new Location("Desert");
            PositionType newPosition = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            
            Job newJob1 = new Job("Product Tester", newEmployer, newLocation, newPosition, coreCompetency);
            string testString = ($"\nID: {newJob1.Id}\nName: {newJob1.Name}\nEmployer: {newJob1.EmployerName}\nLocation: {newJob1.EmployerLocation}\nPosition Type: {newJob1.JobType}\nCore Competency: {newJob1.JobCoreCompetency}\n");
            string newJob1String = newJob1.ToString();

            Assert.AreEqual(testString, newJob1.ToString());

        }
        [TestMethod]
        public void TooStringMethodTestCheckForBlankLines()
        {
            Employer newEmployer = new Employer("ACME");
            Location newLocation = new Location("Desert");
            PositionType newPosition = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            
            Job newJob1 = new Job("Product Tester", newEmployer, newLocation, newPosition, coreCompetency);
            string testString = ($"\nID: {newJob1.Id}\nName: {newJob1.Name}\nEmployer: {newJob1.EmployerName}\nLocation: {newJob1.EmployerLocation}\nPosition Type: {newJob1.JobType}\nCore Competency: {newJob1.JobCoreCompetency}\n");
            string newJob1String = newJob1.ToString();

            
            Assert.AreEqual((testString[0]), (newJob1.ToString()[0]));
            Assert.AreEqual(testString[testString.Length - 1], newJob1.ToString()[newJob1.ToString().Length - 1]);

        }
        public void TooStringMethodTestForFieldsandValues()
        {
            Employer newEmployer = new Employer("ACME");
            Location newLocation = new Location("Desert");
            PositionType newPosition = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");
            
            Job newJob1 = new Job("Product Tester", newEmployer, newLocation, newPosition, coreCompetency);
            string testString = ($"\nID: {newJob1.Id}\nName: {newJob1.Name}\nEmployer: {newJob1.EmployerName}\nLocation: {newJob1.EmployerLocation}\nPosition Type: {newJob1.JobType}\nCore Competency: {newJob1.JobCoreCompetency}\n");
            string newJob1String = newJob1.ToString();
                     
           Assert.IsTrue(newJob1.ToString().Contains($"\nID: {newJob1.Id}\nName: {newJob1.Name}\nEmployer: {newJob1.EmployerName}\nLocation: {newJob1.EmployerLocation}\nPosition Type: {newJob1.JobType}\nCore Competency: {newJob1.JobCoreCompetency}"));
        }
    }
}
