using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Data
{
    public record Examinee
    {
        public string Uuid { get; init; }
        public string Id { get; init; }
        public string Class { get; init; }
        public string Name { get; init; }
    }
}
