using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services.interfaces
{
    public interface IStudents
    {
        Task<string> GetStudentList();
        Task<List<Students>> StudentList();
    }
}
