using System.Windows;
using System.Xml;


namespace Todo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> todoList = new List<string>();
        private int count;
        public MainWindow()
        {
            InitializeComponent();
            todoListBox.ItemsSource = todoList;
            countTodo.Text = "" + count;
        }

        private void addButton_Click_1(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(inputTextBox.Text)) 
            {
                MessageBox.Show(
                    "Du kan inte ha tom text. \nVänligen skriv in text i rutan.",
                    "Felmeddelande",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return;
            }
            todoList.Add(inputTextBox.Text);
            inputTextBox.Clear();
            count++;
            countTodo.Text = "" + count;
            todoListBox.Items.Refresh();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (todoListBox.SelectedItem == null) 
            {
                MessageBox.Show(
                    "Du behöver välja ett alternativ.", "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                    return;
            }


            if (todoListBox.SelectedItem != null)
            {
                MessageBoxResult resultat = MessageBox.Show(
                    "Är du säker på att du vill ta bort detta", "Varning",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning);

                if (resultat == MessageBoxResult.OK)
                {
                    todoList.Remove(todoListBox.SelectedItem.ToString());
                    count--;
                    countTodo.Text = "" + count;
                    todoListBox.Items.Refresh();
                }
                else
                {
                    return;
                }
            }
        }
    }
}