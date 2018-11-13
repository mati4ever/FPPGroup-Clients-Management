namespace FPPGroup_Clients_Management
{
    partial class CustomersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersListForm));
            this.customersList_label = new System.Windows.Forms.Label();
            this.customersList_listbox = new System.Windows.Forms.ListBox();
            this.addCustomer_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.fullProfile_button = new System.Windows.Forms.Button();
            this.customerTask_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersList_label
            // 
            this.customersList_label.AutoSize = true;
            this.customersList_label.Location = new System.Drawing.Point(12, 10);
            this.customersList_label.Name = "customersList_label";
            this.customersList_label.Size = new System.Drawing.Size(143, 23);
            this.customersList_label.TabIndex = 0;
            this.customersList_label.Text = "Lista klientów:";
            // 
            // customersList_listbox
            // 
            this.customersList_listbox.FormattingEnabled = true;
            this.customersList_listbox.ItemHeight = 23;
            this.customersList_listbox.Location = new System.Drawing.Point(15, 36);
            this.customersList_listbox.Name = "customersList_listbox";
            this.customersList_listbox.Size = new System.Drawing.Size(903, 372);
            this.customersList_listbox.TabIndex = 1;
            // 
            // addCustomer_button
            // 
            this.addCustomer_button.FlatAppearance.BorderSize = 0;
            this.addCustomer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer_button.Image = ((System.Drawing.Image)(resources.GetObject("addCustomer_button.Image")));
            this.addCustomer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCustomer_button.Location = new System.Drawing.Point(15, 456);
            this.addCustomer_button.Name = "addCustomer_button";
            this.addCustomer_button.Size = new System.Drawing.Size(182, 64);
            this.addCustomer_button.TabIndex = 3;
            this.addCustomer_button.Text = "Dodaj nowego";
            this.addCustomer_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCustomer_button.UseVisualStyleBackColor = true;
            this.addCustomer_button.Click += new System.EventHandler(this.addCustomer_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.FlatAppearance.BorderSize = 0;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Image = ((System.Drawing.Image)(resources.GetObject("remove_button.Image")));
            this.remove_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.remove_button.Location = new System.Drawing.Point(736, 456);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(182, 64);
            this.remove_button.TabIndex = 3;
            this.remove_button.Text = "Usuń";
            this.remove_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // fullProfile_button
            // 
            this.fullProfile_button.FlatAppearance.BorderSize = 0;
            this.fullProfile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullProfile_button.Image = ((System.Drawing.Image)(resources.GetObject("fullProfile_button.Image")));
            this.fullProfile_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fullProfile_button.Location = new System.Drawing.Point(203, 456);
            this.fullProfile_button.Name = "fullProfile_button";
            this.fullProfile_button.Size = new System.Drawing.Size(182, 64);
            this.fullProfile_button.TabIndex = 3;
            this.fullProfile_button.Text = "Pełny profil";
            this.fullProfile_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fullProfile_button.UseVisualStyleBackColor = true;
            // 
            // customerTask_button
            // 
            this.customerTask_button.FlatAppearance.BorderSize = 0;
            this.customerTask_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerTask_button.Image = ((System.Drawing.Image)(resources.GetObject("customerTask_button.Image")));
            this.customerTask_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customerTask_button.Location = new System.Drawing.Point(391, 456);
            this.customerTask_button.Name = "customerTask_button";
            this.customerTask_button.Size = new System.Drawing.Size(182, 64);
            this.customerTask_button.TabIndex = 3;
            this.customerTask_button.Text = "Zadania";
            this.customerTask_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerTask_button.UseVisualStyleBackColor = true;
            // 
            // CustomersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.customerTask_button);
            this.Controls.Add(this.fullProfile_button);
            this.Controls.Add(this.addCustomer_button);
            this.Controls.Add(this.customersList_listbox);
            this.Controls.Add(this.customersList_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customersList_label;
        private System.Windows.Forms.ListBox customersList_listbox;
        private System.Windows.Forms.Button addCustomer_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button fullProfile_button;
        private System.Windows.Forms.Button customerTask_button;
    }
}