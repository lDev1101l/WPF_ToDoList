using System.Windows;

namespace ToDoListApp.WPF
{
    public partial class AddTaskWindow : Window
    {
        public string TaskTitle { get; private set; }
        public string TaskDescription { get; private set; }

        public AddTaskWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            TaskTitle = TitleTextBox.Text;
            TaskDescription = DescriptionTextBox.Text;

            if (string.IsNullOrWhiteSpace(TaskTitle) || string.IsNullOrWhiteSpace(TaskDescription))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
