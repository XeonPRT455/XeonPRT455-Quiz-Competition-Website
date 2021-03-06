﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizCompetition.Controllers;
using QuizCompetition.DTO;
using QuizCompetition.App_Start;

namespace QuizCompetition.Tests.Controllers
{
    /// <summary>
    /// Summary description for UserControllerTest
    /// </summary>
    [TestClass]
    public class UserControllerTest
    {
        public UserControllerTest()
        {


            AutoMapperConfig.Initialize();
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

        [TestMethod]
        public void TesGetUser()
        {
            UserController controller = new UserController();
            UserDTO tu = controller.Get(1);

            Assert.IsNotNull(tu);
           
            Assert.AreEqual("abc1", tu.UserName);
            Assert.AreEqual("abc1", tu.NickName);
        }
    }
}
