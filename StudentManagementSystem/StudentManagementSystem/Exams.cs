using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentManagementSystem
{
   public class Exams
    {
        public Dictionary<int,Admissions> al=Admissions.admissionslist;
        public static Dictionary<int,Exams> examlist = new Dictionary<int, Exams>();
        public int StudentId, numberofsubjects;
        public float[] marks;
        public float total;
        public void GetExams(int studentId)
        {
            total = 0;
            StudentId = studentId;
            Console.Write($"Enter number of subjects held for Student Id {StudentId} ");
            numberofsubjects = int.Parse(Console.ReadLine());
            marks = new float[numberofsubjects];
            for(int i = 0; i < numberofsubjects; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: " );
                marks[0] = float.Parse(Console.ReadLine());
                total += marks[0];
            }
            examlist[StudentId]=new Exams(StudentId,total);
        }

        public Exams()
        {
            
        }

        public Exams(int studentId, float total)
        {
            StudentId = studentId;
            this.total = total;    
        }
       
        public void UpdateAll()
        {
            if (al.Count == 0)
                Console.WriteLine("No Contents Available");
            else
            {
                foreach (var i in al)
                    
                    GetExams(i.Key); 
                
            }
        }
        public void RemoveById(int id)
        {
           // int flag = 0;
            try
            {
                if (examlist.ContainsKey(id)) {
                    examlist.Remove(id);
                    Console.WriteLine($"Contents with student id {id} is deleted in portal");
                }  
                else
                    throw new ManageException("Student details not in Portal");
            }
            catch (ManageException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

        public void display()
        {
            foreach (var i in examlist)
                Console.WriteLine(i.Value);
        }

        public override string ToString()
        {
            return $"studentid = {StudentId}  has a total of {total}";
        }

        internal void Update(int rid)
        {
            if (al.Count == 0)
                Console.WriteLine("No Contents Available");
            else
            {
                if (al.ContainsKey(rid))
                    GetExams(rid);
                else
                {
                    Console.WriteLine("Student is not in Portal");
                }
            }
        }
    }
}