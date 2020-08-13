using Microsoft.SqlServer.Server;
using NUnit.Framework;
using System;

namespace Jxtils.Managers
{
    [TestFixture]
    [TestOf(typeof(IteratedDataManager))]
    public static class IteratedDataManagerTests
    {
        [Test]
        public static void IntArrayConstructor()
        {
            IteratedDataManager iteratedDataManager = new IteratedDataManager(new int[] { 0, 2, 3, 8, 12, });

            Assert.That(iteratedDataManager, Is.Not.Null);
        }

        [Test]
        public static void StringConstructor()
        {
            IteratedDataManager iteratedDataManager = new IteratedDataManager("0|0|1|1|0|0|1");

            Assert.That(iteratedDataManager, Is.Not.Null);
        }

        [Test]
        public static void ConvertToString()
        {
            IteratedDataManager iteratedDataManager = new IteratedDataManager(new int[] { 0, 2, 3, 8, 12, });

            Assert.That(iteratedDataManager.ToString(), Is.EqualTo("0|2|3|8|12"));
        }

        [Test]
        public static void GettingIndex()
        {
            IteratedDataManager iteratedDataManager = new IteratedDataManager(new int[] { 0, 2, 3, 8, 12, });

            Assert.That(iteratedDataManager[0], Is.Zero, "The first index should be zero.");
            Assert.That(iteratedDataManager[1], Is.EqualTo(2));
            Assert.That(iteratedDataManager[2], Is.EqualTo(3));
            Assert.That(iteratedDataManager[3], Is.EqualTo(8));
            Assert.That(iteratedDataManager[4], Is.EqualTo(12));
        }

        [Test]
        public static void StringConstructorInvalidInput()
        {
            Assert.That(() => new IteratedDataManager("blah"), Throws.InstanceOf<FormatException>());
        }
    }
}
