
using CharacterSelectTest.Domain.Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class MouseTEST
    {
        [TestMethod]
        public void TestIsAbleToMakeNewInstance()
        {
            Mouse mouse = new Mouse("Mouse");

            Assert.IsInstanceOfType(mouse, typeof(Mouse));
        }

        [TestMethod]
        public void TestCharacterStat()
        {
            Mouse mouse = new Mouse("Mouse");

            Assert.AreEqual("Mouse", mouse.Name);
            Assert.AreEqual(20, mouse.Health);
            Assert.AreEqual(1, mouse.Strength);
            Assert.AreEqual(20, mouse.Intelligence);
            Assert.AreEqual(17, mouse.Agility);
            Assert.AreEqual(20, mouse.Speed);
            Assert.AreEqual(8, mouse.Cutie);
        }

        [TestMethod]
        public void TestAttack()
        {
            Mouse mouse = new Mouse("Mouse");

            Assert.AreEqual(60, mouse.Attack());
        }
    }
}

