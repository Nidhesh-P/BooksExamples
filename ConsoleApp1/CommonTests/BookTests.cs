using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;
using System.Diagnostics.CodeAnalysis;

namespace BookTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestOverloadedConstructor()
        {
            Book b = new Book(1, "Test", "NewAuthor");
            Assert.AreEqual(1, b.ID);
            Assert.AreEqual("Test", b.Title);
            Assert.AreEqual("NewAuthor", b.Author);
        }

        [TestMethod]
        public void GetDetailsTest()
        {
            Book b = new Book(1, "Test", "NewAuthor");
            var result = b.GetDetails();
            Assert.IsTrue(!string.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void BookConstructorTest()
        {
            Book b = new Book();            
            Assert.AreEqual(0,b.ID);
        }
    }
}
