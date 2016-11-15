using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QIAB.Models
{
    public class Sheet
    {
        [DisplayName("Question Set 1")]
        [Required]
        public string QuestionSet1 { get; set; }

        [DisplayName("Question Set 2")]
        [Required]
        public string QuestionSet2 { get; set; }

        [DisplayName("Question Set 3")]
        [Required]
        public string QuestionSet3 { get; set; }

        [DisplayName("Question Set 4")]
        [Required]
        public string QuestionSet4 { get; set; }

        [DisplayName("From Date")]
        public DateTime FromDate { get; set; }
    }
}
