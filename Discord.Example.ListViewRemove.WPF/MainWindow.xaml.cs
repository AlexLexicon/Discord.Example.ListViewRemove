using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Discord.Example.ListViewRemove.WPF;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        MyItems = new ObservableCollection<MyItem>();

        for (int index = 0; index < 5; index++)
        {
            MyItems.Add(new MyItem
            {
                Id = index,
                Name = $"Item: {index + 1}",
            });
        }

        InitializeComponent();
    }

    public ObservableCollection<MyItem> MyItems { get; }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button senderButton && senderButton.DataContext is MyItem myItemToRemove)
        {
            MyItems.Remove(myItemToRemove);
        }
    }
}
