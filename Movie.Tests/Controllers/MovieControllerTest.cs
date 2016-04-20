using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Movie.Controllers;
using Movie.Models;

namespace Movie.Tests.Controllers
{
    /// <summary>
    /// Summary description for MovieControllerTest
    /// </summary>
    [TestClass]
    public class MovieControllerTest
    {
        public MovieControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void IndexWelcomeMessage()
        {
            // Arrange

            MovieController controller = new MovieController();

            // Act

            ViewResult result = controller.Index();

            // Assert

            Assert.AreEqual("Welcome to the Reviews. Kindly review all the movies!", controller.ViewBag.WelcomeMessage);
        }

        [TestMethod]
        public void MovieName()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            ViewResult viewResult = controller.Movie();
            MovieX result = viewResult.Model as MovieX;

            // Assert
            Assert.AreEqual("Thunderbirds", result.Name);
        }

        [TestMethod]
        public void ProductIsBling()
        {
            // Arrange
            MovieController controller = new MovieController();
            // Act
            ViewResult result = controller.Movie();
            // Assert
            Assert.AreEqual("Bling!", result.ViewBag.SubTitle);
        }





        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
    }
}
