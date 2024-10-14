namespace ph{

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Declare controls (Task management screen elements)
        private DataGridView taskDataGridView;
        private TextBox taskNameTextBox;
        private TextBox taskDescriptionTextBox;
        private DateTimePicker deadlinePicker;
        private ComboBox priorityComboBox;
        private Button addTaskButton;
        private Button saveProjectButton;
        private Button loadProjectButton;
        private Button markCompleteButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Initialize and configure controls

            // DataGridView for displaying tasks
            this.taskDataGridView = new DataGridView();
            this.taskDataGridView.Location = new System.Drawing.Point(50, 50);
            this.taskDataGridView.Size = new System.Drawing.Size(500, 200);
            this.taskDataGridView.Columns.Add("TaskName", "Task Name");
            this.taskDataGridView.Columns.Add("Description", "Description");
            this.taskDataGridView.Columns.Add("Deadline", "Deadline");
            this.taskDataGridView.Columns.Add("Priority", "Priority");

            // Task Name TextBox
            this.taskNameTextBox = new TextBox();
            this.taskNameTextBox.Location = new System.Drawing.Point(50, 270);
            this.taskNameTextBox.Size = new System.Drawing.Size(200, 30);
            this.taskNameTextBox.PlaceholderText = "Enter Task Name";

            // Task Description TextBox
            this.taskDescriptionTextBox = new TextBox();
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(50, 310);
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(200, 60);
            this.taskDescriptionTextBox.PlaceholderText = "Enter Task Description";
            this.taskDescriptionTextBox.Multiline = true;

            // Deadline DateTimePicker
            this.deadlinePicker = new DateTimePicker();
            this.deadlinePicker.Location = new System.Drawing.Point(270, 270);
            this.deadlinePicker.Size = new System.Drawing.Size(200, 30);

            // Priority ComboBox
            this.priorityComboBox = new ComboBox();
            this.priorityComboBox.Location = new System.Drawing.Point(270, 310);
            this.priorityComboBox.Size = new System.Drawing.Size(200, 30);
            this.priorityComboBox.Items.AddRange(new string[] { "Low", "Medium", "High" });

            // Add Task Button
            this.addTaskButton = new Button();
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.Location = new System.Drawing.Point(50, 380);
            this.addTaskButton.Size = new System.Drawing.Size(100, 30);
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);

            // Save Project Button
            this.saveProjectButton = new Button();
            this.saveProjectButton.Text = "Save Project";
            this.saveProjectButton.Location = new System.Drawing.Point(160, 380);
            this.saveProjectButton.Size = new System.Drawing.Size(100, 30);
            this.saveProjectButton.Click += new System.EventHandler(this.SaveProjectButton_Click);

            // Load Project Button
            this.loadProjectButton = new Button();
            this.loadProjectButton.Text = "Load Project";
            this.loadProjectButton.Location = new System.Drawing.Point(270, 380);
            this.loadProjectButton.Size = new System.Drawing.Size(100, 30);
            this.loadProjectButton.Click += new System.EventHandler(this.LoadProjectButton_Click);

            // Mark Complete Button
            this.markCompleteButton = new Button();
            this.markCompleteButton.Text = "Mark Complete";
            this.markCompleteButton.Location = new System.Drawing.Point(380, 380);
            this.markCompleteButton.Size = new System.Drawing.Size(120, 30);
            this.markCompleteButton.Click += new System.EventHandler(this.MarkCompleteButton_Click);

            // Add all the controls to the form
            this.Controls.Add(this.taskDataGridView);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.taskDescriptionTextBox);
            this.Controls.Add(this.deadlinePicker);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.saveProjectButton);
            this.Controls.Add(this.loadProjectButton);
            this.Controls.Add(this.markCompleteButton);

            // Form Properties
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Project Management";
        }

        #endregion
    }
}
