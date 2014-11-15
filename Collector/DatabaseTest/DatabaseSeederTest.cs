using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace DatabaseSeederTest
{
    [TestClass]
    public class DatabaseSeederTest
    {
        [Test]
        public void CanConnect()
        {
            new DatabaseSeeder.DatabaseSeeder();
            DatabaseSeeder.DatabaseSeeder.Select();
        }

        [Test]
        public void CanInit()
        {
            new DatabaseSeeder.DatabaseSeeder();
        }

    }
}