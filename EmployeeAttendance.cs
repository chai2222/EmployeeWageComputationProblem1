
    public class EmployeeAttendance
    {
        public static void checkAttendance()
        {
            int is_Full_Time = 1;
            int is_Wage_Per_Hour = 20;

            int is_Part_Time = 2;
            
            int emp_Wage = 0;
            int emp_Hour = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == is_Full_Time)
            {
                Console.WriteLine("Employee Is Present");
                emp_Hour = 8;
            }

            else if(empCheck==is_Part_Time)
            {
                Console.WriteLine("Employee Is Part Time");
                emp_Hour = 4;
            }


            else
            {
                Console.WriteLine("Employee Is Absent");
            }
            emp_Wage = emp_Hour * is_Wage_Per_Hour;
            Console.WriteLine("Employee Wage :" + emp_Wage);
        }
    }