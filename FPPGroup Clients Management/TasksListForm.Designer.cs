namespace FPPGroup_Clients_Management
{
    partial class TasksListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksListForm));
            this.taskList_listbox = new System.Windows.Forms.ListBox();
            this.taskList_label = new System.Windows.Forms.Label();
            this.remove_button = new System.Windows.Forms.Button();
            this.addTask_button = new System.Windows.Forms.Button();
            this.taskDone_button = new System.Windows.Forms.Button();
            this.taskDetails_button = new System.Windows.Forms.Button();
            this.onlyActiveTasks_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskList_listbox
            // 
            this.taskList_listbox.FormattingEnabled = true;
            this.taskList_listbox.ItemHeight = 23;
            this.taskList_listbox.Location = new System.Drawing.Point(14, 56);
            this.taskList_listbox.Name = "taskList_listbox";
            this.taskList_listbox.Size = new System.Drawing.Size(905, 372);
            this.taskList_listbox.Sorted = true;
            this.taskList_listbox.TabIndex = 3;
            // 
            // taskList_label
            // 
            this.taskList_label.AutoSize = true;
            this.taskList_label.Location = new System.Drawing.Point(12, 30);
            this.taskList_label.Name = "taskList_label";
            this.taskList_label.Size = new System.Drawing.Size(120, 23);
            this.taskList_label.TabIndex = 2;
            this.taskList_label.Text = "Lista zadań";
            // 
            // remove_button
            // 
            this.remove_button.FlatAppearance.BorderSize = 0;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Image = ((System.Drawing.Image)(resources.GetObject("remove_button.Image")));
            this.remove_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.remove_button.Location = new System.Drawing.Point(737, 456);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(182, 64);
            this.remove_button.TabIndex = 4;
            this.remove_button.Text = "Usuń";
            this.remove_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // addTask_button
            // 
            this.addTask_button.FlatAppearance.BorderSize = 0;
            this.addTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask_button.Image = ((System.Drawing.Image)(resources.GetObject("addTask_button.Image")));
            this.addTask_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTask_button.Location = new System.Drawing.Point(14, 456);
            this.addTask_button.Name = "addTask_button";
            this.addTask_button.Size = new System.Drawing.Size(182, 64);
            this.addTask_button.TabIndex = 5;
            this.addTask_button.Text = "Dodaj zadanie";
            this.addTask_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTask_button.UseVisualStyleBackColor = true;
            this.addTask_button.Click += new System.EventHandler(this.addTask_button_Click);
            // 
            // taskDone_button
            // 
            this.taskDone_button.FlatAppearance.BorderSize = 0;
            this.taskDone_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDone_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDone_button.Image")));
            this.taskDone_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taskDone_button.Location = new System.Drawing.Point(549, 456);
            this.taskDone_button.Name = "taskDone_button";
            this.taskDone_button.Size = new System.Drawing.Size(182, 64);
            this.taskDone_button.TabIndex = 5;
            this.taskDone_button.Text = "Wykonane";
            this.taskDone_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDone_button.UseVisualStyleBackColor = true;
            // 
            // taskDetails_button
            // 
            this.taskDetails_button.FlatAppearance.BorderSize = 0;
            this.taskDetails_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskDetails_button.Image = ((System.Drawing.Image)(resources.GetObject("taskDetails_button.Image")));
            this.taskDetails_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taskDetails_button.Location = new System.Drawing.Point(202, 456);
            this.taskDetails_button.Name = "taskDetails_button";
            this.taskDetails_button.Size = new System.Drawing.Size(182, 64);
            this.taskDetails_button.TabIndex = 5;
            this.taskDetails_button.Text = "Pokaż";
            this.taskDetails_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskDetails_button.UseVisualStyleBackColor = true;
            // 
            // onlyActiveTasks_button
            // 
            this.onlyActiveTasks_button.FlatAppearance.BorderSize = 0;
            this.onlyActiveTasks_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlyActiveTasks_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.onlyActiveTasks_button.Location = new System.Drawing.Point(737, 12);
            this.onlyActiveTasks_button.Name = "onlyActiveTasks_button";
            this.onlyActiveTasks_button.Size = new System.Drawing.Size(182, 38);
            this.onlyActiveTasks_button.TabIndex = 5;
            this.onlyActiveTasks_button.Text = "Tylko aktywne";
            this.onlyActiveTasks_button.UseVisualStyleBackColor = true;
            this.onlyActiveTasks_button.Click += new System.EventHandler(this.onlyActiveTasks_button_Click);
            // 
            // TasksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.taskDetails_button);
            this.Controls.Add(this.onlyActiveTasks_button);
            this.Controls.Add(this.taskDone_button);
            this.Controls.Add(this.addTask_button);
            this.Controls.Add(this.taskList_listbox);
            this.Controls.Add(this.taskList_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TasksListLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox taskList_listbox;
        private System.Windows.Forms.Label taskList_label;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button addTask_button;
        private System.Windows.Forms.Button taskDone_button;
        private System.Windows.Forms.Button taskDetails_button;
        private System.Windows.Forms.Button onlyActiveTasks_button;
    }
}