using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;

namespace StudentManagement.Core.Student.Query
{
    public record GetAllStudentQuery():IRequest<IEnumerable<VmStudent>>;
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, IEnumerable<VmStudent>>
    {
        private readonly IStudentRepository _Studentrepository;

        public GetAllStudentQueryHandler(IStudentRepository studentRepository)
        {
            _Studentrepository = studentRepository; 
        }

        public async Task<IEnumerable<VmStudent>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var result = await _Studentrepository.GetAll();
            return result;
        }
    }
    
}
