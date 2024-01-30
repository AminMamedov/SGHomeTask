namespace groupStudent.CORE.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public ICollection<StudentGroup> StudentGroups;
}
