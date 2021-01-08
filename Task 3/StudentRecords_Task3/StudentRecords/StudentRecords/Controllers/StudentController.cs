using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentRecords.Models;

namespace StudentRecords.Controllers
{
    public class StudentController : ApiController
    {
        Student[] st = new Student[]{
            new Student{ID=1, Name="Rajeev Ranjan",Address="pune", Class="IX", PercentageMarks=87},
            new Student{ID=2, Name="Manish Shrivastava",Address="pune", Class="IX", PercentageMarks=88},
            new Student{ID=3, Name="Chandan Singh",Address="Ranchi", Class="IX", PercentageMarks=99},
            new Student{ID=4, Name="Manish Singh",Address="Ranchi", Class="IX", PercentageMarks=85},
            new Student{ID=5, Name="Rohit",Address="New Delhi", Class="IX", PercentageMarks=79},
            new Student{ID=6, Name="Kunal",Address="New Delhi", Class="IX", PercentageMarks=64},
            new Student{ID=7, Name="Thomas Minz",Address="Hazaribagh", Class="IX", PercentageMarks=33},
            new Student{ID=8, Name="Santosh",Address="pune", Class="IX", PercentageMarks=56},
            new Student{ID=9, Name="Amrut Gholkhar",Address="Aurangabad", Class="IX", PercentageMarks=82},
            new Student{ID=10, Name="Gaurav Lahe",Address="Amrawati", Class="IX", PercentageMarks=98},
        };

        [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/students")]
        public IEnumerable<Student> GetAllStudent()
        {
            return st;
        }
        [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/students/{id:int}")]
        public IHttpActionResult GetStudents(int id)
        {
            var stud = st.FirstOrDefault((s) => s.ID == id);
            if (stud == null)
            {
                return NotFound();
            }
            return Ok(stud);
        }
    }
}


