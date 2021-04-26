using AutoMapper;
using MediatR;
using Sknowed.Application.Contracts.Persistance;
using Sknowed.Application.Exceptions;
using Sknowed.Core.Entities.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sknowed.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CreateCourseCommandHandler(
            ICourseRepository courseRepository,
            IMapper mapper
        )
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }
        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateCourseCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

            var @course = _mapper.Map<Course>(request);
            @course = await _courseRepository.AddAsync(@course);
            return @course.Id;
        }
    }
}
