internal class Program
{
    private static void Main(string[] args)
    {
Console.WriteLine("Welcome to ErezCode's simple to do program using c#");
        List<string> taskList = new List<string>();
        String userInput = "";
        while(userInput != "e")
        {
            Console.WriteLine("what command would you like to do?");
            Console.WriteLine("type 1 to add a task to list");
            Console.WriteLine("type 2 to remove a task from the list");
            Console.WriteLine("type 3 to view the task list");
            Console.WriteLine("type e to exit the program");
            userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Console.WriteLine("enter the task you wish to add");
                string task = Console.ReadLine() ;
                taskList.Add(task);
                Console.WriteLine("Added!");


            }
            else if (userInput == "2")
            {
                printIndexList(taskList);
                Console.WriteLine("enter the number of the task you wish to remove");
                int num = Convert.ToInt32(Console.ReadLine());
                taskList.RemoveAt(num);
            }
            else if(userInput == "3")
            {
                printIndexList(taskList);
            }
            else if(userInput == "e") 
            {
                Console.WriteLine("thanks for using the program");
                break;
            }
            else { Console.WriteLine("invalid, try again"); }


        }
        
        
    }
     public static void printIndexList(List<string> lst)
    {
        for(int i = 0; i < lst.Count; i++)
        {
            Console.WriteLine(i + ": " + lst[i]);
        }
    }
   
    }

