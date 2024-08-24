using System.Windows;
using ToDoListApp;

namespace ToDoListApp.WPF
{
    public partial class MainWindow : Window
    {
        private readonly ToDoList toDoList;

        public MainWindow()
        {
            InitializeComponent();
            toDoList = new ToDoList();
            LoadTasks();
        }

        private void LoadTasks()
        {
            TaskList.Items.Clear();
            var tasks = toDoList.GetAllTasks();
            foreach (var task in tasks)
            {
                TaskList.Items.Add(task);
            }
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            var addTaskWindow = new AddTaskWindow();
            if (addTaskWindow.ShowDialog() == true)
            {
                toDoList.AddTask(addTaskWindow.TaskTitle, addTaskWindow.TaskDescription);
                LoadTasks();
            }
        }

        private void MarkAsCompleted_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem is Task task)
            {
                toDoList.MarkTaskAsCompleted(task.Id);
                LoadTasks();
            }
        }

        private void RemoveTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem is Task task)
            {
                toDoList.RemoveTask(task.Id);
                LoadTasks();
            }
        }
    }
}
