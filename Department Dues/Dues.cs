using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
//The function of this program is to calculate the total amount of dues collected from each department in a faculty.
//This is necessary for accountability of the executives.
*/
namespace Department_Dues

{

    /// <summary>
    /// Abstract class which is the base class
    /// This is the class that is extended by other classes
    /// </summary>
    public abstract class DeptDues
    {
        public int BasicDues { get; set; }
        public int NoOfStudents { get; set; }
        public abstract double TotalDeptDues();
    }
    
    
    /// <summary>
    /// Calculates total dues in the faculty
    /// </summary>
    public class TotalDuesInFaculty
    {
        public double TotalDuesFac(List<double> deptDues)
        {
            double amount=0;
            foreach(var deptDue in deptDues)
            {
                amount+= deptDue;
            }

            return amount;
        }
    }

    //Derived class, derived from the base class DeptDues
    /// <summary>
    ///  Derived from the base class DeptDues
    ///  calculates total dues in department of computer science
    /// </summary>
    public class CompScience:DeptDues
    {
        public int DinnerFee { get; set; }
        public int GeneratedRevenues { get; set; }
        public override double TotalDeptDues()
        {
            double totalDeptDues = ((BasicDues + DinnerFee) * NoOfStudents) + GeneratedRevenues;
            return totalDeptDues;
        }

    }

    
    /// <summary>
    ///  Derived from the base class DeptDues
    /// calculates total dues in department of geology
    /// </summary>
    public class Geology : DeptDues
    {
        
        public int GeneratedRevenues { get; set; }
        public int Excursion { get; set; }
        public override double TotalDeptDues()
        {
            double totalDeptDues = ((BasicDues + Excursion) * NoOfStudents) + GeneratedRevenues;
            return totalDeptDues;
        }

    }
}
