using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD10.Data
{
    public class StudentService : IStudentService
    {

        private List<Student> _students;
        public StudentService(){

            _students=new List<Student>{
                new Student{
                    IdStudent=1,
                    Name="Jan",
                    LastName="Kowalski",
                    BirthDate=new System.DateTime(2001,12,12),
                    Studies="Computer Science",
                    Avatar="https://cdn-icons-png.flaticon.com/512/147/147142.png"
                },
                    new Student{
                    IdStudent=2,
                    Name="Henryk",
                    LastName="Sienkiwesz",
                    BirthDate=new System.DateTime(1990,12,12),
                    Studies="Computer Science",
                    Avatar="https://cdn-icons-png.flaticon.com/512/147/147142.png"
                },
                                new Student{
                    IdStudent=5,
                    Name="Jakub",
                    LastName="Jakubowski",
                    BirthDate=new System.DateTime(1998,01,01),
                    Studies="Media",
                    Avatar="https://cdn-icons-png.flaticon.com/512/147/147142.png"
                },
                                new Student{
                    IdStudent=8,
                    Name="Joanna",
                    LastName="Jakubczyk",
                    BirthDate=new System.DateTime(2002,06,10),
                    Studies="Economy",
                    Avatar="https://cdn5.vectorstock.com/i/1000x1000/01/69/businesswoman-character-avatar-icon-vector-12800169.jpg"
                }


            };
        }
        public List<Student> GetStudents(){
            return _students;
        }
        public Student GetStudent(int id){
            return _students.FirstOrDefault(e=> e.IdStudent==id);

        }
        public bool Remove(int id){
            return _students.Remove(_students.FirstOrDefault(e => e.IdStudent == id));
        }
    }
}