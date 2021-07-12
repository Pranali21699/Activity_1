using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1.Tests
{
    [TestClass()]
    public class InstructorTests
    {
        [TestMethod()]
        public void CheckSkillTestpositivetest()
        {
            string[] value = { "java ", "cplusplus", "python", "csharp", "c" };
            Instructor obj = new Instructor("Pranali", 4.6f, 4, value);
            bool actual = obj.CheckSkill("python");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckSkillTestnegativetest()
        {
            string[] value = { "java ", "cplusplus", "python", "csharp", "c" };
            Instructor obj = new Instructor("Pranali", 4.3f, 4, value);
            bool actual = obj.CheckSkill("ruby");
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void InstructorTest()
        {
            


        }

        [TestMethod()]
        public void ValidateEligibilityTestPositivetest()
        {
            string[] value = { "java ", "cplusplus", "python", "csharp", "c" };
            Instructor obj = new Instructor("Pranali", 4.6f, 4, value);
            bool actual = obj.ValidateEligibility();
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateEligibilityTestNegativetest()
        {
            string[] value = { "java ", "cplusplus","python", "csharp", "c" };
            Instructor obj = new Instructor("Pranali", 4.3f, 4, value);
            bool actual = obj.ValidateEligibility();
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}