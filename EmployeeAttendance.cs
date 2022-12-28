
    public class EmployeeAttendance
    {
    public static void checkAttendance()
    {
        const int is_Full_Time = 1;
        const int is_Wage_Per_Hour = 20;

        const int is_Part_Time = 2;
        const int num_Of_Working_days = 20;

        int emp_Wage = 0;
        int emp_Hour = 0;
        int total_Emp_Wage = 0;

        Random random = new Random();
        int empCheck = random.Next(3);

        for (int i = 0; i < num_Of_Working_days; i++)
        {
            switch (empCheck)
            {
                case is_Full_Time:
                    Console.WriteLine("Employee Is Present & Full Time");
                    emp_Hour = 8;
                    break;
                case is_Part_Time:
                    Console.WriteLine("Employee Is Part Time");
                    emp_Hour = 4;
                    break;
                case 0:
                    Console.WriteLine("Employee Is Absent");
                    break;
            }
            /* if (empCheck == is_Full_Time)
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
             }*/
            emp_Wage = emp_Hour * is_Wage_Per_Hour;
            total_Emp_Wage += emp_Wage;
            Console.WriteLine("Employee Wage :" + emp_Wage);
        }
        Console.WriteLine("Total Employee Wage is :" + total_Emp_Wage);
        }
    }