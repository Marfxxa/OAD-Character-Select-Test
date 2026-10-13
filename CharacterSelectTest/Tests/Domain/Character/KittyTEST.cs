
using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class KittyTEST
    {
        [TestMethod]
        public void TestIsAbleToMakeNewInstance()
        {
            Kitty kitty = new Kitty("Kitty");

            Assert.IsInstanceOfType(kitty, typeof(Kitty));
        }

        [TestMethod]
        public void TestCharacterStat()
        {
            Kitty kitty = new Kitty("Kitty");

            Assert.AreEqual("Kitty", kitty.Name);
            Assert.AreEqual(10, kitty.Health);
            Assert.AreEqual(2, kitty.Strength);
            Assert.AreEqual(20, kitty.Intelligence);
            Assert.AreEqual(10, kitty.Agility);
            Assert.AreEqual(10, kitty.Speed);
            Assert.AreEqual(20, kitty.Cutie);
        }

        [TestMethod]
        public void TestAttack()
        {
            Kitty kitty = new Kitty("Kitty");

            Assert.AreEqual(60, kitty.Attack());
        }
    }
}

