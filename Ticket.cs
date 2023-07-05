

using System;

public class Ticket
{
    // variable declaration 
    string studentNumber;
    int speedLimit;
    int ticketedSpeed;
    char classif;
    
    string classification;
    int speed;
    double fine;


    //Constructor
    public Ticket()
    {
        Console.Write("Enter student number : ");
        studentNumber = Console.ReadLine();
        Console.Write("Enter the Speed Limit : ");
        speedLimit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Ticketed Speed : ");
        ticketedSpeed = Convert.ToInt32(Console.ReadLine());

        DisplayMenu();

        // output of information and fine
        Console.WriteLine("\n    Ticket App");
        Console.WriteLine("Student Number : " + studentNumber);
        Console.WriteLine("Classification : " + classification);
        Console.WriteLine("Speed Limit    : " + speedLimit);
        Console.WriteLine("Reported Speed : " + ticketedSpeed);
        Console.WriteLine("\nFine : $" + SetFine() );
    }

    // Method to display menu of classification
    public void DisplayMenu()
    {
        Console.WriteLine("Enter your classification :\n \t Freshman <enter 1> \n \t Shophomore <enter 2> \n \t Junior <enter 3> \n \t Senior <enter 4>");
        classif = (char)Console.Read();
        int studentClass = Convert.ToInt32(classif);
        
        //determining the classification
        switch (studentClass)
        {
            case '1':
                classification = "Freshman";
                break;

            case '2':
                classification = "Sophomore";
                break;

            case '3':
                classification = "Junior";
                break;

            case '4':
                classification = "Senior";
                break;

            default:
                Console.WriteLine("Wrong Option entered");
                DisplayMenu();
                break;
        }
    }

    // calculating fine
    public double SetFine()
    {
        speed = ticketedSpeed - speedLimit;
        fine = (speed / 5 * 87.50) + 75.00;
        if (classification == "Senior")
        {
            if (speed > 20)
            {
                fine += 200;
            }
            else
            {
                fine += 50;
            }
        }
        
        else 
        if (classification == "Freshman"){
            if (speed < 20)
            {
                fine -= 50;
            }
            else
            {
                fine += 100;
            }
            }
        else 
        if (speed > 19)
        {
            fine += 100;
        }
        return fine;
    }
}

