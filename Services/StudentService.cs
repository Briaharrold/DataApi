
using DataApi.Data;
using DataApi.Models;

namespace DataApi.Services;
public class StudentService : IStudentService
{
    private readonly DataContext _dB;
    

    public StudentService(DataContext dB)
    {
        _dB = dB;
    }
    
     public List<Student> AddStudent(string studentName,string studentLastName, string studentHobby)
    {
        Student newStudent = new(); 
        newStudent.Name = studentName;
        newStudent.LastName = studentLastName;
        newStudent.Hobby = studentHobby;

        _dB.Students.Add(newStudent);
        _dB.SaveChanges(); 

        return _dB.Students.ToList();
    }

    public List<Student> DeleteStudent(string studentName)
    {
        var foundStudent = _dB.Students.FirstOrDefault(student => student.Name == studentName);
        if(foundStudent != null) {
            _dB.Students.Remove(foundStudent);
            _dB.SaveChanges();
        }
        return _dB.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _dB.Students.ToList();
    }

    public List<Student> UpdateStudent(string oldName, string newName)
    {
        var foundStudent = _dB.Students.FirstOrDefault(student => student.Name == oldName);
        if(foundStudent != null) {
            foundStudent.Name = newName;
            _dB.SaveChanges();
        }
        return _dB.Students.ToList();
    }

  
}