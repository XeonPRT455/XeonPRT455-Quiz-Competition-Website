using AutoMapper;
using BLL;
using Model;
using QuizCompetition.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizCompetition.Controllers
{
    public class QuizController : ApiController
    {

        private IQuizService QuizService = BLL.Container.Resolve<IQuizService>();
        private IOptionsService OptionsService = BLL.Container.Resolve<IOptionsService>();
        private IQuestionService QuestionService = BLL.Container.Resolve<IQuestionService>();
        private IQuestionQuizService QuestionQuizService = BLL.Container.Resolve<IQuestionQuizService>();
        // GET: api/Quiz
        public List<QuestionDTO> GetQuestions(int id)
        {
            List<int> lqqq = QuestionQuizService.getQuestionsId(id);
            List<t_question> list = QuestionService.GetListById(lqqq);
            List<QuestionDTO> listD= new List<QuestionDTO>();
            foreach (t_question question in list) {
                var questionD = Mapper.Map<QuestionDTO>(question);
                List<t_options> lo = OptionsService.GetOptionsList(question.QuestionId);
                questionD.option1 = lo[0].OptionContent;
                questionD.option2 = lo[1].OptionContent;
                questionD.option3 = lo[2].OptionContent;
                questionD.option4 = lo[3].OptionContent;

                listD.Add(questionD);
                     
                    
                    }
            return listD;
        }

        // GET: api/Quiz/5
        public QuizDTO GetQuiz(int id)
        {

            var quiz = QuizService.Load(id);

            var quizD = Mapper.Map<QuizDTO>(quiz);
           
          

            return quizD;
            
        }

       

        // POST: api/Quiz
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Quiz/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Quiz/5
        public void Delete(int id)
        {
        }
    }
}
