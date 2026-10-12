using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    internal class KittyTEST
    {
        [TestMethod]
        public void TestIsAbleToMakeNewInstance()
        {
            Assert.IsExactInstanceOfType<Kitty>(new Kitty("string"));
        }
        [TestMethod]
        public void TestCharacterStat()
        {
            Kitty kitty = new Kitty("string");
            Assert.AreEqual(kitty.Name, "string");
            Assert.AreEqual(kitty.Strength, 2);
        }
    }
}
