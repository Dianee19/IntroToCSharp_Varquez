using System;

class CodacLogistics
{
    static void Main()
    {
        
        Console.WriteLine("=== CODAC LOGISTICS - DELIVERY & FUEL AUDITOR ===\n");
        Console.Write("Enter Driver's Full Name: ");
        string driverName = Console.ReadLine();

       
        Console.Write("Enter Weekly Fuel Budget (₱): ");
        decimal weeklyBudget = decimal.Parse(Console.ReadLine());

        
        double totalDistance = 0.0;

        
        while (totalDistance <= 0 || totalDistance > 5000.0)
        {
            Console.Write("Enter Total Distance Traveled this week (1.0 - 5000.0 km): ");
            totalDistance = double.Parse(Console.ReadLine());

            // Input validation with error message
            if (totalDistance <= 0 || totalDistance > 5000.0)
            {
                Console.WriteLine("❌ ERROR: Distance must be between 1.0 and 5000.0 km. Please try again.\n");
            }
        }

        Console.WriteLine("\n✓ Distance validated successfully!\n");

       

        
        decimal[] fuelExpenses = new decimal[5];

       
        decimal totalFuelSpent = 0.0m;

        Console.WriteLine("--- Enter Daily Fuel Expenses ---");

       
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Day {i + 1} Fuel Cost (₱): ");
            fuelExpenses[i] = decimal.Parse(Console.ReadLine());

            
            totalFuelSpent += fuelExpenses[i];
        }

       

        
        decimal averageDailyExpense = totalFuelSpent / 5;

        
        double fuelEfficiency = totalDistance / (double)totalFuelSpent;

        
        string efficiencyRating;

        if (fuelEfficiency > 15)
        {
            efficiencyRating = "High Efficiency";
        }
        else if (fuelEfficiency >= 10)
        {
            efficiencyRating = "Standard Efficiency";
        }
        else
        {
            efficiencyRating = "Low Efficiency / Maintenance Required";
        }

       
        bool underBudget = totalFuelSpent <= weeklyBudget;

       
        decimal budgetDifference = weeklyBudget - totalFuelSpent;

        
        Console.WriteLine("\n");
        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║          CODAC LOGISTICS - WEEKLY AUDIT REPORT           ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        Console.WriteLine($"Driver Name: {driverName}");
        Console.WriteLine($"Total Distance Traveled: {totalDistance:F2} km");
        Console.WriteLine($"Weekly Fuel Budget: ₱{weeklyBudget:F2}");
        Console.WriteLine();

        Console.WriteLine("--- 5-Day Fuel Expense Breakdown ---");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"  Day {i + 1}: ₱{fuelExpenses[i]:F2}");
        }
        Console.WriteLine();

        Console.WriteLine("--- Financial Summary ---");
        Console.WriteLine($"Total Fuel Spent: ₱{totalFuelSpent:F2}");
        Console.WriteLine($"Average Daily Expense: ₱{averageDailyExpense:F2}");
        Console.WriteLine();

        Console.WriteLine("--- Performance Analysis ---");
        Console.WriteLine($"Fuel Efficiency: {fuelEfficiency:F2} km/₱");
        Console.WriteLine($"Efficiency Rating: {efficiencyRating}");
        Console.WriteLine();

        Console.WriteLine("--- Budget Status ---");
        Console.WriteLine($"Under Budget: {underBudget}");

        if (underBudget)
        {
            Console.WriteLine($"Budget Remaining: ₱{budgetDifference:F2}");
            Console.WriteLine("✓ Status: APPROVED - Within budget limits");
        }
        else
        {
            Console.WriteLine($"Budget Exceeded By: ₱{Math.Abs(budgetDifference):F2}");
            Console.WriteLine("⚠ Status: REVIEW REQUIRED - Over budget");
        }

        Console.WriteLine();
        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    END OF REPORT                         ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

}
