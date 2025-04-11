using System.Windows;


namespace Todo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> todoList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            todoListBox.ItemsSource = todoList;
        }

        private void addButton_Click_1(object sender, RoutedEventArgs e)
        {

            todoList.Add(inputTextBox.Text);
            todoListBox.Items.Refresh();
            inputTextBox.Clear();

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                todoList.Remove(todoListBox.SelectedItem.ToString());
                todoListBox.Items.Refresh();
            }
        }
    }
}