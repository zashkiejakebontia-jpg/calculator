using System;

public static class Calculator {
    
    //Main Method
    public static void Main(String[] args){
        bool continueCalculating = true;
        
        while (continueCalculating){
            // Promts user to enter the first number
            Console.Write("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            
            // Promts user to enter second number
            Console.Write("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            
            string operation = "";
            
            do {
                Console.WriteLine("Choose Operation (+,-,*,/,%,=)");
                operation = Console.ReadLine();
                
                if (operation == "="){
                    Calculate(first, second, operation);
                    continueCalculating = false;
                    break;
                }
                Calculate(first, second, operation);
            }
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "%" && operation != "=");
        }
    }
    

