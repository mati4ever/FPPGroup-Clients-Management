namespace FPPGroup_Clients_Management
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.todayTasks_label = new System.Windows.Forms.Label();
            this.todayTask_listbox = new System.Windows.Forms.ListBox();
            this.closeTasks_label = new System.Windows.Forms.Label();
            this.closeTasks_listbox = new System.Windows.Forms.ListBox();
            this.taskDone_button = new System.Windows.Forms.Button();
            this.taskDelay_button = new System.Windows.Forms.Button();
            this.missedTasks_label = new System.Windows.Forms.Label();
            this.misedTask_listbox = new System.Windows.Forms.ListBox();
            this.taskDoen1_button = new System.Windows.Forms.Button();
            this.removeTask_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todayTasks_label
            // 
            this.todayTasks_label.AutoSize = true;
            this.todayTasks_label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.todayTasks_label.Location = new System.Drawing.Point(12, 9);
            this.todayTasks_label.Name = "todayTasks_label";
            this.todayTasks_label.Size = new System.Drawing.Size(197, 30);
            this.todayTasks_label.TabIndex = 1;
            this.todayTasks_label.Text = "Zadania na dziś";
            // 
            // todayTask_listbox
            // 
            this.todayTask_listbox.FormattingEnabled = true;
            this.todayTask_listbox.ItemHeight = 23;
            this.todayTask_listbox.Location = new System.Drawing.Point(17, 42);
            this.todayTask_listbox.Name = "todayTask_listbox";
            this.todayTask_listbox.Size = new System.Drawing.Size(824, 96);
            this.todayTask_listbox.TabIndex = 2;
            // 
            // closeTasks_label
            // 
            this.closeTasks_label.AutoSize = true;
            this.closeTasks_label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeTasks_label.Location = new System.Drawing.Point(12, 149);
            this.closeTasks_label.Name = "closeTasks_label";
            this.closeTasks_label.Size = new System.Drawing.Size(170, 30);
            this.closeTasks_label.TabIndex = 1;
            this.closeTasks_label.Text = "Najbliższe dni";
            // 
            // closeTasks_listbox
            // 
            this.closeTasks_listbox.FormattingEnabled = true;
            this.closeTasks_listbox.ItemHeight = 23;
            this.closeTasks_listbox.Location = new System.Drawing.Point(17, 182);
            this.closeTasks_listbox.Name = "closeTasks_listbox";
            this.closeTasks_listbox.Size = new System.Drawing.Size(824, 165);
            this.closeTasks_listbox.TabIndex = 2;
            // 
            // taskDone_button
            // 
            this.taskDone_button.FlatAppearance.BorderSize = 0;
            this.taskDone_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDone_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDone_button.Image")));
            this.taskDone_button.Location = new System.Drawing.Point(847, 182);
            this.taskDone_button.Name = "taskDone_button";
            this.taskDone_button.Size = new System.Drawing.Size(74, 48);
            this.taskDone_button.TabIndex = 5;
            this.taskDone_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDone_button.UseVisualStyleBackColor = true;
            // 
            // taskDelay_button
            // 
            this.taskDelay_button.FlatAppearance.BorderSize = 0;
            this.taskDelay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDelay_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDelay_button.Image")));
            this.taskDelay_button.Location = new System.Drawing.Point(847, 230);
            this.taskDelay_button.Name = "taskDelay_button";
            this.taskDelay_button.Size = new System.Drawing.Size(74, 48);
            this.taskDelay_button.TabIndex = 5;
            this.taskDelay_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDelay_button.UseVisualStyleBackColor = true;
            // 
            // missedTasks_label
            // 
            this.missedTasks_label.AutoSize = true;
            this.missedTasks_label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.missedTasks_label.Location = new System.Drawing.Point(12, 369);
            this.missedTasks_label.Name = "missedTasks_label";
            this.missedTasks_label.Size = new System.Drawing.Size(134, 30);
            this.missedTasks_label.TabIndex = 1;
            this.missedTasks_label.Text = "Pominięte";
            // 
            // misedTask_listbox
            // 
            this.misedTask_listbox.FormattingEnabled = true;
            this.misedTask_listbox.ItemHeight = 23;
            this.misedTask_listbox.Location = new System.Drawing.Point(17, 402);
            this.misedTask_listbox.Name = "misedTask_listbox";
            this.misedTask_listbox.Size = new System.Drawing.Size(824, 96);
            this.misedTask_listbox.TabIndex = 2;
            // 
            // taskDoen1_button
            // 
            this.taskDoen1_button.FlatAppearance.BorderSize = 0;
            this.taskDoen1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDoen1_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDoen1_button.Image")));
            this.taskDoen1_button.Location = new System.Drawing.Point(847, 402);
            this.taskDoen1_button.Name = "taskDoen1_button";
            this.taskDoen1_button.Size = new System.Drawing.Size(74, 48);
            this.taskDoen1_button.TabIndex = 5;
            this.taskDoen1_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDoen1_button.UseVisualStyleBackColor = true;
            // 
            // removeTask_button
            // 
            this.removeTask_button.FlatAppearance.BorderSize = 0;
            this.removeTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTask_button.Image = ((System.Drawing.Image)(resources.GetObject("removeTask_button.Image")));
            this.removeTask_button.Location = new System.Drawing.Point(847, 450);
            this.removeTask_button.Name = "removeTask_button";
            this.removeTask_button.Size = new System.Drawing.Size(74, 48);
            this.removeTask_button.TabIndex = 5;
            this.removeTask_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.removeTask_button.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.taskDelay_button);
            this.Controls.Add(this.removeTask_button);
            this.Controls.Add(this.taskDoen1_button);
            this.Controls.Add(this.taskDone_button);
            this.Controls.Add(this.closeTasks_listbox);
            this.Controls.Add(this.misedTask_listbox);
            this.Controls.Add(this.todayTask_listbox);
            this.Controls.Add(this.closeTasks_label);
            this.Controls.Add(this.missedTasks_label);
            this.Controls.Add(this.todayTasks_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todayTasks_label;
        private System.Windows.Forms.ListBox todayTask_listbox;
        private System.Windows.Forms.Label closeTasks_label;
        private System.Windows.Forms.ListBox closeTasks_listbox;
        private System.Windows.Forms.Button taskDone_button;
        private System.Windows.Forms.Button taskDelay_button;
        private System.Windows.Forms.Label missedTasks_label;
        private System.Windows.Forms.ListBox misedTask_listbox;
        private System.Windows.Forms.Button taskDoen1_button;
        private System.Windows.Forms.Button removeTask_button;
    }
}