using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace QIAB.Models
{

    public class QIABContext : DbContext
    {
        public QIABContext(DbContextOptions<QIABContext> options) : base(options)
        { }

        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
    }

    public class QuestionModel
    {

        public QuestionModel()
        {
            Id = Guid.NewGuid();
            DateEntered = DateTime.Now;
        }

        [Required]
        public Guid Id { get; set; }

        [DisplayName("Enter a question")]
        [Required]
        public string Question { get; set; }

        [DisplayName("Enter the answer")]
        [Required]
        public string Answer { get; set; }

        [DisplayName("Potential answer 1")]
        public string PotAnswer1 { get; set; }

        [DisplayName("Potential answer 2")]
        public string PotAnswer2 { get; set; }

        [DisplayName("Potential answer 3")]
        public string PotAnswer3 { get; set; }

        [DisplayName("Question Type")]
        public string QuestionTypeId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateEntered { get; set; }
    }
}
