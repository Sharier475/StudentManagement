using StudentManagement.Shared.Common;
using System.Text.Json.Serialization;

namespace StudentManagement.Model;

public class Student : BaseEntity, IEntity
{
    public string? StudentName { get; set; }
    public double AdmissionFee { get; set; }
    public string? CourseNamme { get; set; }
    public int Id { get; set; }
    public int TeacherId { get; set; }
    [JsonIgnore]

    public Teacher? Teacher { get; set; }
}
