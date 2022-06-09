using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using StudentPortal.API.DataModels;
using System.Threading.Tasks;
using System;

namespace StudentPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentContext context;

        public SqlStudentRepository(StudentContext context)
        {
            this.context = context;
        }

        

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
        
        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x => x.Id == studentId);
        }
    }
}
