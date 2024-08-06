namespace WindowsServiceManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBarLabel = new System.Windows.Forms.Label();
            this.Restart_Button = new System.Windows.Forms.Button();
            this.Stop_Services_Button = new System.Windows.Forms.Button();
            this.Start_Service_Button = new System.Windows.Forms.Button();
            this.ServiceHeader = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Start_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_NonStopServices_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.pin_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restart_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenServices = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.AllowUserToResizeColumns = false;
            this.dataGridViewServices.AllowUserToResizeRows = false;
            this.dataGridViewServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Service,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewServices.Location = new System.Drawing.Point(1, 105);
            this.dataGridViewServices.MultiSelect = false;
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(869, 422);
            this.dataGridViewServices.TabIndex = 1;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewServices.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellEnter);
            this.dataGridViewServices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellValueChanged);
            this.dataGridViewServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewServices_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBarLabel);
            this.panel1.Controls.Add(this.Restart_Button);
            this.panel1.Controls.Add(this.Stop_Services_Button);
            this.panel1.Controls.Add(this.Start_Service_Button);
            this.panel1.Controls.Add(this.ServiceHeader);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 50);
            this.panel1.TabIndex = 2;
            // 
            // SearchBarLabel
            // 
            this.SearchBarLabel.AutoSize = true;
            this.SearchBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBarLabel.Location = new System.Drawing.Point(124, 13);
            this.SearchBarLabel.Name = "SearchBarLabel";
            this.SearchBarLabel.Size = new System.Drawing.Size(0, 16);
            this.SearchBarLabel.TabIndex = 6;
            // 
            // Restart_Button
            // 
            this.Restart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Restart_Button.Location = new System.Drawing.Point(668, 4);
            this.Restart_Button.Name = "Restart_Button";
            this.Restart_Button.Size = new System.Drawing.Size(91, 41);
            this.Restart_Button.TabIndex = 4;
            this.Restart_Button.Text = "Restart";
            this.Restart_Button.UseVisualStyleBackColor = true;
            this.Restart_Button.Click += new System.EventHandler(this.Restart_Button_Click);
            // 
            // Stop_Services_Button
            // 
            this.Stop_Services_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stop_Services_Button.Location = new System.Drawing.Point(780, 7);
            this.Stop_Services_Button.Name = "Stop_Services_Button";
            this.Stop_Services_Button.Size = new System.Drawing.Size(75, 34);
            this.Stop_Services_Button.TabIndex = 3;
            this.Stop_Services_Button.Text = "Stop";
            this.Stop_Services_Button.UseVisualStyleBackColor = true;
            this.Stop_Services_Button.Visible = false;
            this.Stop_Services_Button.Click += new System.EventHandler(this.Stop_Services_Button_Click);
            // 
            // Start_Service_Button
            // 
            this.Start_Service_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start_Service_Button.Location = new System.Drawing.Point(780, 7);
            this.Start_Service_Button.Name = "Start_Service_Button";
            this.Start_Service_Button.Size = new System.Drawing.Size(75, 35);
            this.Start_Service_Button.TabIndex = 2;
            this.Start_Service_Button.Text = "Start";
            this.Start_Service_Button.UseVisualStyleBackColor = true;
            this.Start_Service_Button.Click += new System.EventHandler(this.Start_Service_Button_Click);
            // 
            // ServiceHeader
            // 
            this.ServiceHeader.AutoSize = true;
            this.ServiceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ServiceHeader.Location = new System.Drawing.Point(11, 4);
            this.ServiceHeader.Name = "ServiceHeader";
            this.ServiceHeader.Size = new System.Drawing.Size(160, 39);
            this.ServiceHeader.TabIndex = 0;
            this.ServiceHeader.Text = "Services";
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBar.Location = new System.Drawing.Point(12, 59);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(549, 30);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Non-Stop Services",
            "Pinned"});
            this.comboBox1.Location = new System.Drawing.Point(662, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 30);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Start_Click
            // 
            this.Start_Click.Name = "Start_Click";
            this.Start_Click.Size = new System.Drawing.Size(210, 24);
            this.Start_Click.Text = "Start";
            // 
            // Stop_Click
            // 
            this.Stop_Click.Name = "Stop_Click";
            this.Stop_Click.Size = new System.Drawing.Size(210, 24);
            this.Stop_Click.Text = "Stop";
            // 
            // Add_NonStopServices_Click
            // 
            this.Add_NonStopServices_Click.Name = "Add_NonStopServices_Click";
            this.Add_NonStopServices_Click.Size = new System.Drawing.Size(210, 24);
            this.Add_NonStopServices_Click.Text = "Non-Stop Services";
            this.Add_NonStopServices_Click.Click += new System.EventHandler(this.NonStopServices_Click_Click);
            // 
            // pin_Click
            // 
            this.pin_Click.Name = "pin_Click";
            this.pin_Click.Size = new System.Drawing.Size(210, 24);
            this.pin_Click.Text = "Pin";
            this.pin_Click.Click += new System.EventHandler(this.pin_Click_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start_Click,
            this.Stop_Click,
            this.Restart_Click,
            this.toolStripSeparator1,
            this.Add_NonStopServices_Click,
            this.pin_Click,
            this.toolStripSeparator2,
            this.OpenServices});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 188);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseDown);
            // 
            // Restart_Click
            // 
            this.Restart_Click.Name = "Restart_Click";
            this.Restart_Click.Size = new System.Drawing.Size(210, 24);
            this.Restart_Click.Text = "Restart";
            this.Restart_Click.Click += new System.EventHandler(this.Restart_ClickItem);
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Group";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column2
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "PID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Name_Service
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Name_Service.DefaultCellStyle = dataGridViewCellStyle10;
            this.Name_Service.HeaderText = "Name";
            this.Name_Service.MinimumWidth = 6;
            this.Name_Service.Name = "Name_Service";
            this.Name_Service.ReadOnly = true;
            this.Name_Service.Width = 125;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // OpenServices
            // 
            this.OpenServices.Name = "OpenServices";
            this.OpenServices.Size = new System.Drawing.Size(210, 24);
            this.OpenServices.Text = "Open Services";
            this.OpenServices.Click += new System.EventHandler(this.OpenServices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 526);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.SearchBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Service Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label ServiceHeader;
        private System.Windows.Forms.Button Restart_Button;
        private System.Windows.Forms.Button Stop_Services_Button;
        private System.Windows.Forms.Button Start_Service_Button;
        private System.Windows.Forms.Label SearchBarLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem Start_Click;
        private System.Windows.Forms.ToolStripMenuItem Stop_Click;
        private System.Windows.Forms.ToolStripMenuItem Add_NonStopServices_Click;
        private System.Windows.Forms.ToolStripMenuItem pin_Click;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Restart_Click;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OpenServices;
    }
}

