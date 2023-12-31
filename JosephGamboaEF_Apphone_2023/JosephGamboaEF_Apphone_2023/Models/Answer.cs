﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JosephGamboaEF_Apphone_2023.Models
{
    public class Answer
    {
        public long AnswerId { get; set; }
        public int UserId { get; set; }
        public long AskId { get; set; }
        public DateTime Date { get; set; }
        public string Answer1 { get; set; } = null!;
        public bool? SetAsCorrect { get; set; }
        public bool? IsStrike { get; set; }

        public virtual Ask Ask { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
