using Discord.Example.ListViewRemove.Models;
using Discord.Example.ListViewRemove.ViewModels.MVVM;

namespace Discord.Example.ListViewRemove.ViewModels;
public class MyViewModel
{
    public event Action? Remove;

    public MyViewModel(MyModel model)
    {
        Model = model;

        RemoveCommand = new MyCommand();
        RemoveCommand.Executed += OnRemove;
    }

    public MyModel Model { get; }

    public MyCommand RemoveCommand { get; }

    public void OnRemove()
    {
        Remove?.Invoke();
    }
}
