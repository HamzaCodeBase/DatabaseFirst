using TestMVC.Net.Models;

namespace TestMVC.Net.Services
{
    public class StudentService
    {
        public void CreateStudent(Student student)
        {
            DatabaseFirstDemoEntities db = new DatabaseFirstDemoEntities();
            if(student == null)
            {
                db.Students.Add(student);
            }
        }

    }
}