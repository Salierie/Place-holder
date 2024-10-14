namespace ph;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
        // Event handler for adding a task to the DataGridView
    private void AddTaskButton_Click(object sender, EventArgs e)
    {
        string taskName = this.taskNameTextBox.Text;
        string description = this.taskDescriptionTextBox.Text;
        DateTime deadline = this.deadlinePicker.Value;
        string priority = this.priorityComboBox.SelectedItem?.ToString();

        // Add task details to DataGridView (check for empty fields first)
        if (!string.IsNullOrEmpty(taskName) && !string.IsNullOrEmpty(priority))
        {
            this.taskDataGridView.Rows.Add(taskName, description, deadline.ToShortDateString(), priority);

            // Clear input fields after adding
            this.taskNameTextBox.Clear();
            this.taskDescriptionTextBox.Clear();
            this.priorityComboBox.SelectedIndex = -1;
        }
        else
        {
            MessageBox.Show("Please enter task details and priority.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Placeholder event handler for saving the project
    private void SaveProjectButton_Click(object sender, EventArgs e)
    {
        // TODO: Implement save project functionality
        MessageBox.Show("Save project functionality will be implemented here.");
    }

    // Placeholder event handler for loading the project
    private void LoadProjectButton_Click(object sender, EventArgs e)
    {
        // TODO: Implement load project functionality
        MessageBox.Show("Load project functionality will be implemented here.");
    }

    // Event handler for marking a task as complete
    private void MarkCompleteButton_Click(object sender, EventArgs e)
    {
        if (this.taskDataGridView.SelectedRows.Count > 0)
        {
            var selectedRow = this.taskDataGridView.SelectedRows[0];
            selectedRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            MessageBox.Show("Task marked as complete!");
        }
        else
        {
            MessageBox.Show("Please select a task to mark as complete.");
        }
    }    
}
