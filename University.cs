using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_25._02._2025
{
    internal class University
    {
        List<Student> students;//sorted
        public University(List<Student> students)
        {
            this.students = students;
        }
        public string FindStudentByScore(int score)
        {
            int left = 0;
            int right = this.students.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (students[mid].Score == score)
                {
                    return students[mid].Name;
                }
                else if (students[mid].Score < score)
                {
                    
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return "Not found";
        }
    }
}
