using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Teacher.Command;

public record DeleteTeacher(int Id):IRequest<VmTeacher>;
public class DeleteTeacherHandler : IRequestHandler<DeleteTeacher, VmTeacher>
{
    private readonly ITeacherRepository _teacherRepository;
    public DeleteTeacherHandler(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    public async Task<VmTeacher> Handle(DeleteTeacher request, CancellationToken cancellationToken)
    {
         await _teacherRepository.Delete(request.Id);
        return new VmTeacher();

    }
}

