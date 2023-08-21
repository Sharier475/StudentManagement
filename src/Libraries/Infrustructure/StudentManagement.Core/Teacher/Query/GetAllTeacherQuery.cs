using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Teacher.Query;

public  record GetAllTeacherQuery() : IRequest<IEnumerable<VmTeacher>>;

public class GetAllTeacherQueryHandler : IRequestHandler<GetAllTeacherQuery, IEnumerable<VmTeacher>>
{
    private readonly ITeacherRepository _teacherRepository;
    public GetAllTeacherQueryHandler(ITeacherRepository teacherRepository, IMapper mapper)
    {
        _teacherRepository = teacherRepository;
    }

    public async Task<IEnumerable<VmTeacher>> Handle(GetAllTeacherQuery request, CancellationToken cancellationToken)
    {
        var result = await _teacherRepository.GetAll();
        return result;
    }
}