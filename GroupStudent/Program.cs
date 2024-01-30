// See https://aka.ms/new-console-template for more information
using groupStudent.CORE.Entities;
using groupStudent.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Group student home task");
GCcontext context = new GCcontext();

#region CreateStudent
//Student student = new()
//{
//    Name = "amin",
//    Surname = "Mamedov",
//    Age = 19

//};
//context.Students.Add(student);
//context.SaveChanges();
#endregion

#region CreateGroup
int StudentCount = 0;
Student? st = await context.Students.FindAsync(2);
Student? st1 = await context.Students.FindAsync(3);
Student? st2= await context.Students.FindAsync(4);
Student? st3= await context.Students.FindAsync(5);

if (st is not null)
{
    Group group = new();
    Group g = await context.Groups.FindAsync(group.Name);
    if (g is not null)
    {
        StudentGroup studentGroup = new()
        {
            StudentID = st.Id,
            GroupId = g.Id


        };
    }
    {
        group.Name = "P203";
        group.Description = "FullStack";
        group.CreatedDate = DateTime.Now;
        group.MaxStudentCount = 3;
        if (StudentCount < group.MaxStudentCount)
        {
            StudentCount = StudentCount + 1;

            StudentGroup studentGroup = new()
            {
                StudentID = st.Id,
                GroupId = group.Id

            };
            
            //List<StudentGroup> SG = new List<StudentGroup>();
            //SG.Add(studentGroup);
            //group.StudentGroups = studentGroup;

            List<StudentGroup> sg = new List<StudentGroup>();
            sg.Add(studentGroup);
            group.StudentGroups = sg;
            await context.Groups.AddAsync(group);
            //context.StudentGroups.Add(sg);
            await context.SaveChangesAsync();
        }
        else
        {
            Console.WriteLine($"Student count can not be more than {group.MaxStudentCount}!!!");
        }

    };



}
#endregion


#region UPdateMethod
//StudentGroup studentGroup = await context.StudentGroups.FindAsync(x=>x.)
//Student student = await context.Students.FindAsync(1);
//if(student is not null)
//{

//    Group newgroup = await context.Groups.FindAsync(1);
//    if(newgroup is not null)
//    {

//    }
//}



#endregion

