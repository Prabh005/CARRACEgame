using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingGame.AllClasses;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Punter guy = Factory(0);
            Assert.IsTrue(guy.PunterName.Equals("Prabh"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Punter guy = Factory(1);
            Assert.IsTrue(guy.PunterName.Equals("Rahul"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Punter guy = Factory(2);
            Assert.IsTrue(guy.PunterName.Equals("Akash"));
        }

        private Punter Factory(int id)
        {
            switch (id)
            {
                case 0:
                    return new Prabneet();
                case 1:
                    return new Rahul();
                case 2:
                    return new Akash();

                default: return null;


            }
        }
       
    }
}
