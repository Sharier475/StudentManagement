using StudentManagement.Model;
using StudentManagement.Services.Model;
using StudentManagement.Shared.CommonRepository;

namespace StudentManagement.Repositories.Interface;

public interface IStudentRepository : IRepository<Student,VmStudent,int>
{
}
