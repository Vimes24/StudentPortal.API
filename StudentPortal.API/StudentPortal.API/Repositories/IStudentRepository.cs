using System.Collections.Generic;
using System.Threading.Tasks;
using StudentPortal.API.DataModels;

namespace StudentPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
