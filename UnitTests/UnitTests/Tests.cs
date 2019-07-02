using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        private StringUtils utils;

        [SetUp]
        public void Init()
        {
            utils = new StringUtils();
        }

        [TestCase("abcd", "dcba")]
        [TestCase("1234", "4321")]
        [TestCase("-1234", "4321-")]
        public void CheckCommonScenario(string input, string output)
        {
            //Act
            var actual = utils.ReverseStringWithFor(input);

            //Assert
            Assert.AreEqual(output, actual);
        }

        [Test]
        public void CheckEmptyString()
        {
            //Arrange
            string input = "";

            //Act
            var actual = utils.ReverseStringWithFor(input);

            //Assert
            Assert.AreEqual("", actual);
        }

        [Test]
        public void CheckNullString()
        {
            //Arrange
            string input = null;

            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(
                () => utils.ReverseStringWithFor(input));
        }
    }
}
