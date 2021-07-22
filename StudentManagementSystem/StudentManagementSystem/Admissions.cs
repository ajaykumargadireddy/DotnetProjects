using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Admissions
    {
        public static Dictionary<int, Admissions> admissionslist=new Dictionary<int, Admissions>();
         
        public static int AdmissionSequence = 101;
        public static int StudentIdSequnce = 1000;
        public int AdmissionId,StudentId,Class ;
        public string StudentName;

        public Admissions(int admissionId, int studentId, string studentName, int Class)
        {
            AdmissionId = admissionId;
            StudentId = studentId;
            StudentName = studentName;
            this.Class = Class;
        }

        public Admissions()
        {
        }

        public void GeTAdmissions()
        {
            AdmissionId = AdmissionSequence++;
            StudentId = StudentIdSequnce++;
            Console.Write($"Enter Student Name for StudentId {StudentId} = ");
            StudentName = Console.ReadLine();
            Console.Write($"Enter Class Enrolling for {StudentId} = ");
            Class = int.Parse(Console.ReadLine());
            admissionslist.Add(StudentId,new Admissions(AdmissionId, StudentId, StudentName, Class));
        }
        public void RemoveById(int id)
        {
            try
            {
                if (admissionslist.ContainsKey(id))
                {
                    Console.WriteLine($"Contents with student id {id} is deleted in portal");
                    admissionslist.Remove(id);
                }
                    
                else
                    throw new ManageException("Student Details Not in portal");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void display()
        {
            if (admissionslist.Count() == 0)
                Console.WriteLine("No Contents Available");
            else
            {
                foreach (var i in admissionslist)
                    Console.WriteLine(i.Value);
            }
        }
        public override string ToString()
        {
            return $"AdmissionId = {AdmissionId}  studentid = {StudentId}  studentname = {StudentName} Class = {Class}";
        }
    }
}
