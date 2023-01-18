
using System;
class EmpWage
{
    static int wage_per_hr = 20;
    static int full_day_hr = 8;
    static int part_day_hr = 8;
    static int work_day_per_month = 20;

    // attendence
    static void UC_1()
    {
        Random rndm = new Random();
        int present = rndm.Next(0, 2);

        if (present == 1)
        {
            Console.WriteLine("Employee is present");
        }
        else if (present == 0)
        {
            Console.WriteLine("Employee is absent");
        }
    }

    //full time
    static void UC_2()
    {
        int wage_per_hr = 20;
        int full_day_hr = 8;

        int full_day_wage = wage_per_hr * full_day_hr;

        Console.WriteLine("Full day wage: " + full_day_wage);
    }

    //part time
    static void UC_3()
    {
        // int wage_per_hr = 20;
        // int part_day_hr = 8;

        int part_day_wage = wage_per_hr * part_day_hr;

        Console.WriteLine("Part day wage: " + part_day_wage);
    }

    //Switch case
    static void UC_4()
    {
        Random rndm = new Random();
        int wage_case = rndm.Next(0, 2);

        Console.WriteLine("Case : " + wage_case);

        switch (wage_case)
        {
            case 0:
                UC_2();
                break;
            case 1:
                UC_3();
                break;
            default:
                Console.WriteLine("not valid");
                break;
        }
    }

    static void UC_5()
    {
        int monthly_wage = work_day_per_month * full_day_hr * wage_per_hr;
        Console.WriteLine("Monthly wage for full time: " + monthly_wage);

    }

    static void UC_6()
    {
        int max_hrs = 100;
        int max_days = 20;

        int total_wage = 0;
        int total_hrs = 0;
        for (int i = 1; i < max_days && total_hrs < max_hrs; i++)
        {
            int curr_wage = wage_per_hr * full_day_hr;

            total_hrs += full_day_hr;
            total_wage += curr_wage;
        }

        Console.WriteLine("UC 6: Calculated wage: " + total_wage);
    }


    static void Main()
    {

        // start
        Console.WriteLine("welcome to employee wage computation program");

        UC_1();
        UC_2();
        UC_3();
        UC_4();
        UC_5();
        UC_6();
    }
}