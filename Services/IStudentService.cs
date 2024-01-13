using DataApi.Models;

namespace DataApi.Services;
public interface IStudentService
    {
        List<Student> AddStudent(string studentName,string studentLastName, string studentHobby);
        List<Student> DeleteStudent(string studentName);
        List<Student> GetStudents();
        List<Student> UpdateStudent(string oldName, string newName);
    }
