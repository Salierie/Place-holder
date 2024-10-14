using System.CodeDom;

namespace ph;

public partial class Form1 : Form
{
    private string userRole; // This will be set during login
    public Form1(string userRole)
    {
        InitializeComponent();
        this.userRole = userRole;
        LoadDashboard();
    }
    public void LoadDashboard(){
        if (userRole == "Employee"){
            ShowEmployeeDashboard();
        }else if (userRole == "Project Manager"){
            ShowPMDashboard();
        }else{
            Console.WriteLine("Unknown user role");
        }
    }
    public void ShowEmployeeDashboard(){
        Button taskAssignmentsButton = new Button
        {
            Text = "Task Assignments",
            Location = new System.Drawing.Point(50, 50),
            Size = new System.Drawing.Size(200, 40)
        };
        taskAssignmentsButton.Click += TaskAssignmentsButton_Click;

        Button ganttChartButton = new Button
        {
            Text = "Gantt Chart",
            Location = new System.Drawing.Point(50, 100),
            Size = new System.Drawing.Size(200, 40)
        };
        ganttChartButton.Click += GanttChartButton_Click;

        this.Controls.Add(taskAssignmentsButton);
        this.Controls.Add(ganttChartButton);        
    }
    public void ShowPMDashboard(){
        Button taskAssignmentsButton = new Button
        {
            Text = "Task Assignments",
            Location = new System.Drawing.Point(50, 50),
            Size = new System.Drawing.Size(200, 40)
        };
        taskAssignmentsButton.Click += ProjectManagerTaskAssignmentsButton_Click;

        Button ganttChartButton = new Button
        {
            Text = "Gantt Chart",
            Location = new System.Drawing.Point(50, 100),
            Size = new System.Drawing.Size(200, 40)
        };
        ganttChartButton.Click += ProjectManagerGanttChartButton_Click;

        Button dashboardButton = new Button
        {
            Text = "Dashboard",
            Location = new System.Drawing.Point(50, 150),
            Size = new System.Drawing.Size(200, 40)
        };
        dashboardButton.Click += DashboardButton_Click;

        this.Controls.Add(taskAssignmentsButton);
        this.Controls.Add(ganttChartButton);
        this.Controls.Add(dashboardButton);
    }

    public void TaskAssignmentsButton_Click(object sender, EventArgs e){
        MessageBox.Show("Opening Employee Task Assessment...");
    }
    public void ProjectManagerTaskAssignmentsButton_Click(object sender, EventArgs e){
        MessageBox.Show("Opening PM Task Assessment...");
    }
    public void GanttChartButton_Click(object sender, EventArgs e){
        MessageBox.Show("Employee Gantt chart...");
    }
    public void ProjectManagerGanttChartButton_Click(object sender, EventArgs e){
        MessageBox.Show("PM Gantt chart...");
    }
    public void DashboardButton_Click(object sender, EventArgs e){
        MessageBox.Show("Opening Project Manager Dashboard...");
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
