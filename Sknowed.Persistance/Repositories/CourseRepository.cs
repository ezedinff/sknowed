using Sknowed.Application.Contracts.Persistance;
using Sknowed.Core.Entities.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sknowed.Persistance.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(SknowedDbContext context) : base(context) { }
    }
}
