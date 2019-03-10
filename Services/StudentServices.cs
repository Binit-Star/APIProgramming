using System;
using Services.interfaces;
using Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Services
{
    public class StudentServices : IStudents
    {
        public async Task<string> GetStudentList()
        {
            return "Hello World!!";
        }

        public async Task<List<Students>> StudentList()
        {
            List<Students> lstStudents = new List<Students>();
            int i = 1;
            while (i < 10)
            {
                lstStudents.Add(new Students() { Sno = i,Name="Binit",Class="Seven",ContactNo=9874563210,Roll="7" });
                i++;
            }

            return lstStudents;
        }
    }
}
