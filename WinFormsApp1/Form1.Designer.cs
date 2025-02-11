namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TaskInputTextBox = new TextBox();
            TaskListBox = new ListBox();
            AddTaskButton = new Button();
            DeleteTaskButton = new Button();
            EditTaskButton = new Button();
            TaskSurnameTextBox = new TextBox();
            TaskProfessionTextBox = new TextBox();
            SearchTasksButton = new Button();
            SearchTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Podaj rzecz do wykonania:";
            // 
            // TaskInputTextBox
            // 
            TaskInputTextBox.Location = new Point(12, 27);
            TaskInputTextBox.Name = "TaskInputTextBox";
            TaskInputTextBox.PlaceholderText = "Imię";
            TaskInputTextBox.Size = new Size(641, 23);
            TaskInputTextBox.TabIndex = 1;
            // 
            // TaskListBox
            // 
            TaskListBox.FormattingEnabled = true;
            TaskListBox.ItemHeight = 15;
            TaskListBox.Location = new Point(12, 115);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(776, 274);
            TaskListBox.TabIndex = 2;
            // 
            // AddTaskButton
            // 
            AddTaskButton.Location = new Point(659, 27);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(129, 23);
            AddTaskButton.TabIndex = 3;
            AddTaskButton.Text = "Dodaj";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // DeleteTaskButton
            // 
            DeleteTaskButton.Location = new Point(659, 56);
            DeleteTaskButton.Name = "DeleteTaskButton";
            DeleteTaskButton.Size = new Size(129, 23);
            DeleteTaskButton.TabIndex = 4;
            DeleteTaskButton.Text = "Usuń";
            DeleteTaskButton.UseVisualStyleBackColor = true;
            DeleteTaskButton.Click += DeleteTaskButton_Click;
            // 
            // EditTaskButton
            // 
            EditTaskButton.Location = new Point(659, 86);
            EditTaskButton.Name = "EditTaskButton";
            EditTaskButton.Size = new Size(129, 23);
            EditTaskButton.TabIndex = 5;
            EditTaskButton.Text = "Edycja";
            EditTaskButton.UseVisualStyleBackColor = true;
            EditTaskButton.Click += EditTaskButton_Click;
            // 
            // TaskSurnameTextBox
            // 
            TaskSurnameTextBox.Location = new Point(12, 57);
            TaskSurnameTextBox.Name = "TaskSurnameTextBox";
            TaskSurnameTextBox.PlaceholderText = "Nazwisko";
            TaskSurnameTextBox.Size = new Size(641, 23);
            TaskSurnameTextBox.TabIndex = 6;
            // 
            // TaskProfessionTextBox
            // 
            TaskProfessionTextBox.Location = new Point(12, 86);
            TaskProfessionTextBox.Name = "TaskProfessionTextBox";
            TaskProfessionTextBox.PlaceholderText = "Zawód";
            TaskProfessionTextBox.Size = new Size(641, 23);
            TaskProfessionTextBox.TabIndex = 7;
            // 
            // SearchTasksButton
            // 
            SearchTasksButton.Location = new Point(659, 395);
            SearchTasksButton.Name = "SearchTasksButton";
            SearchTasksButton.RightToLeft = RightToLeft.No;
            SearchTasksButton.Size = new Size(129, 23);
            SearchTasksButton.TabIndex = 8;
            SearchTasksButton.Text = "Wyszukaj";
            SearchTasksButton.UseVisualStyleBackColor = true;
            SearchTasksButton.Click += SearchTasksButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(12, 395);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Wyszukaj...";
            SearchTextBox.Size = new Size(641, 23);
            SearchTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchTasksButton);
            Controls.Add(TaskProfessionTextBox);
            Controls.Add(TaskSurnameTextBox);
            Controls.Add(EditTaskButton);
            Controls.Add(DeleteTaskButton);
            Controls.Add(AddTaskButton);
            Controls.Add(TaskListBox);
            Controls.Add(TaskInputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TaskInputTextBox;
        private ListBox TaskListBox;
        private Button AddTaskButton;
        private Button DeleteTaskButton;
        private Button EditTaskButton;
        private TextBox TaskSurnameTextBox;
        private TextBox TaskProfessionTextBox;
        private Button SearchTasksButton;
        private TextBox SearchTextBox;
    }
}
