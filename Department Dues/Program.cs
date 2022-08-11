namespace Department_Dues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalDuesInFaculty totalDuesInFaculty = new TotalDuesInFaculty();
            // List to handle all the dues inputed
            var scienceDueList = new List<DeptDues>();
            scienceDueList.Add(new Science() { BasicDues = 5000, DinnerFee = 2000, GeneratedRevenues = 4000, NoOfStudents = 1 });
            scienceDueList.Add(new Science() { BasicDues = 5000, DinnerFee = 2000, GeneratedRevenues = 4000, NoOfStudents = 1 });
            scienceDueList.Add(new Science() { BasicDues = 5000, DinnerFee = 2000, GeneratedRevenues = 4000, NoOfStudents = 1 });

            var artDueList= new List<DeptDues>();
            artDueList.Add(new Art() { BasicDues = 5000, Excursion = 8000, GeneratedRevenues = 20000, NoOfStudents=1});
            artDueList.Add(new Art() { BasicDues = 5000, Excursion = 8000, GeneratedRevenues = 20000, NoOfStudents = 1 });
            artDueList.Add(new Art() { BasicDues = 5000, Excursion = 8000, GeneratedRevenues = 20000, NoOfStudents = 1 });

            var dues = new TotalDuesInFaculty();
            Console.WriteLine(dues.TotalDuesFac(scienceDueList));
            Console.WriteLine(dues.TotalDuesFac(artDueList));
        }
    }
}


