
        // Calculate functions that handles the operatons
        public static double? Calculate(int first, int second, string operation)
        {
            switch (operation){
                    case "+":
                        Console.WriteLine($"Result: {first + second}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {first - second}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {first * second}");
                        break;
                    case "/":
                        if (second == 0){
                            Console.WriteLine("Cannot be Divided by Zero");
                        }else{
                            Console.WriteLine($"Result: {first / second}");
                        }
                        break;
                    case "%":
                        if (second == 0){
                            Console.WriteLine("Cannot modulo by zero");
                        }else{
                            Console.WriteLine($"Result: {first % second}");
                        }
                        break;
                    case "=":
                        Console.WriteLine("Exiting Program...");
                        break;
                    default:
                        Console.WriteLine(“Incorrect Operation Used, please try again”);
                        break;
            }
            return null;
        }
    
}
