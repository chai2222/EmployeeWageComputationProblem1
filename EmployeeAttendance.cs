

namespace EmployeeWageProblem
{
    public class EmployeeAttendance
    {
        public static void checkAttendance()
        {
            int is_Present = 1;

            Random random = new Random();
            int empCheck = random.Next(2);

            if(empCheck==is_Present)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
