
using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class SharkTEST
    {
        [TestMethod]
        public void TestIsAbleToMakeNewInstance()
        {
            Shark shark = new Shark("Shark");

            Assert.IsInstanceOfType(shark, typeof(Shark));
        }

        [TestMethod]
        public void TestCharacterStat()
        {
            Shark shark = new Shark("Shark");

            Assert.AreEqual("Shark", shark.Name);
            Assert.AreEqual(20, shark.Health);
            Assert.AreEqual(20, shark.Strength);
            Assert.AreEqual(5, shark.Intelligence);
            Assert.AreEqual(15, shark.Agility);
            Assert.AreEqual(20, shark.Speed);
            Assert.AreEqual(2, shark.Cutie);
        }

        [TestMethod]
        public void TestAttack()
        {
            Shark shark = new Shark("Shark");

            Assert.AreEqual(60, shark.Attack());
        }
    }
}