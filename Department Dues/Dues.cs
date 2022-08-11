using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
//The function of this program is to calculate the total amount of dues collected from each faculty.
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
    /// Calculates total dues in each faculty
    /// </summary>
    public class TotalDuesInFaculty
    {
        public double TotalDuesFac(List<DeptDues> deptDues)
        {
            double amount=0;
            foreach(var deptDue in deptDues)
            {
                amount += deptDue.TotalDeptDues();
            }

            return amount;
        }
    }

    //Derived class, derived from the base class DeptDues
    /// <summary>
    ///  Derived from the base class DeptDues
    ///  calculates total dues in a department in science
    /// </summary>
    public class Science:DeptDues
    {
        public int DinnerFee { get; set; }
        public int GeneratedRevenues { get; set; }
        public override double TotalDeptDues()
        {
            try
            {
                double totalDeptDues = ((BasicDues + DinnerFee) * NoOfStudents) + GeneratedRevenues;
                return totalDeptDues;
            }
            catch (Exception err)
            {

                Console.WriteLine("Invalid: "+err.Message);
                return 0;
            }
        }

    }


    /// <summary>
    ///  Derived from the base class DeptDues
    /// calculates total dues in a department in science
    /// </summary>
    public class Art : DeptDues
    {
        
        public int GeneratedRevenues { get; set; }
        public int Excursion { get; set; }
        public override double TotalDeptDues()
        {
            try
            {
                double totalDeptDues = ((BasicDues + Excursion) * NoOfStudents) + GeneratedRevenues;
                return totalDeptDues;
            }
            catch (Exception err)
            {

                Console.WriteLine("Invalid: "+err.Message);
                return 0;
            }
        }

    }
}
