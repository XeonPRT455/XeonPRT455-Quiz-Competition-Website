﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuizCompetitionEntities : DbContext
    {
        public QuizCompetitionEntities()
            : base("name=QuizCompetitionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<t_options> t_options { get; set; }
        public virtual DbSet<t_question> t_question { get; set; }
        public virtual DbSet<t_Question_Quiz> t_Question_Quiz { get; set; }
        public virtual DbSet<t_quiz> t_quiz { get; set; }
        public virtual DbSet<t_QuizInfo> t_QuizInfo { get; set; }
        public virtual DbSet<t_role> t_role { get; set; }
        public virtual DbSet<t_ScoreInfo> t_ScoreInfo { get; set; }
        public virtual DbSet<t_user> t_user { get; set; }
    }
}
