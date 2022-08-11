namespace Department_Dues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalDuesInFaculty totalDuesInFaculty = new TotalDuesInFaculty();
            // List to handle all the dues imputed
            List<double> dues = new List<double>();

            Console.WriteLine("Computer Science: \n");
            CompScience compSci =new CompScience();

            //try catch block to handle exceptions thrown
            try
            {
                Console.WriteLine("Dinner Fee: ");
                compSci.DinnerFee = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Basic Dues: ");
                compSci.BasicDues = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("No Of Student: ");
                compSci.NoOfStudents = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Generated Revenue: ");
                compSci.GeneratedRevenues = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total Dues in Computer Science is "+ compSci.TotalDeptDues());
                dues.Add(compSci.TotalDeptDues());
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Input");
            }
            
            
            //Instantiation of class Geology
            Console.WriteLine("\n\nGeology Department: ");
            Geology geology = new Geology();

            try
            {
                Console.WriteLine("Excursion Fee: ");
                geology.Excursion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Basic Dues: ");
                geology.BasicDues = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("No Of Student: ");
                geology.NoOfStudents = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Generated Revenue: ");
                geology.GeneratedRevenues = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total dues in Geology is " + geology.TotalDeptDues());
                dues.Add(geology.TotalDeptDues());
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Total dues in the faculty is"+totalDuesInFaculty.TotalDuesFac(dues));
        }
    }
}