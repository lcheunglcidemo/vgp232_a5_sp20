﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
