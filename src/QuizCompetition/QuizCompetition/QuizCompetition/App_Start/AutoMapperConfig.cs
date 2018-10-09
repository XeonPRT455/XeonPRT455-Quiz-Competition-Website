using AutoMapper;
using Model;
using QuizCompetition.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizCompetition.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<t_user, UserDTO>();
                cfg.CreateMap<t_question, QuestionDTO>();
                cfg.CreateMap<t_quiz, QuizDTO>();

            });
        }
    }
}