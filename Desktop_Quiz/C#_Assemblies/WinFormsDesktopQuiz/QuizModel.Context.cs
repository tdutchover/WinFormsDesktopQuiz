﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsDesktopQuiz
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PCAD7QuizEntities : DbContext
    {
        public PCAD7QuizEntities()
            : base("name=PCAD7QuizEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
