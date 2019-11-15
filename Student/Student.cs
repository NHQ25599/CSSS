using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public int StudentID { get; private set; }

        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Number Of Student: ");
                //ctrl + k + c: cmt
                //ctrl + k + u: uncmt
                //ctrl + k + d: format code
                int numOfStudent;
                try
                {
                    numOfStudent = int.Parse(Console.ReadLine());
                    InputStudentList(numOfStudent);
                }
                catch (Exception ex)
                {
                    Console.Write("Invalid Input!");
                    throw;
                }
                //dung man hinh de xem ket qua
                Console.ReadKey();
            }
            private static void InputStudentList(int numOfStudent)
            {
                //tao mang danh sach sinh vien
                Student[] studentList = new Student[numOfStudent];
                Student student;
                for (int i = 0; i < numOfStudent; i++)
                {
                    student = new Student();
                    Console.Write("ID = ");
                    student.StudentID = int.Parse(Console.ReadLine());
                    //tuong tu
                    //dua doi tuong vao mang
                    studentList[i] = student;
                }
            }
        }
    }
}
