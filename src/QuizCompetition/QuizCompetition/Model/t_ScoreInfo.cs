//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class t_ScoreInfo
    {
        public int UserId { get; set; }
        public int QuizId { get; set; }
        public int Score { get; set; }
    
        public virtual t_quiz t_quiz { get; set; }
        public virtual t_user t_user { get; set; }
    }
}
