using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Employer newEmployer = new Employer();
            newEmployer.Value = "ACME";
            Location newLocation = new Location();
            newLocation.Value = "Desert";
            PositionType newPosition = new PositionType();
            newPosition.Value = "Quality Control";
            CoreCompetency coreCompetency = new CoreCompetency();
            coreCompetency.value = "Persistence";

            Job newJob1 = new Job("Product Tester",newEmployer,newLocation,newPosition,coreCompetency);
            Assert.AreEqual("Product Tester", newJob1.Name);
            Assert.AreEqual(newEmployer.Value, newJob1.EmployerName.Value);
            Assert.AreEqual(newLocation.Value, newJob1.EmployerLocation.Value);
            Assert.AreEqual(newPosition.Value, newJob1.JobType.Value);
            Assert.AreEqual(coreCompetency.value, newJob1.JobCoreCompetency.value);
            
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer newEmployer = new Employer();
            newEmployer.Value = "ACME";
            Location newLocation = new Location();
            newLocation.Value = "Desert";
            PositionType newPosition = new PositionType();
            newPosition.Value = "Quality Control";
            CoreCompetency coreCompetency = new CoreCompetency();
            coreCompetency.value = "Persistence";

            Job newJob1 = new Job("Product Tester", newEmployer, newLocation, newPosition, coreCompetency);
            Job newJob2 = new Job("Product Tester", newEmployer, newLocation, newPosition, coreCompetency);
            Assert.IsFalse(newJob1.Equals(newJob2));
            Assert.IsFalse(newJob2.Equals(newJob1));
        }
    }
}
