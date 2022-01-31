/**
 * Kyle Free
 * GAME 1343
 * 1/30/2022
 * Logical Operations Program
**/

using System;
using System.Collections.Generic;
using System.Text;


class LogicalOperations {
    // Variables
    int numOps; // The number of operations performed
         
    float
        myVar, // Required myVariable
        temp; // Temporary variable for printing

    // Constructor
    public LogicalOperations() {

        numOps = 0;
        temp = 0;
        myVar = 42; // The answer to everything

        firstOp();
        secondOp();
        thirdOp();
        forthOp();
        fifthOp();
    }

    // First Operation -1 + 4 * myVar
    private void firstOp() {

        numOps++;
        temp = -1 + 4 * myVar;
        display();
    }

    // Second Operation (35 + 4) % myVar
    private void secondOp() {

        numOps++;
        temp = (35 + 5) % myVar;
        display();
    }

    // Third Operation 14 + -4 * 12
    private void thirdOp() {

        numOps++;
        temp = 14 + -4 * 6 / 12;
        display();
    }

    // Fourth Operation 2 + 12 / 6 * 1 - myVar % 2;
    private void forthOp() {

        numOps++;
        temp = 2 + 12 / 6 * 1 - myVar % 2;
        display();
    }

    // Fifth Operation
    private void fifthOp() {

        if (myVar * myVar > 10)
            Console.WriteLine("myVar is less than 4.");

        else
            Console.WriteLine("myVar is greater than 4.");
    }

    private void display() {

        Console.Write("Operation ");
        Console.WriteLine(numOps);
        Console.WriteLine(temp);
        Console.ReadLine();

        temp = 0;
    }
    
    static void Main(string[] args) {

        new LogicalOperations();
    }
}

