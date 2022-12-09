using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    public class Management:Student

        
    {
        public static void Main()
        {

           //Creating ArrayList of Student
           ArrayList listOfSubjects= new ArrayList();
            listOfSubjects.Add("Maths");
            listOfSubjects.Add("Science");
            listOfSubjects.Add("Social");
            listOfSubjects.Add("English");
            listOfSubjects.Add("Hindi");

            
            //Creating instance of Student Class
            Student s1 = new Student(1, "Aishu", "Hassan", 9, listOfSubjects,  001, "Maths", 100, 93, 002, "Science", 100, 91, 003,
                    "Social", 100, 88, 004, "English", 100, 85, 005, "Hindi", 100, 89);
            Student s2 = new Student(2, "Arya", "Mandya", 9, listOfSubjects, 001, "Maths", 100, 85, 002, "Science", 100, 93, 003,
                    "Social", 100, 97, 004, "English", 100, 90, 005, "Hindi", 100, 75);
            Student s3 = new Student(3, "John", "Bangalore", 9, listOfSubjects, 001, "Maths", 100, 80, 002, "Science", 100, 94, 003,
                    "Social", 100, 70, 004, "English", 100, 92, 005, "Hindi", 100, 80);
            Student s4 = new Student(4, "Geetha", "Mangalore", 9, listOfSubjects, 001, "Maths", 100, 75, 002, "Science", 100, 66, 003,
                    "Social", 100, 69, 004, "English", 100, 79, 005, "Hindi", 100, 90);
            Student s5 = new Student(listOfSubjects);

          

              while (true)
              {
                  Console.WriteLine("Enter the choice");
                  Console.WriteLine("1: AddStudentData ,2: getAllStudentData, 3: DeleteStudentData, 4:UpdateStudentData, 5:ReadData, 6:CorrectingStudentData,");

                  var choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        if (list.Count <= 0) { 
                        s1.AddStudentData(s1);//Adding Student s1 data
                        s1.AddStudentData(s2);// Adding Student s2 data
                        s1.AddStudentData(s3);//Adding Student s3 data
                        Console.WriteLine("Student Data Added Sucessfully!!!");
                        }
                        else
                        {
                            Console.WriteLine("Student Details Already added");
                        }

                        

                        break;

                      case 2:
                        if (list.Count > 0)
                        {
                            s1.getAllStudentData();//Getting all the student Data
                            Console.WriteLine("All Student Data Displayed Sucessfully!!!");
                        }
                        else
                        {
                         
                            Console.WriteLine("No Student Data in the list so Nothing will be displayed");
                            Console.WriteLine(" ");
                        }
                          break;

                      case 3:
                        if (list.Count > 0)
                        {
                            int Sid=s1.CheckId();

                           
                            s1.DeleteStudentData(Sid);//Deleting Student S2 Data
                            Console.WriteLine("Particular Student Data Delete Sucessfully!!!");
                                
                        }
                        else
                        {
                            Console.WriteLine("No Student Data in the list thus delete opertaion can't be perfored");
                            Console.WriteLine(" ");
                        }
                        break;

                    case 4:
                        bool Status = s1.CheckexitanceId();
                        if (Status == false)
                        {
                            s1.updateStudentData(s5);//Adds  the Data to list from Console allows user to Enter Data
                            Console.WriteLine("New Student Data Added Sucessfully by user input!!!");
                            
                        }
                        else
                        {
                            Console.WriteLine("studentData with this student Id already exist");
                        }
                        break;

                    case 5:
                        if (list.Count > 0)
                        {
                            int Sid = s1.CheckId();
                            s1.ReadData(Sid);//Displays a particular student details
                            Console.WriteLine("Particular Student Data Displaed Sucessfully!!!");
                        }
                        else
                        {
                            Console.WriteLine("No Student Data in the list thus Read opertaion can't be perfored");
                            Console.WriteLine(" ");
                        }
                        break;



                    case 6:
                        if (list.Count > 0)
                        {
                            try
                            {
                                Console.WriteLine("To update Student data which already exits, Enter index of it");
                                int Sid = int.Parse(Console.ReadLine());
                                if (Sid < list.Count)
                                {
                                    s1.CorrectingStudentData(Sid, "studentid", 39);//Updating student s1 studentId to 39 

                                    s1.CorrectingStudentData(Sid, "studentname", "Arjun");//Updating student s2 studentName to Arjun

                                    s1.CorrectingStudentData(Sid, "studentaddress", "Mysore");//Updating student s3 studentAdress to Mysore 
                                    Console.WriteLine("Student Data Updated Sucessfully!!!");
                                }
                                else
                                {
                                    Console.WriteLine("Wrong index!!");
                                }
                            }
                            catch(Exception e)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Student Data in the list thus update opertaion can't be perfored");
                            Console.WriteLine(" ");
                        }
                        break;
                       
                        

                   
                       
                        

                    
                  

                }

              }
            




        }
    }
}
