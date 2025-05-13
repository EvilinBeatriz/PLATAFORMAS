

using System.Collections.Generic;

public class CommandManager
{
  public List<ICommand> Commands;

  public CommandManager()
  {
    Commands = new List<ICommand>();
  }

  public void AddCommand(ICommand command)
  {
    Commands.Add(command);
  }

  public void DoCommand()
  {
    Commands[^1].Do();
  }
  
}
