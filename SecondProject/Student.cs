using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SecondProject
{

    //Creating a ArrayList for studentData
    public class Student : Subject
    {
        //Student Class Variable declaration
        public int studentID;
        public String studentName;
        public String studentAddress;
        public int studentClass;
        public String Maths;
        public String Science;
        public String Social;
        public String English;
        public String Hindi;


        //Creating constructor of StudentClass

        public Student()
        {

        }

        public Student(ArrayList ListOfSubject)
        {
            this.Maths = ((string)ListOfSubject[0]);
            this.Science = ((string)ListOfSubject[1]);
            this.Social = ((string)ListOfSubject[2]);
            this.English = ((string)ListOfSubject[3]);
            this.Hindi = ((string)ListOfSubject[4]);
        }
        public Student(int studentID, String studentName, String studentAddress, int studentClass, ArrayList ListOfSubject, int subjectID1, String subjectName1, int subjectMaxMarks1, int subjectMarksObtained1, int subjectID2, String subjectName2, int subjectMaxMarks2, int subjectMarksObtained2, int subjectID3, String subjectName3, int subjectMaxMarks3, int subjectMarksObtained3, int subjectID4, String subjectName4, int subjectMaxMarks4, int subjectMarksObtained4, int subjectID5, String subjectName5, int subjectMaxMarks5, int subjectMarksObtained5)
        {

            this.studentID = studentID;
            this.studentName = studentName;
            this.studentAddress = studentAddress;
            this.studentClass = studentClass;
            base.subjectID1 = subjectID1;
            base.subjectName1 = subjectName1;
            base.subjectMaxMarks1 = subjectMaxMarks1;
            base.subjectMarksObtained1 = subjectMarksObtained1;
            base.subjectID2 = subjectID2;
            base.subjectName2 = subjectName2;
            base.subjectMaxMarks2 = subjectMaxMarks2;
            base.subjectMarksObtained2 = subjectMarksObtained2;
            base.subjectID3 = subjectID3;
            base.subjectName3 = subjectName3;
            base.subjectMaxMarks3 = subjectMaxMarks3;
            base.subjectMarksObtained3 = subjectMarksObtained3;
            base.subjectID4 = subjectID4;
            base.subjectName4 = subjectName4;
            base.subjectMaxMarks4 = subjectMaxMarks4;
            base.subjectMarksObtained4 = subjectMarksObtained4;
            base.subjectID5 = subjectID5;
            base.subjectName5 = subjectName5;
            base.subjectMaxMarks5 = subjectMaxMarks5;
            base.subjectMarksObtained5 = subjectMarksObtained5;




            this.Maths = ((string)ListOfSubject[0]);
            this.Science = ((string)ListOfSubject[1]);
            this.Social = ((string)ListOfSubject[2]);
            this.English = ((string)ListOfSubject[3]);
            this.Hindi = ((string)ListOfSubject[4]);


        }

        //Using Indexer- to upadte values with the help of index
        public object this[string name]
        {

            set {
                if (name == "studentid")
                    studentID = (int)value;
                else if (name == "studentname")
                    studentName = (String)value;
                else if (name == "studentaddress")
                    studentAddress = (String)value;
                else if (name == "studentclass")
                    studentClass = (int)value;
                else if (name == "subjecttid1")
                    subjectID1 = (int)value;
                else if (name == "subjectname1")
                    subjectName1 = (String)value;
                else if (name == "studentmaxmarks1")
                    subjectMaxMarks1 = (int)value;
                else if (name == "studentmarksobtained1")
                    subjectMarksObtained1 = (int)value;
                else if (name == "subjecttid2")
                    subjectID2 = (int)value;
                else if (name == "subjectname2")
                    subjectName2 = (String)value;
                else if (name == "studentmaxmarks2")
                    subjectMaxMarks2 = (int)value;
                else if (name == "studentmarksobtained2")
                    subjectMarksObtained2 = (int)value;
                else if (name == "subjecttid3")
                    subjectID3 = (int)value;
                else if (name == "subjectname3")
                    subjectName3 = (String)value;
                else if (name == "studentmaxmarks3")
                    subjectMaxMarks3 = (int)value;
                else if (name == "studentmarksobtained3")
                    subjectMarksObtained3 = (int)value;
                else if (name == "subjecttid4")
                    subjectID4 = (int)value;
                else if (name == "subjectname4")
                    subjectName4 = (String)value;
                else if (name == "studentmaxmarks4")
                    subjectMaxMarks4 = (int)value;
                else if (name == "studentmarksobtained4")
                    subjectMarksObtained4 = (int)value;
                else if (name == "subjecttid5")
                    subjectID5 = (int)value;
                else if (name == "subjectname5")
                    subjectName5 = (String)value;
                else if (name == "studentmaxmarks5")
                    subjectMaxMarks5 = (int)value;
                else if (name == "studentmarksobtained5")
                    subjectMarksObtained5 = (int)value;




            }

        }


        public static List<Student> list = new List<Student>();



        public void AddStudentData(Student s1)//adding Student details to list

        {

            list.Add(s1);

        }

        public void getAllStudentData()//Getting all the student Data
        {
            for (int i = 0; i < list.Count; i++)
            {

                var s = ((Student)list[i]);
                Console.WriteLine("StudentId: " + s.studentID + "  StudentName: " + s.studentName + "  StudentAddress: " + s.studentAddress + "  StudentClass: " + s.studentClass + " ListOfSubjects: " + s.Maths + " " + s.Science + " " + s.Social + " " + s.English + " " + s.Hindi);
                Console.WriteLine(s.subjectID1 + " " + s.subjectName1 + "    " + s.subjectMaxMarks1 + "    " + s.subjectMarksObtained1 + "\n" + s.subjectID2 + " " + s.subjectName2 + "  " + s.subjectMaxMarks2 + "    " + s.subjectMarksObtained2 + "\n" + s.subjectID3 + " " + s.subjectName3 + "   " + s.subjectMaxMarks3 + "    " + s.subjectMarksObtained3 + "\n" + s.subjectID4 + " " + s.subjectName4 + "  " + s.subjectMaxMarks4 + "    " + s.subjectMarksObtained4 + "\n" + s.subjectID5 + " " + s.subjectName5 + "    " + s.subjectMaxMarks5 + "    " + s.subjectMarksObtained5);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------->");

            }
        }

        public void DeleteStudentData(int studentid)//Deleting PArticular studentData
        {


            IEnumerable<int> s = from stud in list
                                 where stud.studentID == studentid
                                 select list.IndexOf(stud);
            list.RemoveAt(s.FirstOrDefault());


        }

        public void CorrectingStudentData(int studentid, String name, object value)//Updating StudentData


        {

            Student s = (Student)list[studentid];
            s[name] = value;


        }


        public void ReadData(int studentid)//Getting all the student Data
        {


            var st = from stud in list
                     where stud.studentID == studentid
                     select stud;

            foreach (var s in st)
            {
                Console.WriteLine("StudentId: " + s.studentID + "  StudentName: " + s.studentName + "  StudentAddress: " + s.studentAddress + "  StudentClass: " + s.studentClass + " ListOfSubjects: " + s.Maths + " " + s.Science + " " + s.Social + " " + s.English + " " + s.Hindi);
                Console.WriteLine(s.subjectID1 + " " + s.subjectName1 + "    " + s.subjectMaxMarks1 + "    " + s.subjectMarksObtained1 + "\n" + s.subjectID2 + " " + s.subjectName2 + "  " + s.subjectMaxMarks2 + "    " + s.subjectMarksObtained2 + "\n" + s.subjectID3 + " " + s.subjectName3 + "   " + s.subjectMaxMarks3 + "    " + s.subjectMarksObtained3 + "\n" + s.subjectID4 + " " + s.subjectName4 + "  " + s.subjectMaxMarks4 + "    " + s.subjectMarksObtained4 + "\n" + s.subjectID5 + " " + s.subjectName5 + "    " + s.subjectMaxMarks5 + "    " + s.subjectMarksObtained5);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------->");

            }

        }






        public void updateStudentData(Student s1)//Reading Student Data from console
        {
            try
            {
                Console.WriteLine("Enter studentId:");
                s1.studentID = int.Parse(Console.ReadLine());



                Console.WriteLine("Enter studentName:");
                s1.studentName = Console.ReadLine();
                while (!s1.studentName.All(Char.IsLetter))
                {
                    Console.WriteLine("StudentName should contain letters  ,Number are not allowed");
                    s1.studentName = Console.ReadLine();
                }
                Console.WriteLine("Enter studentAddress:");
                s1.studentAddress = Console.ReadLine();
                while (!s1.studentAddress.All(Char.IsLetter))
                {
                    Console.WriteLine("StudentAddress should contain letters  ,Number are not allowed");
                    s1.studentAddress = Console.ReadLine();
                }

                Console.WriteLine("Enter studentClass:");
                s1.studentClass = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter SubjectId1:");
                s1.subjectID1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubjectName1:");
                s1.subjectName1 = Console.ReadLine();
                while (!s1.subjectName1.All(Char.IsLetter))
                {
                    Console.WriteLine("SubjectName should contain letters  ,Number are not allowed");
                    s1.subjectName1 = Console.ReadLine();
                }
                Console.WriteLine("Enter SubjectMaxMarks1:");
                s1.subjectMaxMarks1 = int.Parse(Console.ReadLine());
                while (s1.subjectMaxMarks1 != 100)
                {
                    Console.WriteLine("Max Marks should be 100");
                    s1.subjectMaxMarks1 = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter SubjectmarksObtained1:");
                s1.subjectMarksObtained1 = int.Parse(Console.ReadLine());
                while (s1.subjectMarksObtained1 > 100)
                {
                    Console.WriteLine("Marks entered should be less than 100");
                    s1.subjectMarksObtained1 = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("Enter SubjectId2:");
                s1.subjectID2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubjectName2:");
                s1.subjectName2 = Console.ReadLine();

                while (!s1.subjectName2.All(Char.IsLetter))
                {
                    Console.WriteLine("SubjectName should contain letters  ,Number are not allowed");
                    s1.subjectName2 = Console.ReadLine();
                }
                Console.WriteLine("Enter SubjectMaxMarks2:");
                s1.subjectMaxMarks2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubjectmarksObtained2:");
                while (s1.subjectMaxMarks2 != 100)
                {
                    Console.WriteLine("Max Marks should be 100");
                    s1.subjectMaxMarks2 = int.Parse(Console.ReadLine());
                }
                s1.subjectMarksObtained2 = int.Parse(Console.ReadLine());
                while (s1.subjectMarksObtained2 > 100)
                {
                    Console.WriteLine("Marks entered should be less than 100");
                    s1.subjectMarksObtained2 = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("Enter SubjectId3:");
                s1.subjectID3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubjectName3:");
                s1.subjectName3 = Console.ReadLine();
                while (!s1.subjectName3.All(Char.IsLetter))
                {
                    Console.WriteLine("SubjectName should contain letters  ,Number are not allowed");
                    s1.subjectName3 = Console.ReadLine();
                }
                Console.WriteLine("Enter SubjectMaxMarks3:");
                s1.subjectMaxMarks3 = int.Parse(Console.ReadLine());
                while (s1.subjectMaxMarks3 != 100)
                {
                    Console.WriteLine("Max Marks should be 100");
                    s1.subjectMaxMarks3 = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter SubjectmarksObtained3:");
                s1.subjectMarksObtained3 = int.Parse(Console.ReadLine());
                while (s1.subjectMarksObtained3 > 100)
                {
                    Console.WriteLine("Marks entered should be less than 100");
                    s1.subjectMarksObtained3 = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("Enter SubjectId4:");
                s1.subjectID4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubjectName4:");
                s1.subjectName4 = Console.ReadLine();
                while (!s1.subjectName4.All(Char.IsLetter))
                {
                    Console.WriteLine("SubjectName should contain letters ,Number are not allowed");
                    s1.subjectName4 = Console.ReadLine();
                }

                Console.WriteLine("Enter SubjectMaxMarks4:");
                s1.subjectMaxMarks4 = int.Parse(Console.ReadLine());
                while (s1.subjectMaxMarks4 != 100)
                {
                    Console.WriteLine("Max Marks should be 100");
                    s1.subjectMaxMarks4 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter SubjectmarksObtained4:");
                s1.subjectMarksObtained4 = int.Parse(Console.ReadLine());
                while (s1.subjectMarksObtained4 > 100)
                {
                    Console.WriteLine("Marks entered should be less than 100");
                    s1.subjectMarksObtained4 = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("Enter SubjectId5:");
                s1.subjectID5 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubjectName5:");
                s1.subjectName5 = Console.ReadLine();
                while (!s1.subjectName5.All(Char.IsLetter))
                {
                    Console.WriteLine("SubjectName should contain letters ,Number are not allowed");
                    s1.subjectName5 = Console.ReadLine();
                }
                Console.WriteLine("Enter SubjectMaxMarks5:");
                s1.subjectMaxMarks5 = int.Parse(Console.ReadLine());
                while (s1.subjectMaxMarks5 != 100)
                {
                    Console.WriteLine("Max Marks should be 100");
                    s1.subjectMaxMarks5 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter SubjectmarksObtained5:");
                s1.subjectMarksObtained5 = int.Parse(Console.ReadLine());
                while (s1.subjectMarksObtained5 > 100)
                {
                    Console.WriteLine("Marks entered should be less than 100");
                    s1.subjectMarksObtained5 = int.Parse(Console.ReadLine());
                }

                list.Add(s1);
            }
            catch (Exception e) { Console.WriteLine(e.Message);
            }
        }


        public bool CheckexitanceId()
        {
            Console.WriteLine("Enter Student Id:");
            int studentid = int.Parse(Console.ReadLine());
            bool Status = (from s in list
                           where s.studentID == studentid
                           select s).Any();

            if (Status == true)
                return true;
            return false;
        }

            public int CheckId()
            {
                Console.WriteLine("Enter Student Id:");
                int studentid = int.Parse(Console.ReadLine());
                bool Status = (from s in list
                               where s.studentID == studentid
                               select s).Any();
                int studentid2 = 0;
                if (Status == true)
                    return studentid;
                else

                    Console.WriteLine("StudentId Entered doesn't exit in the list,  Enter Correct student id:  ");
                while (Status == false)
                {
                    studentid2 = CheckId();
                    break;
                }
                return studentid2;







            }







    }
}
