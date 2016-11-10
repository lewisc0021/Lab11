using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab11;

namespace PersonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person result1 = new Person("Bob", "2222 Street");
            Assert.AreEqual("Person[name=Bob,address=2222 Street]", result1.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Student result2 = new Student("James", "1233 Drive", "Psychology", 2, 25000);
            Assert.AreEqual("Student[Person[name=James,address=1233 Drive],program=Psychology,year=2,fee=25000]", result2.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Staff result3 = new Staff("Sam", "55 South Blvd", "Wayne State", 50000);
            Assert.AreEqual("Staff[Person[name=Sam,address=55 South Blvd],school=Wayne State,pay=50000]", result3.ToString());
        }


    }
}
