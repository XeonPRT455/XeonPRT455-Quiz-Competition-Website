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
    
    public partial class t_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_user()
        {
            this.t_question = new HashSet<t_question>();
            this.t_quiz = new HashSet<t_quiz>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string UserRole { get; set; }
        public string PassWord { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<System.DateTime> Birth { get; set; }
        public Nullable<System.DateTime> LastTimeLogOn { get; set; }
        public Nullable<double> Credits { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_question> t_question { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_quiz> t_quiz { get; set; }
        public virtual t_QuizInfo t_QuizInfo { get; set; }
        public virtual t_ScoreInfo t_ScoreInfo { get; set; }
    }
}