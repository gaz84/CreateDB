﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Answer: BaseEntity
    {
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }

        public virtual Card Card { get; set; }
    }
}