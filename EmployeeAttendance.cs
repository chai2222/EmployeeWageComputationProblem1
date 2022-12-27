

namespace EmployeeWageProblem
{
    public class EmployeeAttendance
    {
        public static void checkAttendance()
        {
            int is_Present = 1;
            int is_Wage_Per_Hour = 20;
            int emp_Wage = 0;
            int emp_Hour = 0;

            Random random = new Random();
            int empCheck = random.Next(2);

            if(empCheck==is_Present)
            {
                Console.WriteLine("Employee Is Present");
                emp_Hour = 8;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
            emp_Wage = emp_Hour * is_Wage_Per_Hour;
            Console.WriteLine("Employee Wage :" + emp_Wage);
        }
    }
}
