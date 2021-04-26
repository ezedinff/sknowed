using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sknowed.Core.Entities.Course
{
    public class CourseChapter
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public Course Course { get; set; }
    }
}
