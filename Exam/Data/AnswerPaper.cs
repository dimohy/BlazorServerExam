using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class AnswerPaper
    {
        public Dictionary<int, Answer> AnswerList { get; set; } = new();
        public bool IsSubmit { get; set; }
        public DateTime? SubmitTime { get; set; }
    }
}
