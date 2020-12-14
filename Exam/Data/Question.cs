using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Data
{
    public record Question
    {
        private static readonly Random Random = new();

        public int Id { get; init; }
        public string Content { get; init; }
        public List<QuestionItem> Items { get; init; }
    }

    public record QuestionItem
    {
        public int Id { get; init; }
        public string Content { get; init; }
        public bool IsCorrect { get; init; }

        public QuestionItem(int id, string content, bool isCorrect) => (Id, Content, IsCorrect) = (id, content, isCorrect);
    }
}
