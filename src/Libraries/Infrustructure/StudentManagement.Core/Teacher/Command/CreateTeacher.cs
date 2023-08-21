using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Teacher.Command
{
    public record class CreateTeacher(VmTeacher VmTeacher) : IRequest<VmTeacher>;
    public class CreateTeacherHandler: IRequestHandler<CreateTeacher, VmTeacher>
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;
        public CreateTeacherHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<VmTeacher> Handle(CreateTeacher request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<Model.Teacher>(request.VmTeacher);
            return await _teacherRepository.Add(data);
        }
    }

}
