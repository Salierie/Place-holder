namespace ph
{
    partial class ProjectManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button taskAssignmentsButton;
        private Button ganttChartButton;
        private Button dashboardButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.taskAssignmentsButton = new Button();
            this.ganttChartButton = new Button();
            this.dashboardButton = new Button();

            // Task Assignments Button
            this.taskAssignmentsButton.Text = "Task Assignments";
            this.taskAssignmentsButton.Location = new System.Drawing.Point(50, 50);
            this.taskAssignmentsButton.Click += new System.EventHandler(this.TaskAssignmentsButton_Click);

            // Gantt Chart Button
            this.ganttChartButton.Text = "Gantt Chart";
            this.ganttChartButton.Location = new System.Drawing.Point(50, 100);
            this.ganttChartButton.Click += new System.EventHandler(this.GanttChartButton_Click);

            // Dashboard Button
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.Location = new System.Drawing.Point(50, 150);
            this.dashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);

            // ProjectManagerForm Properties
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.taskAssignmentsButton);
            this.Controls.Add(this.ganttChartButton);
            this.Controls.Add(this.dashboardButton);
            this.Text = "Project Manager Dashboard";
        }
    }
}
