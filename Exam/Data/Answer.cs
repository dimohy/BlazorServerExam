using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class Answer
    {
        private int? answerId;

        public int QuestionId { get; }
        public int? AnswerId
        {
            get => answerId;
            set
            {
                if (value == answerId)
                    return;

                AnswerTime = DateTime.Now;

                answerId = value;
            }
        }
        public DateTime? AnswerTime { get; private set; }

        public Answer(int questionId) => this.QuestionId = questionId;
    }
}
