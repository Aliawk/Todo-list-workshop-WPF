using System.Windows;

namespace Todo
{
    public partial class EditWindow : Window
    {
        public string UpdatedText { get; private set; }

        public EditWindow(string currentText)
        {
            InitializeComponent();
            editTextBox.Text = currentText;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            UpdatedText = editTextBox.Text;
            DialogResult = true; // Stänger fönstret och signalerar att vi sparat
        }
    }
}