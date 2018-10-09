using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizCompetition.Controllers;
using QuizCompetition.DTO;
using System.Linq;
using QuizCompetition.App_Start;

namespace QuizCompetition.Tests.Controllers
{
    /// <summary>
    /// Summary description for QuizControllerTest
    /// </summary>
    [TestClass]
    public class QuizControllerTest
    {
        public QuizControllerTest()
        {
            
        }

        [ClassInitialize]
        static public void Init(TestContext context)
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
        public void TestGetQuiz()
        {
            QuizController controller = new QuizController();
            QuizDTO tq = controller.GetQuiz(1);

            Assert.IsNotNull(tq);
            Assert.AreEqual(1, tq.QuizId);
            Assert.AreEqual("quiz1", tq.QuizName);
        }

        [TestMethod]
        public void TestGetQuestions()
        {
            QuizController controller = new QuizController();
            List<QuestionDTO> tqs = controller.GetQuestions(1);

            Assert.AreEqual(2, tqs.Count());
            Assert.IsNotNull(tqs);
            Assert.AreEqual("A new web page pops up.What do you do?", tqs[0].Question);
            Assert.AreEqual("Can hacker control camera in front of your laptop?", tqs[1].Question);
        }
    }
}
