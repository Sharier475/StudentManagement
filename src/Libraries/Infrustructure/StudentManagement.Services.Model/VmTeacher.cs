using StudentManagement.Shared.Common;
using System.Text.Json.Serialization;

namespace StudentManagement.Services.Model;

public class VmTeacher : IVm
{
    public int Id { get ; set ; }
    public string? TeacherName { get; set; }
    public double Salary { get; set; }
    public string? Department { get; set; }
    [JsonIgnore]
    public ICollection<VmStudent> Students { get; set; } = new List<VmStudent>();
}
