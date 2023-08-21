using StudentManagement.Model;
using StudentManagement.Services.Model;
using StudentManagement.Shared.CommonRepository;

namespace StudentManagement.Repositories.Interface
{
    public interface ITeacherRepository :IRepository<Teacher, VmTeacher,int>
    {

    }
}
