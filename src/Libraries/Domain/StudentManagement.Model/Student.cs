using StudentManagement.Shared.Common;

namespace StudentManagement.Model;

public class Student : BaseEntity, IEntity
{
    public string? StudentName { get; set; }
    public double AdmissionFee { get; set; }
    public string? CourseNamme { get; set; }
    public int Id { get; set; }
}
