using System;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    public class CharacterTest
    {
        Character myCharacter;

        [SetUp]
        public void Setup()
        {
            // TODO: update this function once the changes to the constructor has been made in Character.cs
            myCharacter = new Character("Bob", RaceCatagory.Human, 100);
        }

        [Test]
        public void TestDamageCharacter()
        {
            myCharacter.TakeDamage(1);
            int expected = 99;
            int actual = myCharacter.HealthPoints;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 99)]
        [TestCase(10, 90)]
        [TestCase(100, 0)]
        public void TestDamageCharacter(int damage, int expected)
        {
            myCharacter.TakeDamage(damage);
            int actual = myCharacter.HealthPoints;

            Assert.AreEqual(expected, actual);
        }
        
        // TODO: should add another test for validating the character was created properly for each of its properties.

    }
}
