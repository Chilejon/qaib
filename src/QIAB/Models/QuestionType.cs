using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QIAB.Models
{
    public class QuestionType
    {
            public QuestionType()
            {
                Id = Guid.NewGuid();
            }

            [Required]
            public Guid Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public bool Special { get; set; }
        }
    }
