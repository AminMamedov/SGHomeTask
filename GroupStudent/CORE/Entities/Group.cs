namespace groupStudent.CORE.Entities;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }

    public int MaxStudentCount { get; set; }
    public ICollection<StudentGroup> StudentGroups;
}







    