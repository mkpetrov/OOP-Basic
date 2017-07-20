using System;

public class Program
{
    public static void Main(string[] args)
    {
        var commandLine = Console.ReadLine();
        var manager=new CarManager();

        while (commandLine!= "Cops Are Here")
        {
            var commandParts = commandLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var command = commandParts[0];
            int id;

            switch (command)
            {
                case "register":
                    id = int.Parse(commandParts[1]);
                    manager.Register(id,commandParts[2],commandParts[3],commandParts[4],int.Parse(commandParts[5]), int.Parse(commandParts[6]), int.Parse(commandParts[7]), int.Parse(commandParts[8]), int.Parse(commandParts[9]));
                    break;

                case "check":
                    id = int.Parse(commandParts[1]);
                    manager.Check(id);
                    break;

                case "open":
                    id = int.Parse(commandParts[1]);
                    manager.Open(id,commandParts[2],int.Parse(commandParts[3]),commandParts[4],int.Parse(commandParts[5]));
                    break;

                case "participate":
                    manager.Participate(int.Parse(commandParts[1]),int.Parse(commandParts[2]));
                    break;

                case "start ":
                    id = int.Parse(commandParts[1]);
                    manager.Start(id);
                    break;

                case "park":
                    id = int.Parse(commandParts[1]);
                    manager.Park(id);
                    break;

                case "unpark":
                    id = int.Parse(commandParts[1]);
                    manager.Unpark(id);
                    break;

                case "tune":
                    break;
            }

            commandLine = Console.ReadLine();
        }
    }
}
