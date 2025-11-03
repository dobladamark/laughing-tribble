using System;

class Program 
{

    static void Main()
    {
        string username, password, choice, empname, pos, studn;
        double inc, deduc, salary = 0, netpay, year, numUnit, misFee = 0, tFee = 0, total; 


        Console.Write("Enter Username: ");
        username = Console.ReadLine();
        Console.Write("Enter Password: ");
        password = Console.ReadLine();
        Console.WriteLine("*********************");
        

    if (username == "Mark" && password == "123")
    {
        Console.WriteLine("SYSTEM MENU");
        Console.WriteLine("A. Salary Computation");
        Console.WriteLine("B. Enrollment Fee Computation");
         Console.WriteLine("*********************");
        Console.Write("Input Choice: ");
        choice = Console.ReadLine();
        Console.WriteLine("*********************");
    
        if (choice == "A")
        {
            Console.Write("Enter Employee Name: ");
            empname = Console.ReadLine();
            Console.Write("Enter Position: ");
            pos = Console.ReadLine();
            Console.Write("Enter Incentives Amount: ");
            inc = double.Parse(Console.ReadLine());
            Console.Write("Enter Deduction Amount: ");
            deduc = double.Parse(Console.ReadLine());
             Console.WriteLine("*********************");

               if (pos == "Manager")
               {
               salary = 30000;
               }

              if (pos == "Supervisor")
               {
                salary = 26000;
               }

               
              if (pos == "Staff")
               {
                salary = 21000;
               }

               netpay = salary + inc - deduc; 

               Console.WriteLine("Salary: " + salary);
               Console.WriteLine("Net Pay: " + netpay);
        }

        if (choice == "B")
        {
            Console.Write("Enter Student Number: ");
            studn = Console.ReadLine();
            Console.Write("Enter Year Level: ");
            year = double.Parse(Console.ReadLine());
            Console.Write("Enter Number of Units: ");
            numUnit = double.Parse(Console.ReadLine());

            Console.WriteLine("*********************");

            if (year == 1)
            {
                misFee = 1200;
            }

              if (year == 2)
            {
                misFee = 1300;
            }

              if (year == 3)
            {
                misFee = 1600;
            }

              if (year == 4)
            {
                misFee = 2000;
            }

            tFee = numUnit * 500;
            total = misFee + tFee;

            Console.WriteLine("Miscellaneous Fee: " + misFee );
            Console.WriteLine("Tuition Fee:  " + tFee );
            Console.WriteLine("Total Enrollment Fee: " + total);
           

        }
    

       
    }

    else{
        Console.WriteLine("Wrong Username and Password");
        }

               
               

    }

        }
