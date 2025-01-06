using System.Xml;

List<string> todos = new List<string>();

while(true)
{
    Console.Clear();
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?\r\n");

    Console.WriteLine("[S]ee all Todos");
    Console.WriteLine("[A]dd a Todo");
    Console.WriteLine("[D]elete a Todo");
    Console.WriteLine("[U]pdate Todo");
    Console.WriteLine("[E]xit");

    char option;

    Console.Write("\nChoose an option: ");
    option = char.ToUpper(Console.ReadKey(true).KeyChar);
    Console.Write(option);  

    switch (option)
    {
        case 'A':
            string todo;
            
            do
            {
                Console.Write("\nEnter a new Todo: ");
                todo = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(todo))
                {
                    Console.WriteLine("The description cannot be empty.");
                }

                if(todos.Contains(todo))
                {
                    Console.WriteLine("The description must be unique.");
                    continue;
                }
            } while (string.IsNullOrWhiteSpace(todo));


            todos.Add(todo);
            Console.WriteLine("TODO successfully added: " + todo);
            break;

        case 'S':
            Console.WriteLine();
            if(todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            
            int i = 1;
            foreach(var _todo in todos)
            {
                Console.WriteLine($" {i}. {_todo}");
                i++;
            }

            break;

        case 'D':
            Console.WriteLine();
            if(todos.Count <= 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                break;
            }
            
            i = 1;
            foreach (var _todo in todos)
            { 
                Console.WriteLine($" {i}. {_todo}");
                i++;
            }

            int index = 0;
            while(true)
            {
                Console.Write("\nSelect the index of the TODO you want to remove: ");
                string input = Console.ReadLine();
                
                if(int.TryParse(input, out index) && index > 0 && index <= todos.Count)
                {
                    break;
                }

                Console.WriteLine("The given index is not valid.");
            }
            
            var todoDel = todos[index - 1];
            todos.RemoveAt(index - 1);

            Console.WriteLine("TODO removed: " + todoDel);
            break;

        case 'U':
            if (todos.Count <= 0)
            {
                Console.WriteLine("No TODOs to Update");
                break;
            }

            i = 1;
            foreach (var _todo in todos)
            {
                Console.WriteLine($" {i}. {_todo}");
                i++;
            }

            index = 0;
            while (true)
            {
                Console.Write("\nEnter the todo index to be updated: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out index) && index > 0 && index <= todos.Count)
                {
                    break;
                }

                Console.WriteLine("Invalid Index!");
            }

            string todoEdit;
            do
            {
                Console.Write("\nEnter a the new Todo: ");
                todoEdit= Console.ReadLine();

                if (string.IsNullOrWhiteSpace(todoEdit))
                {
                    Console.WriteLine("Cannot enter an empty TODO!");
                }
            } while (string.IsNullOrWhiteSpace(todoEdit));

            todos[index - 1] = todoEdit;
            Console.WriteLine("TODO updated successfully!");
            break;

        case 'E':
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\nIncorrect input");
            break;
    }

    WaitForKey();
}


void WaitForKey()
{
    Console.WriteLine();
    Console.Write("Press any Key to continue...");
    Console.ReadKey();
}
