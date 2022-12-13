using System.Windows.Input;

namespace Discord.Example.ListViewRemove.ViewModels.MVVM;
public class MyCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;
    public event Action? Executed;

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        Executed?.Invoke();
    }
}