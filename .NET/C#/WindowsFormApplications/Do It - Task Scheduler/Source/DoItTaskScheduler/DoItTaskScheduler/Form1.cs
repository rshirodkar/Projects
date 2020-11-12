using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoItTaskScheduler
{
    public partial class Form1 : Form
    {
        // creating instance of default task to pre fill text fields
        private readonly Task defaultTask = new Task();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // method calls to fill the form fields
            FillTaskTabFields();
            FillTimedTaskTabFields();
        }

        /// <summary>
        /// Method to Fill the Timed Scheduled tasks
        /// </summary>
        private void FillTimedTaskTabFields()
        {
            textBoxTimedTaskName.Text = defaultTask.TaskName;
            textBoxTimedTaskDescription.Text = defaultTask.TaskDescription;

            var values = Enum.GetValues(typeof(Task.TaskTypes));
            foreach (var item in values)
            {
                comboBoxTimedTaskCategory.Items.Add(item);
            }
            comboBoxTimedTaskCategory.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to fill the task fields
        /// </summary>
        private void FillTaskTabFields()
        {
            textBoxTaskName.Text = defaultTask.TaskName;
            textBoxTaskDescription.Text = defaultTask.TaskDescription;

            var values = Enum.GetValues(typeof(Task.TaskTypes));
            foreach (var item in values)
            {
                comboBoxTaskCategory.Items.Add(item);
            }
            comboBoxTaskCategory.SelectedIndex = 0;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnCreateTimedTask_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btnViewScheduledTasks_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void btnViewAllTasks_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        /// <summary>
        /// Method to add/create tasks
        /// </summary>
        public void AddTask()
        {
            // we take the inputs from the fields
            var taskName = textBoxTaskName.Text;
            var taskDescription = textBoxTaskDescription.Text;
            var taskCategory = comboBoxTaskCategory.SelectedItem;
            // we run some validity tests on the input data
            var isTaskNameValid = !string.IsNullOrWhiteSpace(taskName);
            var isTaskDescriptionValid = !string.IsNullOrEmpty(taskDescription);
            var isTaskUnique = CheckTaskName(taskName);

            if (isTaskNameValid && isTaskDescriptionValid && isTaskUnique)
            {
                // create a new task with appropriate values
                Task task = new Task
                {
                    TaskName = taskName,
                    TaskDescription = taskDescription,
                    TaskCategory = (Task.TaskTypes)taskCategory,
                    TaskStartDate = Task.NotApplicableString,
                    TaskStopDate = Task.NotApplicableString,
                    TaskStartTime = Task.NotApplicableString,
                    TaskStopTime = Task.NotApplicableString
                };
                //var taskId = task.TaskId;

                var taskMessageString = string.Format("Task : {0} was successfully created ", task.TaskName);
                // update the table
                UpdateTaskTable(taskName, taskDescription, taskCategory.ToString(), Task.NotApplicableString, Task.NotApplicableString);
                // we populate the run list
                PopulateScheduledTasks();
                MessageBox.Show(taskMessageString, "Task Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Method to check if a same task name in already added
        /// </summary>
        /// <param name="taskNameToCheck"></param>
        /// <returns></returns>
        private bool CheckTaskName(string taskNameToCheck)
        {
            bool isTaskUnique = true;

            string searchValue = taskNameToCheck.ToLower();
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridTasks.Rows)
            {
                var cellValueToCheck = row.Cells[0].Value;
                if (cellValueToCheck != null)
                {
                    if (row.Cells[0].Value.ToString().ToLower().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        isTaskUnique = false;
                        MessageBox.Show("Task with same name, already added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }

            return isTaskUnique;
        }

        /// <summary>
        /// Method to clear the task fields
        /// </summary>
        private void ClearTaskFields()
        {
            textBoxTaskName.Clear();
            textBoxTaskDescription.Clear();
        }

        /// <summary>
        /// Method to clear the scheduled task fields
        /// </summary>
        private void ClearScheduledTaskFields()
        {
            textBoxTimedTaskName.Clear();
            textBoxTimedTaskDescription.Clear();
        }

        private void btnResetCreateTaskForm_Click(object sender, EventArgs e)
        {
            ClearTaskFields();
            MessageBox.Show(text: "Fields Cleared", caption: "Notificatin", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        /// <summary>
        /// Method to update the task table by adding row
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskCategory"></param>
        /// <param name="taskStartDatetime"></param>
        /// <param name="taskStopDateTime"></param>
        private void UpdateTaskTable(string taskName, string taskDescription, string taskCategory, string taskStartDatetime, string taskStopDateTime)
        {
            dataGridTasks.Rows.Add(taskName, taskDescription, taskCategory, taskStartDatetime, taskStopDateTime);
        }

        /// <summary>
        /// Method to add/create timed/scheduled tasks
        /// </summary>
        public void AddTimedTask()
        {
            // getting the field values
            var taskName = textBoxTimedTaskName.Text;
            var taskDescription = textBoxTimedTaskDescription.Text;
            var taskCategory = comboBoxTimedTaskCategory.SelectedItem;
            var startDate = taskStartDate.Value.ToShortDateString();
            // we have to format the time as it returns back with milli seconds
            var startTime = string.Format("{0:hh\\:mm\\:ss}", taskStartTime.Value.TimeOfDay);
            var stopDate = taskStopDate.Value.ToShortDateString();
            // we have to format the time as it returns back with milli seconds
            var stopTime = string.Format("{0:hh\\:mm\\:ss}", taskStopTime.Value.TimeOfDay);

            // we do some validity checks
            var isTaskNameValid = !string.IsNullOrWhiteSpace(taskName);
            var isTaskDescriptionValid = !string.IsNullOrEmpty(taskDescription);
            var isTaskUnique = CheckTaskName(taskName);

            if (isTaskNameValid && isTaskDescriptionValid && isTaskUnique)
            {
                // we create a new task object
                Task task = new Task
                {
                    TaskName = taskName,
                    TaskDescription = taskDescription,
                    TaskCategory = (Task.TaskTypes)taskCategory,
                    TaskStartDate = startDate,
                    TaskStartTime = startTime,
                    TaskStopDate = stopDate,
                    TaskStopTime = stopTime
                };
                var taskId = task.TaskId;

                var taskMessageString = string.Format("Task : {0} was successfully created ", task.TaskName);
                UpdateTaskTable(taskName, taskDescription, taskCategory.ToString(), string.Join(" ", task.TaskStartDate, task.TaskStartTime), string.Join(" ", task.TaskStopDate, task.TaskStopTime));
                PopulateScheduledTasks();
                MessageBox.Show(taskMessageString);
            }
        }

        private void btnAddTimedTask_Click(object sender, EventArgs e)
        {
            AddTimedTask();
        }

        private void btnClearAllTaskLog_Click_1(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure, you want to delete all the tasks?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                dataGridTasks.Rows.Clear();
                cmbBoxTaskToRun.Items.Clear();
                MessageBox.Show(text: "Tasks Cleared", caption: "Notification", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Method to populate the combo box with tasks which can be run
        /// </summary>
        private void PopulateScheduledTasks()
        {
            //var collection = dataGridTasks.Columns[0];
            // we go through each row's 1st column to get the name of the task and populate them
            foreach (DataGridViewRow row in dataGridTasks.Rows)
            {
                var cellValueToCheck = row.Cells[0].Value;
                if (cellValueToCheck != null)
                {
                    cmbBoxTaskToRun.Items.Add(cellValueToCheck.ToString());
                }
            }
            cmbBoxTaskToRun.SelectedIndex = 0;
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            StartTask();
        }

        /// <summary>
        /// Method to start a task
        /// </summary>
        public void StartTask()
        {
            if (cmbBoxTaskToRun.SelectedItem != null)
            {
                MessageBox.Show("Starting Task : " + cmbBoxTaskToRun.Text, "Start Task", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // we update the lablel to show the status of the task
                lblTaskStatus.Text = "RUNNING";
                lblTaskStatus.ForeColor = Color.Green;
                // we start the progress bar animation
                toolStripProgressBar1.MarqueeAnimationSpeed = 50;
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar1.Value = 100;
                // we disable and enable appropriate fields
                btnStartTask.Enabled =
                cmbBoxTaskToRun.Enabled = false;
                btnStopTask.Enabled = true;
            }
        }

        public void StopTask()
        {
            if (lblTaskStatus.Text == "RUNNING")
            {
                // we update the task status label
                lblTaskStatus.Text = "NOT RUNNING";
                lblTaskStatus.ForeColor = Color.Red;
                // we update the progress bar animation
                toolStripProgressBar1.MarqueeAnimationSpeed = 0;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                // we enable and disable fields
                btnStartTask.Enabled =
                cmbBoxTaskToRun.Enabled = true;
                btnStopTask.Enabled = false;

                MessageBox.Show("Task : " + cmbBoxTaskToRun.Text + " is now completed", "Task Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStopTask_Click(object sender, EventArgs e)
        {
            StopTask();
        }

        private void btnResetCreateTimedTaskForm_Click(object sender, EventArgs e)
        {
            ClearScheduledTaskFields();
            MessageBox.Show(text: "Fields Cleared", caption: "Notification", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
    }
}