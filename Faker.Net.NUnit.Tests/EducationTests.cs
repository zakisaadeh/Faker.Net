using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class Educationests
	{
		[Test]
		public void TestSchool()
		{
			Assert.IsTrue(Regex.IsMatch(Education.GetSchool(), @"[ a-z]+"));
            Assert.IsTrue(Regex.IsMatch(Education.GetSchool(), @"\s"));
		}

        [Test]
        public void TestCoruseAbbreviation()
        {
            Assert.IsTrue(Regex.IsMatch(Education.GetCourseAbbreviation(), @"[ a-z0-9]+"));
            Assert.IsTrue(Regex.IsMatch(Education.GetCourseAbbreviation(), @"\s"));
        }

        [Test]
        public void TestCoruseName()
        {
            Assert.IsTrue(Regex.IsMatch(Education.GetCourseName(), @"[ a-z]+"));
            Assert.IsTrue(Regex.IsMatch(Education.GetCourseName(), @"\s"));
        }
	}
}