using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterClassLibrary
{
    public class Class1
    {
    }
 
  
   
    public class Calculate
    {
        public  int CalcHoursPerWeek(int credits, int weeks, int classHrs)
        {

            // calculates how many required study hours per week
            int HrsPerWeek;
            HrsPerWeek = (int)Math.Round(((double)(credits * 10) / weeks) - classHrs, MidpointRounding.AwayFromZero);
            return HrsPerWeek;
        }
        public int currentWeek(DateTime startDate)
        {
            //calculates current week of semester
            int currentWeek;
            currentWeek = (int)Math.Ceiling(((DateTime.Now - startDate).TotalDays + 1) / 7);
            return currentWeek;
        }
        public  int workWeek(DateTime workDate, DateTime startDate)
        {
            // calculates the week in which work was done
            int workWeek;
            workWeek = (int)Math.Ceiling(((workDate - startDate).TotalDays + 1) / 7);
            return workWeek;
        }  
    }
}
