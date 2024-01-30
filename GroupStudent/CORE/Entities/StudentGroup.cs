namespace groupStudent.CORE.Entities;

public class StudentGroup
{
    
    public int StudentID { get; set; } 
    public int GroupId { get; set; } 
    public Student Student { get; set; }
    public Group Group { get; set; }
}
