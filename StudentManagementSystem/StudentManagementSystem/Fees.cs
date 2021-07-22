using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Fees
    {
        public const int totalfees = 15000;
        public int StudentId, feespaid, feesremaining;
        public Dictionary<int, Admissions> al = Admissions.admissionslist;
        public string name;
        public Fees() { }

        public Fees(int studentid, string name, int x, int y)
        {
            StudentId = studentid;
            this.name = name;
           feespaid = x;
            feesremaining = y;
        }

        public Dictionary<int, Fees> feeslist = new Dictionary<int, Fees>();
        private int x;
        private int y;

        public void GetFees(int studentid,string Name)
        {
            Console.WriteLine("Enter fees paid by " + Name);
            int x = int.Parse(Console.ReadLine());
            int y = totalfees - x;
            feeslist[studentid] = new Fees(studentid, Name, x, y);
        }
        internal void UpdateAll()
        {
            if (al.Count() == 0)
                Console.WriteLine("No Contents Available");
            else
            {
                foreach(var i in al)
                {
                    GetFees(i.Key, i.Value.StudentName);
                }
            }
        }
        internal void Update(int rid)
        {
            if (al.Count() == 0)
                Console.WriteLine("No Contents Available");
            else
            {
                if (al.ContainsKey(rid))
                    GetFees(rid,al[rid].StudentName);
            }
        }

        internal void RemoveById(int rid)
        {
            if (feeslist.ContainsKey(rid))
            {
                feeslist.Remove(rid);
                Console.WriteLine($"Contents with student id {rid} is deleted in portal");
            }
            else
            {
                Console.WriteLine("Student details not in Portal");
            }
        }

        internal void display()
        {
            foreach (var i in feeslist)
                Console.WriteLine(i.Value);
        }
        public override string ToString()
        {
            return $"studentid = {StudentId} name = {name} feespaid = {feespaid} feesreaining = {feesremaining}";
        }
    }
}
