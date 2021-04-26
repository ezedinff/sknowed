using Sknowed.Core.Entities.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sknowed.Application.Contracts.Persistance
{
    public interface ICourseRepository : IAsyncRepository<Course>
    {
    }
}
