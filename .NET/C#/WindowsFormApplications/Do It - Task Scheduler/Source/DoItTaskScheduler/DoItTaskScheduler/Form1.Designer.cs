namespace DoItTaskScheduler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAllTasks = new System.Windows.Forms.Button();
            this.btnViewScheduledTasks = new System.Windows.Forms.Button();
            this.btnCreateTimedTask = new System.Windows.Forms.Button();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCreateTask = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.comboBoxTaskCategory = new System.Windows.Forms.ComboBox();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.btnResetCreateTaskForm = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageCreateTimedTask = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskStopTime = new System.Windows.Forms.DateTimePicker();
            this.taskStopDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.taskStartTime = new System.Windows.Forms.DateTimePicker();
            this.taskStartDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTimedTaskDescription = new System.Windows.Forms.TextBox();
            this.comboBoxTimedTaskCategory = new System.Windows.Forms.ComboBox();
            this.textBoxTimedTaskName = new System.Windows.Forms.TextBox();
            this.btnResetCreateTimedTaskForm = new System.Windows.Forms.Button();
            this.btnAddTimedTask = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageRunTask = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbBoxTaskToRun = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageViewAllTask = new System.Windows.Forms.TabPage();
            this.btnClearAllTaskLog = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridTasks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnStopTask = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCreateTask.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageCreateTimedTask.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageRunTask.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageViewAllTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnViewAllTasks);
            this.panel1.Controls.Add(this.btnViewScheduledTasks);
            this.panel1.Controls.Add(this.btnCreateTimedTask);
            this.panel1.Controls.Add(this.btnCreateTask);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 564);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 62);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAllTasks
            // 
            this.btnViewAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllTasks.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllTasks.Location = new System.Drawing.Point(3, 306);
            this.btnViewAllTasks.Name = "btnViewAllTasks";
            this.btnViewAllTasks.Size = new System.Drawing.Size(197, 62);
            this.btnViewAllTasks.TabIndex = 5;
            this.btnViewAllTasks.Text = "View All Tasks";
            this.btnViewAllTasks.UseVisualStyleBackColor = true;
            this.btnViewAllTasks.Click += new System.EventHandler(this.btnViewAllTasks_Click);
            // 
            // btnViewScheduledTasks
            // 
            this.btnViewScheduledTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewScheduledTasks.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScheduledTasks.Location = new System.Drawing.Point(3, 238);
            this.btnViewScheduledTasks.Name = "btnViewScheduledTasks";
            this.btnViewScheduledTasks.Size = new System.Drawing.Size(197, 62);
            this.btnViewScheduledTasks.TabIndex = 4;
            this.btnViewScheduledTasks.Text = "Run Task";
            this.btnViewScheduledTasks.UseVisualStyleBackColor = true;
            this.btnViewScheduledTasks.Click += new System.EventHandler(this.btnViewScheduledTasks_Click);
            // 
            // btnCreateTimedTask
            // 
            this.btnCreateTimedTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTimedTask.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTimedTask.Location = new System.Drawing.Point(3, 170);
            this.btnCreateTimedTask.Name = "btnCreateTimedTask";
            this.btnCreateTimedTask.Size = new System.Drawing.Size(197, 62);
            this.btnCreateTimedTask.TabIndex = 3;
            this.btnCreateTimedTask.Text = "Create Timed Task";
            this.btnCreateTimedTask.UseVisualStyleBackColor = true;
            this.btnCreateTimedTask.Click += new System.EventHandler(this.btnCreateTimedTask_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTask.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTask.Location = new System.Drawing.Point(3, 102);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(197, 62);
            this.btnCreateTask.TabIndex = 2;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 54);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DO IT";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCreateTask);
            this.tabControl.Controls.Add(this.tabPageCreateTimedTask);
            this.tabControl.Controls.Add(this.tabPageRunTask);
            this.tabControl.Controls.Add(this.tabPageViewAllTask);
            this.tabControl.Location = new System.Drawing.Point(212, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(806, 509);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageCreateTask
            // 
            this.tabPageCreateTask.Controls.Add(this.label8);
            this.tabPageCreateTask.Controls.Add(this.groupBox2);
            this.tabPageCreateTask.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateTask.Name = "tabPageCreateTask";
            this.tabPageCreateTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateTask.Size = new System.Drawing.Size(798, 483);
            this.tabPageCreateTask.TabIndex = 0;
            this.tabPageCreateTask.Text = "Create Task";
            this.tabPageCreateTask.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "CREATE TASK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTaskDescription);
            this.groupBox2.Controls.Add(this.comboBoxTaskCategory);
            this.groupBox2.Controls.Add(this.textBoxTaskName);
            this.groupBox2.Controls.Add(this.btnResetCreateTaskForm);
            this.groupBox2.Controls.Add(this.btnAddTask);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(159, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 423);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.Location = new System.Drawing.Point(181, 176);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(232, 110);
            this.textBoxTaskDescription.TabIndex = 7;
            // 
            // comboBoxTaskCategory
            // 
            this.comboBoxTaskCategory.FormattingEnabled = true;
            this.comboBoxTaskCategory.Location = new System.Drawing.Point(181, 124);
            this.comboBoxTaskCategory.Name = "comboBoxTaskCategory";
            this.comboBoxTaskCategory.Size = new System.Drawing.Size(232, 21);
            this.comboBoxTaskCategory.TabIndex = 6;
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(181, 66);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(232, 22);
            this.textBoxTaskName.TabIndex = 5;
            // 
            // btnResetCreateTaskForm
            // 
            this.btnResetCreateTaskForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCreateTaskForm.Location = new System.Drawing.Point(301, 353);
            this.btnResetCreateTaskForm.Name = "btnResetCreateTaskForm";
            this.btnResetCreateTaskForm.Size = new System.Drawing.Size(75, 35);
            this.btnResetCreateTaskForm.TabIndex = 4;
            this.btnResetCreateTaskForm.Text = "Reset";
            this.btnResetCreateTaskForm.UseVisualStyleBackColor = true;
            this.btnResetCreateTaskForm.Click += new System.EventHandler(this.btnResetCreateTaskForm_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(100, 353);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(91, 35);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Task Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Task Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Task Name:";
            // 
            // tabPageCreateTimedTask
            // 
            this.tabPageCreateTimedTask.Controls.Add(this.groupBox1);
            this.tabPageCreateTimedTask.Controls.Add(this.label9);
            this.tabPageCreateTimedTask.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateTimedTask.Name = "tabPageCreateTimedTask";
            this.tabPageCreateTimedTask.Size = new System.Drawing.Size(798, 483);
            this.tabPageCreateTimedTask.TabIndex = 1;
            this.tabPageCreateTimedTask.Text = "Create Timed Task";
            this.tabPageCreateTimedTask.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taskStopTime);
            this.groupBox1.Controls.Add(this.taskStopDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.taskStartTime);
            this.groupBox1.Controls.Add(this.taskStartDate);
            this.groupBox1.Controls.Add(this.textBoxTimedTaskDescription);
            this.groupBox1.Controls.Add(this.comboBoxTimedTaskCategory);
            this.groupBox1.Controls.Add(this.textBoxTimedTaskName);
            this.groupBox1.Controls.Add(this.btnResetCreateTimedTaskForm);
            this.groupBox1.Controls.Add(this.btnAddTimedTask);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(166, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 396);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // taskStopTime
            // 
            this.taskStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskStopTime.Location = new System.Drawing.Point(322, 297);
            this.taskStopTime.Name = "taskStopTime";
            this.taskStopTime.ShowUpDown = true;
            this.taskStopTime.Size = new System.Drawing.Size(108, 22);
            this.taskStopTime.TabIndex = 22;
            // 
            // taskStopDate
            // 
            this.taskStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.taskStopDate.Location = new System.Drawing.Point(198, 296);
            this.taskStopDate.Name = "taskStopDate";
            this.taskStopDate.Size = new System.Drawing.Size(102, 22);
            this.taskStopDate.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Task Stop Task:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Task Start Time:";
            // 
            // taskStartTime
            // 
            this.taskStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskStartTime.Location = new System.Drawing.Point(322, 261);
            this.taskStartTime.Name = "taskStartTime";
            this.taskStartTime.ShowUpDown = true;
            this.taskStartTime.Size = new System.Drawing.Size(108, 22);
            this.taskStartTime.TabIndex = 18;
            // 
            // taskStartDate
            // 
            this.taskStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.taskStartDate.Location = new System.Drawing.Point(198, 260);
            this.taskStartDate.Name = "taskStartDate";
            this.taskStartDate.Size = new System.Drawing.Size(102, 22);
            this.taskStartDate.TabIndex = 17;
            // 
            // textBoxTimedTaskDescription
            // 
            this.textBoxTimedTaskDescription.Location = new System.Drawing.Point(198, 133);
            this.textBoxTimedTaskDescription.Multiline = true;
            this.textBoxTimedTaskDescription.Name = "textBoxTimedTaskDescription";
            this.textBoxTimedTaskDescription.Size = new System.Drawing.Size(232, 110);
            this.textBoxTimedTaskDescription.TabIndex = 15;
            // 
            // comboBoxTimedTaskCategory
            // 
            this.comboBoxTimedTaskCategory.FormattingEnabled = true;
            this.comboBoxTimedTaskCategory.Location = new System.Drawing.Point(198, 81);
            this.comboBoxTimedTaskCategory.Name = "comboBoxTimedTaskCategory";
            this.comboBoxTimedTaskCategory.Size = new System.Drawing.Size(232, 21);
            this.comboBoxTimedTaskCategory.TabIndex = 14;
            // 
            // textBoxTimedTaskName
            // 
            this.textBoxTimedTaskName.Location = new System.Drawing.Point(198, 23);
            this.textBoxTimedTaskName.Name = "textBoxTimedTaskName";
            this.textBoxTimedTaskName.Size = new System.Drawing.Size(232, 22);
            this.textBoxTimedTaskName.TabIndex = 13;
            // 
            // btnResetCreateTimedTaskForm
            // 
            this.btnResetCreateTimedTaskForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCreateTimedTaskForm.Location = new System.Drawing.Point(299, 349);
            this.btnResetCreateTimedTaskForm.Name = "btnResetCreateTimedTaskForm";
            this.btnResetCreateTimedTaskForm.Size = new System.Drawing.Size(75, 28);
            this.btnResetCreateTimedTaskForm.TabIndex = 12;
            this.btnResetCreateTimedTaskForm.Text = "Reset";
            this.btnResetCreateTimedTaskForm.UseVisualStyleBackColor = true;
            this.btnResetCreateTimedTaskForm.Click += new System.EventHandler(this.btnResetCreateTimedTaskForm_Click);
            // 
            // btnAddTimedTask
            // 
            this.btnAddTimedTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimedTask.Location = new System.Drawing.Point(106, 349);
            this.btnAddTimedTask.Name = "btnAddTimedTask";
            this.btnAddTimedTask.Size = new System.Drawing.Size(75, 28);
            this.btnAddTimedTask.TabIndex = 11;
            this.btnAddTimedTask.Text = "Add Task";
            this.btnAddTimedTask.UseVisualStyleBackColor = true;
            this.btnAddTimedTask.Click += new System.EventHandler(this.btnAddTimedTask_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Task Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Task Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Task Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "CREATE TIMED TASK";
            // 
            // tabPageRunTask
            // 
            this.tabPageRunTask.Controls.Add(this.groupBox3);
            this.tabPageRunTask.Controls.Add(this.label12);
            this.tabPageRunTask.Location = new System.Drawing.Point(4, 22);
            this.tabPageRunTask.Name = "tabPageRunTask";
            this.tabPageRunTask.Size = new System.Drawing.Size(798, 483);
            this.tabPageRunTask.TabIndex = 2;
            this.tabPageRunTask.Text = "Run Task";
            this.tabPageRunTask.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStopTask);
            this.groupBox3.Controls.Add(this.btnStartTask);
            this.groupBox3.Controls.Add(this.lblTaskStatus);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbBoxTaskToRun);
            this.groupBox3.Location = new System.Drawing.Point(110, 75);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(573, 313);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.ForeColor = System.Drawing.Color.Red;
            this.lblTaskStatus.Location = new System.Drawing.Point(387, 93);
            this.lblTaskStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(103, 16);
            this.lblTaskStatus.TabIndex = 23;
            this.lblTaskStatus.Text = "NOT RUNNING";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(62, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "Task To Run";
            // 
            // cmbBoxTaskToRun
            // 
            this.cmbBoxTaskToRun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTaskToRun.FormattingEnabled = true;
            this.cmbBoxTaskToRun.Location = new System.Drawing.Point(191, 88);
            this.cmbBoxTaskToRun.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxTaskToRun.Name = "cmbBoxTaskToRun";
            this.cmbBoxTaskToRun.Size = new System.Drawing.Size(182, 21);
            this.cmbBoxTaskToRun.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(308, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Run Single Task";
            // 
            // tabPageViewAllTask
            // 
            this.tabPageViewAllTask.Controls.Add(this.btnClearAllTaskLog);
            this.tabPageViewAllTask.Controls.Add(this.label13);
            this.tabPageViewAllTask.Controls.Add(this.dataGridTasks);
            this.tabPageViewAllTask.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewAllTask.Name = "tabPageViewAllTask";
            this.tabPageViewAllTask.Size = new System.Drawing.Size(798, 483);
            this.tabPageViewAllTask.TabIndex = 3;
            this.tabPageViewAllTask.Text = "View All Tasks";
            this.tabPageViewAllTask.UseVisualStyleBackColor = true;
            // 
            // btnClearAllTaskLog
            // 
            this.btnClearAllTaskLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllTaskLog.Location = new System.Drawing.Point(339, 432);
            this.btnClearAllTaskLog.Name = "btnClearAllTaskLog";
            this.btnClearAllTaskLog.Size = new System.Drawing.Size(98, 28);
            this.btnClearAllTaskLog.TabIndex = 20;
            this.btnClearAllTaskLog.Text = "Clear Log";
            this.btnClearAllTaskLog.UseVisualStyleBackColor = true;
            this.btnClearAllTaskLog.Click += new System.EventHandler(this.btnClearAllTaskLog_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(335, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "ALL TASKS";
            // 
            // dataGridTasks
            // 
            this.dataGridTasks.AllowUserToAddRows = false;
            this.dataGridTasks.AllowUserToDeleteRows = false;
            this.dataGridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTasks.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridTasks.Location = new System.Drawing.Point(26, 48);
            this.dataGridTasks.Name = "dataGridTasks";
            this.dataGridTasks.ReadOnly = true;
            this.dataGridTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTasks.Size = new System.Drawing.Size(756, 378);
            this.dataGridTasks.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Task Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Task Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Task Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Task Start DateTime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Task Stop DateTime";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(205, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(35, 3, 1, 3);
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 50;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(700, 16);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Location = new System.Drawing.Point(225, 169);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(107, 31);
            this.btnStartTask.TabIndex = 24;
            this.btnStartTask.Text = "START TASK";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnStopTask
            // 
            this.btnStopTask.Enabled = false;
            this.btnStopTask.Location = new System.Drawing.Point(225, 219);
            this.btnStopTask.Name = "btnStopTask";
            this.btnStopTask.Size = new System.Drawing.Size(107, 31);
            this.btnStopTask.TabIndex = 25;
            this.btnStopTask.Text = "STOP TASK";
            this.btnStopTask.UseVisualStyleBackColor = true;
            this.btnStopTask.Click += new System.EventHandler(this.btnStopTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 564);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Do It - A Simple Task Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageCreateTask.ResumeLayout(false);
            this.tabPageCreateTask.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageCreateTimedTask.ResumeLayout(false);
            this.tabPageCreateTimedTask.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageRunTask.ResumeLayout(false);
            this.tabPageRunTask.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageViewAllTask.ResumeLayout(false);
            this.tabPageViewAllTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewAllTasks;
        private System.Windows.Forms.Button btnViewScheduledTasks;
        private System.Windows.Forms.Button btnCreateTimedTask;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCreateTask;
        private System.Windows.Forms.TabPage tabPageCreateTimedTask;
        private System.Windows.Forms.TabPage tabPageRunTask;
        private System.Windows.Forms.TabPage tabPageViewAllTask;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnResetCreateTaskForm;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTaskCategory;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.TextBox textBoxTimedTaskDescription;
        private System.Windows.Forms.ComboBox comboBoxTimedTaskCategory;
        private System.Windows.Forms.TextBox textBoxTimedTaskName;
        private System.Windows.Forms.Button btnResetCreateTimedTaskForm;
        private System.Windows.Forms.Button btnAddTimedTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker taskStartTime;
        private System.Windows.Forms.DateTimePicker taskStartDate;
        private System.Windows.Forms.DataGridView dataGridTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker taskStopTime;
        private System.Windows.Forms.DateTimePicker taskStopDate;
        private System.Windows.Forms.ComboBox cmbBoxTaskToRun;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnClearAllTaskLog;
        private System.Windows.Forms.Button btnStopTask;
        private System.Windows.Forms.Button btnStartTask;
    }
}

