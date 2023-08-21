using AutoMapper;
using StudentManagement.Infrustructure;
using StudentManagement.Model;
using StudentManagement.Repositories.Interface;
using StudentManagement.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Repositories.Base
{
    public class TeacherRepository :RepositoryBase<Teacher, VmTeacher,int>,ITeacherRepository
    {
        public TeacherRepository(IMapper mapper, StudentManagementDbContext dbContext):base (mapper, dbContext) { }

    }
}
