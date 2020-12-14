using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Data
{
    public record Examination
    {
        public string Class { get; init; }
        public DateTime StartTime { get; init; }
        public DateTime EndTime { get; init; }
        public TimeSpan EntranceOverTime { get; init; }
        public DateTime ResultTime { get; init; }
    }
}
