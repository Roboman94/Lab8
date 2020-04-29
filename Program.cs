using System;
using System.Linq;
using System.Collections.Generic;


namespace Lab8
{
   class Program
   {
      static void Main(string[] args)
       {
          bool tryagain = true;
          while (tryagain == true)
           {
                   
                List<string> names = new List<string> { "Kendall", "Ryan", "Luke", "Corey" };
                    string[] indexArr = { "1", "2", "3", "4" };
                    string[] favoriteFoods = { "Steak", "Crab", "Fish", "Clams" };
                    string[] homeTown = { "Flint", "Compton", "Detroit", "Chicago" };
                    Console.WriteLine("Welcome to the Student Database!");
                    string name = "";
                    int i = 0;
                    foreach (string name1 in names)
                    {

                        name = String.Join(" ", name, indexArr[i], name1).Trim();
                        i++;
                    }
                    Console.WriteLine(name);
                bool validentry = false;
                string input = "";
                    int index = 0;
                while (validentry == false)
                {
                    Console.WriteLine($"Please select name or number");
                    input = Console.ReadLine().ToLower();

                    if (input.Contains("kendall"))
                    {
                        name = "Kendall";
                        index = 0;
                        validentry = true;
                    }
                    else if (input.Contains("ryan"))
                    {
                        name = "Ryan";
                        index = 1;
                        validentry = true;
                    }
                    else if (input.Contains("luke"))
                    {
                        name = "Luke";
                        index = 2;
                        validentry = true;
                    }
                    else if (input.Contains("corey"))
                    {
                        name = "Corey";
                        index = 3;
                        validentry = true;
                    }
                    else
                    {
                        try
                        {
                            index = int.Parse(input);
                            index = index - 1;
                            if (index == 0)
                            {
                                validentry = true;
                                name = "Kendall";
                            }
                            else if (index == 1)
                            {
                                validentry = true;
                                name = "Ryan";
                            }
                            else if (index == 2)
                            {
                                validentry = true;
                                name = "Luke";
                            }
                            else if (index == 3)
                            {
                                validentry = true;
                                name = "Corey";
                            }
                            else if (index >= names.Count())
                            {
                                Console.WriteLine("Input exceeds index!");
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            
                            Console.WriteLine("You entered a number outside of index range! Please try again.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a valid entry. Please try again!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                    if (input != "")
                    {
                    validentry = false;
                    while (validentry == false)
                        { 
                        Console.WriteLine($"You selected {name} at index: {index}");
                        Console.WriteLine($"What would like to learn about {name}? type ff or favorite food ..");
                        Console.WriteLine("or type ht or home town.");

                        string response = Console.ReadLine();

                        if (response == "ff" || response.Contains("food"))
                        {
                            Console.WriteLine($"The favorite food of {name} is {favoriteFoods[index]}");
                            validentry = true;
                        }
                        else if (response == "ht" || response.Contains("town"))
                        {
                            Console.WriteLine($"The hometown of {name} is {homeTown[index]}");
                            validentry = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry! Please try again!");
                            validentry = false;
                        }
                        }
                    }  
             tryagain = Proceed();
          }
       }
public static bool Proceed()
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? (y/n) ");
                string proceed = Console.ReadLine().ToLower();
                if (proceed.StartsWith("y"))
                {
                    return true;
                }
                if (proceed.StartsWith("n"))
                {
                    Console.WriteLine("thank you!");
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again");
                    return Proceed();
                }
            }
   }
}
