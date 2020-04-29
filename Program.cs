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
                    string[] names = { "Kendall", "Ryan", "Luke", "Corey" };
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
                while (validentry == false)
                {
                    Console.WriteLine($"Please select name or number");
                    string input = Console.ReadLine().ToLower();
                    int index = 0;
                    name = "";
                    if (input.Contains("kendall"))
                    {
                        index = 0;
                    }
                    if (input.Contains("ryan"))
                    {
                        index = 1;
                    }
                    if (input.Contains("luke"))
                    {
                        index = 2;
                    }
                    if (input.Contains("corey"))
                    {
                        index = 3;
                    }
                    else
                    {
                        try
                        {
                            index = int.Parse(input);

                            if (index >= 0 && index < names.Length)
                            {
                                name = names[index - 1];
                            }
                            else
                            {
                                throw new Exception($"That number is outside the range of 0 to {names.Length - 1}. Please try again");
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("You somehow skipped the first check..");
                            Console.WriteLine("But the issue still remains, you entered a number outside of index range! Please try again.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a valid entry. Please try again!");
                        }
                        catch (Exception e)
                        {
                            ////writes any other err exception
                            Console.WriteLine(e.Message);
                        }
                    }
                    if (name != "")
                    {
                        Console.WriteLine($"You selected {name} at index: {index-1}");
                        Console.WriteLine($"What would like to learn about {name}? type ff or favorite food ..");
                        Console.WriteLine("or type ht or home town.");

                        string response = Console.ReadLine();

                        if (response == "ff" || response.Contains("food"))
                        {
                            Console.WriteLine($"The favorite food of {name} is {favoriteFoods[index-1]}");
                            validentry = true;
                        }
                        else if (response == "ht" || response.Contains("town"))
                        {
                            Console.WriteLine($"The hometown of {name} is {homeTown[index-1]}");
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
