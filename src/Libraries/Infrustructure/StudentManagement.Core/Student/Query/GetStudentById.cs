using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Student.Query
{
    public  record  GetStudentById(int Id): IRequest<VmStudent>;
    public class GetStudentByHandler: IRequestHandler<GetStudentById, VmStudent>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<VmStudent> Handle(GetStudentById request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetById(request.Id);
        }
    }
}
