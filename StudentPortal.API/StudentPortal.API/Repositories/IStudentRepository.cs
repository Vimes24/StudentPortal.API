using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudentPortal.API.DataModels;
using StudentPortal.API.DomainModels;

namespace StudentPortal.API.Repositories
{

    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);
        Task <List<Gender>> GetGenderAsync();
        Task<bool> Exists(Guid studentId);
        Task<Student> UpdateStudent(Guid studentId, Student request);
        Task<Student> DeleteStudent(Guid studentId);
        Task<Student> AddStudent(Student request);
        Task<bool> UpdateProfileImage(Guid studentId, string profileImageUri);
    }
}
