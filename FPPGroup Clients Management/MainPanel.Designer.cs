namespace FPPGroup_Clients_Management
{
    partial class MainPanel
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.tasks_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.klient_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date_label = new System.Windows.Forms.Label();
            this.today_label = new System.Windows.Forms.Label();
            this.changingPanel = new System.Windows.Forms.Panel();
            this.movingPanel_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.tasks_button);
            this.panel1.Controls.Add(this.home_button);
            this.panel1.Controls.Add(this.klient_button);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 620);
            this.panel1.TabIndex = 0;
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_button.Location = new System.Drawing.Point(7, 509);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(254, 99);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "Wyjdź";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // tasks_button
            // 
            this.tasks_button.FlatAppearance.BorderSize = 0;
            this.tasks_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasks_button.Image = ((System.Drawing.Image)(resources.GetObject("tasks_button.Image")));
            this.tasks_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tasks_button.Location = new System.Drawing.Point(7, 339);
            this.tasks_button.Name = "tasks_button";
            this.tasks_button.Size = new System.Drawing.Size(254, 99);
            this.tasks_button.TabIndex = 2;
            this.tasks_button.Text = "Zadania";
            this.tasks_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tasks_button.UseVisualStyleBackColor = true;
            this.tasks_button.Click += new System.EventHandler(this.tasks_button_Click);
            // 
            // home_button
            // 
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home_button.Location = new System.Drawing.Point(7, 129);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(254, 99);
            this.home_button.TabIndex = 2;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // klient_button
            // 
            this.klient_button.FlatAppearance.BorderSize = 0;
            this.klient_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klient_button.Image = ((System.Drawing.Image)(resources.GetObject("klient_button.Image")));
            this.klient_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.klient_button.Location = new System.Drawing.Point(7, 234);
            this.klient_button.Name = "klient_button";
            this.klient_button.Size = new System.Drawing.Size(254, 99);
            this.klient_button.TabIndex = 2;
            this.klient_button.Text = "Klienci";
            this.klient_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.klient_button.UseVisualStyleBackColor = true;
            this.klient_button.Click += new System.EventHandler(this.klient_button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 111);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(358, 26);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 23);
            this.date_label.TabIndex = 0;
            // 
            // today_label
            // 
            this.today_label.AutoSize = true;
            this.today_label.Location = new System.Drawing.Point(293, 26);
            this.today_label.Name = "today_label";
            this.today_label.Size = new System.Drawing.Size(50, 23);
            this.today_label.TabIndex = 0;
            this.today_label.Text = "Dziś:";
            // 
            // changingPanel
            // 
            this.changingPanel.Location = new System.Drawing.Point(275, 76);
            this.changingPanel.Name = "changingPanel";
            this.changingPanel.Size = new System.Drawing.Size(933, 532);
            this.changingPanel.TabIndex = 2;
            // 
            // movingPanel_panel
            // 
            this.movingPanel_panel.BackColor = System.Drawing.Color.Yellow;
            this.movingPanel_panel.Location = new System.Drawing.Point(269, 129);
            this.movingPanel_panel.Name = "movingPanel_panel";
            this.movingPanel_panel.Size = new System.Drawing.Size(8, 99);
            this.movingPanel_panel.TabIndex = 3;
            // 
            // MainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1220, 620);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.movingPanel_panel);
            this.Controls.Add(this.today_label);
            this.Controls.Add(this.changingPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Panel";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button klient_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button tasks_button;
        private System.Windows.Forms.Panel changingPanel;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Panel movingPanel_panel;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label today_label;
    }
}

