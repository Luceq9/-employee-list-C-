
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.txt");

        public Form1()
        {
            InitializeComponent();
            LoadTasksFromFile();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            string taskName = TaskInputTextBox.Text;
            string taskSurname = TaskSurnameTextBox.Text;
            string taskProfession = TaskProfessionTextBox.Text;

            if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(taskSurname) || string.IsNullOrEmpty(taskProfession))
            {
                MessageBox.Show("Proszê wype³niæ wszystkie pola.");
                return;
            }

            string task = $"{taskName} - {taskSurname} - {taskProfession}";
            TaskListBox.Items.Add(task);
            ClearTaskInputFields();
            SaveTasksToFile();
            SortTasks();
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedItem != null)
            {
                TaskListBox.Items.Remove(TaskListBox.SelectedItem);
                SaveTasksToFile();
            }
            else
            {
                MessageBox.Show("Wybierz zadanie do usuniêcia. (kliknij w zadanie)");
            }
        }


        private void ClearTaskInputFields()
        {
            TaskInputTextBox.Clear();
            TaskSurnameTextBox.Clear();
            TaskProfessionTextBox.Clear();
        }

        private void LoadTasksFromFile()
        {
            if (File.Exists(FilePath))
            {
                var tasks = File.ReadAllLines(FilePath);
                TaskListBox.Items.AddRange(tasks);
            }
        }

        private void SaveTasksToFile()
        {
            var tasks = TaskListBox.Items.Cast<string>().ToArray();
            File.WriteAllLines(FilePath, tasks);
        }

        private void SortTasks()
        {
            var sortedTasks = TaskListBox.Items.Cast<string>()
                .OrderBy(task => task.Split(" - ")[0])
                .ToArray();

            TaskListBox.Items.Clear();
            TaskListBox.Items.AddRange(sortedTasks);
        }





        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedItem != null)
            {
                string? selectedTask = TaskListBox.SelectedItem?.ToString();
                if (selectedTask != null)
                {
                    string[] taskParts = selectedTask.Split(" - ");

                    if (taskParts.Length == 3)
                    {
                        TaskInputTextBox.Text = taskParts[0];
                        TaskSurnameTextBox.Text = taskParts[1];
                        TaskProfessionTextBox.Text = taskParts[2];
                    }

                    TaskListBox.Items.Remove(TaskListBox.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Wybierz zadanie do modyfikacji.");
            }
        }

        private void SearchTasksButton_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                TaskListBox.Items.Clear();
                LoadTasksFromFile();
            }
            {
                var filteredTasks = TaskListBox.Items.Cast<string>()
                    .Where(task => task.ToLower().Contains(searchText))
                    .ToArray();

                TaskListBox.Items.Clear();
                TaskListBox.Items.AddRange(filteredTasks);
            }
        }
    }
}
