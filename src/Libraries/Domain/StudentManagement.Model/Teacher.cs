using StudentManagement.Shared.Common;
using System.Text.Json.Serialization;

namespace StudentManagement.Model;

public class Teacher: BaseEntity , IEntity
{

    public string? TeacherName { get; set; }
    public double Salary { get; set; }
    public string? Department { get; set; }
    public int Id { get ; set ; }
    [JsonIgnore]
    public ICollection<Student> Students { get; set; }=new HashSet<Student>();


}
