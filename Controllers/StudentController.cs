using DataApi.Models;
using DataApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        [Route("FetchQuest")]
        public List<Student> GetStudents()
    {
        // Accessing the GetStudents() from our Interface
        return _studentService.GetStudents();
    }
    [HttpPost] // use Post to add Data
    [Route("AddStudent/{studentName}/{studentLastName}/{studentHobby}")] // To pass data through Routes add /{parameter name}
    public List<Student> AddStudent(string studentName,string studentLastName, string studentHobby)
    {
        return _studentService.AddStudent(studentName,studentLastName,studentHobby);
    }

    [HttpDelete] // use Delete to delete data - not really don't do this
    [Route("DeleteStudent/{studentName}")]
    public List<Student> DeleteStudent(string studentName)
    {
        return _studentService.DeleteStudent(studentName);
    }

    [HttpPut] // use Put to update data
    [Route("EditStudent/{oldName}/{newName}")]
    public List<Student> UpdateStudent(string oldName, string newName)
    {
        return _studentService.UpdateStudent(oldName, newName);
    }

    }
}