namespace FPPGroup_Clients_Management
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.addTask_label = new System.Windows.Forms.Label();
            this.customer_label = new System.Windows.Forms.Label();
            this.customer_combobox = new System.Windows.Forms.ComboBox();
            this.date1_label = new System.Windows.Forms.Label();
            this.createTaskDate_textbox = new System.Windows.Forms.TextBox();
            this.date2_label = new System.Windows.Forms.Label();
            this.taskDate_textbox = new System.Windows.Forms.TextBox();
            this.taskCategory_label = new System.Windows.Forms.Label();
            this.taskCategory_combobox = new System.Windows.Forms.ComboBox();
            this.taskNote_label = new System.Windows.Forms.Label();
            this.taskNote_textbox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.addCustomer_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTask_label
            // 
            this.addTask_label.AutoSize = true;
            this.addTask_label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTask_label.Location = new System.Drawing.Point(12, 9);
            this.addTask_label.Name = "addTask_label";
            this.addTask_label.Size = new System.Drawing.Size(186, 30);
            this.addTask_label.TabIndex = 7;
            this.addTask_label.Text = "Dodaj zadanie";
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Location = new System.Drawing.Point(22, 63);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(62, 23);
            this.customer_label.TabIndex = 16;
            this.customer_label.Text = "Klient";
            // 
            // customer_combobox
            // 
            this.customer_combobox.FormattingEnabled = true;
            this.customer_combobox.Location = new System.Drawing.Point(26, 89);
            this.customer_combobox.Name = "customer_combobox";
            this.customer_combobox.Size = new System.Drawing.Size(376, 31);
            this.customer_combobox.TabIndex = 0;
            // 
            // date1_label
            // 
            this.date1_label.AutoSize = true;
            this.date1_label.Location = new System.Drawing.Point(22, 153);
            this.date1_label.Name = "date1_label";
            this.date1_label.Size = new System.Drawing.Size(148, 23);
            this.date1_label.TabIndex = 16;
            this.date1_label.Text = "Data zlecenia";
            // 
            // createTaskDate_textbox
            // 
            this.createTaskDate_textbox.Location = new System.Drawing.Point(26, 179);
            this.createTaskDate_textbox.Name = "createTaskDate_textbox";
            this.createTaskDate_textbox.Size = new System.Drawing.Size(181, 32);
            this.createTaskDate_textbox.TabIndex = 1;
            // 
            // date2_label
            // 
            this.date2_label.AutoSize = true;
            this.date2_label.Location = new System.Drawing.Point(217, 153);
            this.date2_label.Name = "date2_label";
            this.date2_label.Size = new System.Drawing.Size(173, 23);
            this.date2_label.TabIndex = 16;
            this.date2_label.Text = "Data wykonania";
            // 
            // taskDate_textbox
            // 
            this.taskDate_textbox.Location = new System.Drawing.Point(221, 179);
            this.taskDate_textbox.Name = "taskDate_textbox";
            this.taskDate_textbox.Size = new System.Drawing.Size(181, 32);
            this.taskDate_textbox.TabIndex = 2;
            // 
            // taskCategory_label
            // 
            this.taskCategory_label.AutoSize = true;
            this.taskCategory_label.Location = new System.Drawing.Point(22, 250);
            this.taskCategory_label.Name = "taskCategory_label";
            this.taskCategory_label.Size = new System.Drawing.Size(191, 23);
            this.taskCategory_label.TabIndex = 16;
            this.taskCategory_label.Text = "Kategoria zadania";
            // 
            // taskCategory_combobox
            // 
            this.taskCategory_combobox.FormattingEnabled = true;
            this.taskCategory_combobox.Location = new System.Drawing.Point(26, 276);
            this.taskCategory_combobox.Name = "taskCategory_combobox";
            this.taskCategory_combobox.Size = new System.Drawing.Size(376, 31);
            this.taskCategory_combobox.TabIndex = 3;
            // 
            // taskNote_label
            // 
            this.taskNote_label.AutoSize = true;
            this.taskNote_label.Location = new System.Drawing.Point(473, 63);
            this.taskNote_label.Name = "taskNote_label";
            this.taskNote_label.Size = new System.Drawing.Size(248, 23);
            this.taskNote_label.TabIndex = 16;
            this.taskNote_label.Text = "Szczegółowe informacje";
            // 
            // taskNote_textbox
            // 
            this.taskNote_textbox.Location = new System.Drawing.Point(477, 89);
            this.taskNote_textbox.Multiline = true;
            this.taskNote_textbox.Name = "taskNote_textbox";
            this.taskNote_textbox.Size = new System.Drawing.Size(434, 218);
            this.taskNote_textbox.TabIndex = 4;
            // 
            // cancel_button
            // 
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Image = ((System.Drawing.Image)(resources.GetObject("cancel_button.Image")));
            this.cancel_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_button.Location = new System.Drawing.Point(281, 458);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(182, 62);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Anuluj";
            this.cancel_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // addCustomer_button
            // 
            this.addCustomer_button.FlatAppearance.BorderSize = 0;
            this.addCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer_button.Image = ((System.Drawing.Image)(resources.GetObject("addCustomer_button.Image")));
            this.addCustomer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCustomer_button.Location = new System.Drawing.Point(469, 458);
            this.addCustomer_button.Name = "addCustomer_button";
            this.addCustomer_button.Size = new System.Drawing.Size(182, 62);
            this.addCustomer_button.TabIndex = 6;
            this.addCustomer_button.Text = "Dodaj";
            this.addCustomer_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCustomer_button.UseVisualStyleBackColor = true;
            this.addCustomer_button.Click += new System.EventHandler(this.addCustomer_button_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addCustomer_button);
            this.Controls.Add(this.taskDate_textbox);
            this.Controls.Add(this.taskNote_textbox);
            this.Controls.Add(this.createTaskDate_textbox);
            this.Controls.Add(this.taskCategory_combobox);
            this.Controls.Add(this.customer_combobox);
            this.Controls.Add(this.date2_label);
            this.Controls.Add(this.taskNote_label);
            this.Controls.Add(this.date1_label);
            this.Controls.Add(this.taskCategory_label);
            this.Controls.Add(this.customer_label);
            this.Controls.Add(this.addTask_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addTask_label;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.ComboBox customer_combobox;
        private System.Windows.Forms.Label date1_label;
        private System.Windows.Forms.TextBox createTaskDate_textbox;
        private System.Windows.Forms.Label date2_label;
        private System.Windows.Forms.TextBox taskDate_textbox;
        private System.Windows.Forms.Label taskCategory_label;
        private System.Windows.Forms.ComboBox taskCategory_combobox;
        private System.Windows.Forms.Label taskNote_label;
        private System.Windows.Forms.TextBox taskNote_textbox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button addCustomer_button;
    }
}