using Discord.Example.ListViewRemove.Models;
using System.Collections.ObjectModel;

namespace Discord.Example.ListViewRemove.ViewModels;
public class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        MyViewModels = new ObservableCollection<MyViewModel>();

        for (int index = 0; index < 5; index++)
        {
            var m = new MyModel
            {
                Id = index,
                Name = $"Item: {index + 1}",
            };

            var vm = new MyViewModel(m);
            vm.Remove += () => RemoveViewModel(vm);

            MyViewModels.Add(vm);
        }
    }

    public ObservableCollection<MyViewModel> MyViewModels { get; }

    public void RemoveViewModel(MyViewModel viewModelToRemove)
    {
        MyViewModels.Remove(viewModelToRemove);
    }
}
