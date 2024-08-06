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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.Name_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SearchBarLabel = new System.Windows.Forms.Label();
            this.ServiceHeader = new System.Windows.Forms.Label();
            this.Stop_Services_Button = new System.Windows.Forms.Button();
            this.Start_Service_Button = new System.Windows.Forms.Button();
            this.Restart_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.WorkTimePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeInterval = new System.Windows.Forms.TextBox();
            this.Add_WorkTime_Button = new System.Windows.Forms.Button();
            this.ServiceNamesComboBox = new System.Windows.Forms.ComboBox();
            this.WorkTimeGrid = new System.Windows.Forms.DataGridView();
            this.Programmed_Services_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_NonStopServices_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.pin_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Kill_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Restart_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenServices = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkTimerForm_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GoToServicesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.WorkTimePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.AllowUserToResizeColumns = false;
            this.dataGridViewServices.AllowUserToResizeRows = false;
            this.dataGridViewServices.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Service,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dataGridViewServices.Location = new System.Drawing.Point(0, 89);
            this.dataGridViewServices.MultiSelect = false;
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(869, 376);
            this.dataGridViewServices.TabIndex = 1;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewServices.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellEnter);
            this.dataGridViewServices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellValueChanged);
            this.dataGridViewServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewServices_MouseDown);
            // 
            // Name_Service
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Name_Service.DefaultCellStyle = dataGridViewCellStyle2;
            this.Name_Service.HeaderText = "Name";
            this.Name_Service.MinimumWidth = 6;
            this.Name_Service.Name = "Name_Service";
            this.Name_Service.ReadOnly = true;
            this.Name_Service.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "PID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Group";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MainPanel.Controls.Add(this.SearchBarLabel);
            this.MainPanel.Controls.Add(this.Stop_Services_Button);
            this.MainPanel.Controls.Add(this.Start_Service_Button);
            this.MainPanel.Controls.Add(this.Restart_Button);
            this.MainPanel.Controls.Add(this.comboBox1);
            this.MainPanel.Controls.Add(this.SearchBar);
            this.MainPanel.Controls.Add(this.ServiceHeader);
            this.MainPanel.Controls.Add(this.dataGridViewServices);
            this.MainPanel.Location = new System.Drawing.Point(86, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(869, 575);
            this.MainPanel.TabIndex = 4;
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
            // ServiceHeader
            // 
            this.ServiceHeader.AutoSize = true;
            this.ServiceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ServiceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ServiceHeader.Location = new System.Drawing.Point(3, 0);
            this.ServiceHeader.Name = "ServiceHeader";
            this.ServiceHeader.Size = new System.Drawing.Size(160, 39);
            this.ServiceHeader.TabIndex = 0;
            this.ServiceHeader.Text = "Services";
            // 
            // Stop_Services_Button
            // 
            this.Stop_Services_Button.BackColor = System.Drawing.Color.Black;
            this.Stop_Services_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_Services_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stop_Services_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Stop_Services_Button.Location = new System.Drawing.Point(664, 481);
            this.Stop_Services_Button.Name = "Stop_Services_Button";
            this.Stop_Services_Button.Size = new System.Drawing.Size(75, 34);
            this.Stop_Services_Button.TabIndex = 3;
            this.Stop_Services_Button.Text = "Stop";
            this.Stop_Services_Button.UseVisualStyleBackColor = false;
            this.Stop_Services_Button.Visible = false;
            this.Stop_Services_Button.Click += new System.EventHandler(this.Stop_Services_Button_Click);
            // 
            // Start_Service_Button
            // 
            this.Start_Service_Button.BackColor = System.Drawing.SystemColors.InfoText;
            this.Start_Service_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_Service_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start_Service_Button.ForeColor = System.Drawing.Color.White;
            this.Start_Service_Button.Location = new System.Drawing.Point(664, 481);
            this.Start_Service_Button.Name = "Start_Service_Button";
            this.Start_Service_Button.Size = new System.Drawing.Size(75, 35);
            this.Start_Service_Button.TabIndex = 2;
            this.Start_Service_Button.Text = "Start";
            this.Start_Service_Button.UseVisualStyleBackColor = false;
            this.Start_Service_Button.Click += new System.EventHandler(this.Start_Service_Button_Click);
            // 
            // Restart_Button
            // 
            this.Restart_Button.BackColor = System.Drawing.Color.Black;
            this.Restart_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Restart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Restart_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Restart_Button.Location = new System.Drawing.Point(761, 478);
            this.Restart_Button.Name = "Restart_Button";
            this.Restart_Button.Size = new System.Drawing.Size(91, 41);
            this.Restart_Button.TabIndex = 4;
            this.Restart_Button.Text = "Restart";
            this.Restart_Button.UseVisualStyleBackColor = false;
            this.Restart_Button.Click += new System.EventHandler(this.Restart_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Non-Stop Services",
            "Pinned"});
            this.comboBox1.Location = new System.Drawing.Point(664, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 30);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Gainsboro;
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBar.ForeColor = System.Drawing.Color.Black;
            this.SearchBar.Location = new System.Drawing.Point(67, 53);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(549, 30);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged_1);
            // 
            // WorkTimePanel
            // 
            this.WorkTimePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.WorkTimePanel.Controls.Add(this.panel1);
            this.WorkTimePanel.Controls.Add(this.WorkTimeGrid);
            this.WorkTimePanel.Controls.Add(this.label1);
            this.WorkTimePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.WorkTimePanel.Location = new System.Drawing.Point(86, 0);
            this.WorkTimePanel.Name = "WorkTimePanel";
            this.WorkTimePanel.Size = new System.Drawing.Size(869, 575);
            this.WorkTimePanel.TabIndex = 3;
            this.WorkTimePanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TimeInterval);
            this.panel1.Controls.Add(this.Add_WorkTime_Button);
            this.panel1.Controls.Add(this.ServiceNamesComboBox);
            this.panel1.Location = new System.Drawing.Point(88, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 84);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(580, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Interval (Only Minutes):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(18, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeInterval
            // 
            this.TimeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TimeInterval.Location = new System.Drawing.Point(347, 36);
            this.TimeInterval.Name = "TimeInterval";
            this.TimeInterval.Size = new System.Drawing.Size(151, 34);
            this.TimeInterval.TabIndex = 3;
            this.TimeInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Add_WorkTime_Button
            // 
            this.Add_WorkTime_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Add_WorkTime_Button.Location = new System.Drawing.Point(579, 34);
            this.Add_WorkTime_Button.Name = "Add_WorkTime_Button";
            this.Add_WorkTime_Button.Size = new System.Drawing.Size(51, 36);
            this.Add_WorkTime_Button.TabIndex = 2;
            this.Add_WorkTime_Button.Text = "+";
            this.Add_WorkTime_Button.UseVisualStyleBackColor = true;
            this.Add_WorkTime_Button.Click += new System.EventHandler(this.Add_WorkTime_Button_Click);
            // 
            // ServiceNamesComboBox
            // 
            this.ServiceNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ServiceNamesComboBox.FormattingEnabled = true;
            this.ServiceNamesComboBox.Location = new System.Drawing.Point(22, 33);
            this.ServiceNamesComboBox.Name = "ServiceNamesComboBox";
            this.ServiceNamesComboBox.Size = new System.Drawing.Size(241, 37);
            this.ServiceNamesComboBox.TabIndex = 4;
            // 
            // WorkTimeGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.WorkTimeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkTimeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.WorkTimeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkTimeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Programmed_Services_Name,
            this.Time_Interval});
            this.WorkTimeGrid.Location = new System.Drawing.Point(153, 179);
            this.WorkTimeGrid.Name = "WorkTimeGrid";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkTimeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.WorkTimeGrid.RowHeadersVisible = false;
            this.WorkTimeGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WorkTimeGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.WorkTimeGrid.RowTemplate.Height = 24;
            this.WorkTimeGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorkTimeGrid.Size = new System.Drawing.Size(521, 236);
            this.WorkTimeGrid.TabIndex = 1;
            // 
            // Programmed_Services_Name
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Programmed_Services_Name.DefaultCellStyle = dataGridViewCellStyle9;
            this.Programmed_Services_Name.HeaderText = "Programmed Services Name";
            this.Programmed_Services_Name.MinimumWidth = 6;
            this.Programmed_Services_Name.Name = "Programmed_Services_Name";
            this.Programmed_Services_Name.ReadOnly = true;
            this.Programmed_Services_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Programmed_Services_Name.Width = 200;
            // 
            // Time_Interval
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Time_Interval.DefaultCellStyle = dataGridViewCellStyle10;
            this.Time_Interval.HeaderText = "Time Interval";
            this.Time_Interval.MinimumWidth = 6;
            this.Time_Interval.Name = "Time_Interval";
            this.Time_Interval.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Work Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start_Click
            // 
            this.Start_Click.Name = "Start_Click";
            this.Start_Click.Size = new System.Drawing.Size(200, 24);
            this.Start_Click.Text = "Start";
            // 
            // Stop_Click
            // 
            this.Stop_Click.Name = "Stop_Click";
            this.Stop_Click.Size = new System.Drawing.Size(200, 24);
            this.Stop_Click.Text = "Stop";
            // 
            // Add_NonStopServices_Click
            // 
            this.Add_NonStopServices_Click.Name = "Add_NonStopServices_Click";
            this.Add_NonStopServices_Click.Size = new System.Drawing.Size(200, 24);
            this.Add_NonStopServices_Click.Text = "Non-Stop Services";
            this.Add_NonStopServices_Click.Click += new System.EventHandler(this.NonStopServices_Click_Click);
            // 
            // pin_Click
            // 
            this.pin_Click.Name = "pin_Click";
            this.pin_Click.Size = new System.Drawing.Size(200, 24);
            this.pin_Click.Text = "Pin";
            this.pin_Click.Click += new System.EventHandler(this.pin_Click_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start_Click,
            this.Stop_Click,
            this.Kill_Click,
            this.Restart_Click,
            this.toolStripSeparator1,
            this.Add_NonStopServices_Click,
            this.pin_Click,
            this.toolStripSeparator2,
            this.OpenServices});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 184);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseDown);
            // 
            // Kill_Click
            // 
            this.Kill_Click.Enabled = false;
            this.Kill_Click.Name = "Kill_Click";
            this.Kill_Click.Size = new System.Drawing.Size(200, 24);
            this.Kill_Click.Text = "Kill";
            this.Kill_Click.Click += new System.EventHandler(this.Kill_Click_Click);
            // 
            // Restart_Click
            // 
            this.Restart_Click.Name = "Restart_Click";
            this.Restart_Click.Size = new System.Drawing.Size(200, 24);
            this.Restart_Click.Text = "Restart";
            this.Restart_Click.Click += new System.EventHandler(this.Restart_ClickItem);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // OpenServices
            // 
            this.OpenServices.Name = "OpenServices";
            this.OpenServices.Size = new System.Drawing.Size(200, 24);
            this.OpenServices.Text = "Open Services";
            this.OpenServices.Click += new System.EventHandler(this.OpenServices_Click);
            // 
            // WorkTimerForm_Button
            // 
            this.WorkTimerForm_Button.BackColor = System.Drawing.Color.Black;
            this.WorkTimerForm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WorkTimerForm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.WorkTimerForm_Button.ForeColor = System.Drawing.Color.White;
            this.WorkTimerForm_Button.Location = new System.Drawing.Point(3, 52);
            this.WorkTimerForm_Button.Name = "WorkTimerForm_Button";
            this.WorkTimerForm_Button.Size = new System.Drawing.Size(75, 44);
            this.WorkTimerForm_Button.TabIndex = 7;
            this.WorkTimerForm_Button.Text = "Schedule Work Timer";
            this.WorkTimerForm_Button.UseVisualStyleBackColor = false;
            this.WorkTimerForm_Button.Click += new System.EventHandler(this.WorkTimerForm_Button_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.GoToServicesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WorkTimerForm_Button, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(83, 99);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // GoToServicesButton
            // 
            this.GoToServicesButton.BackColor = System.Drawing.Color.Black;
            this.GoToServicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToServicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.GoToServicesButton.ForeColor = System.Drawing.Color.White;
            this.GoToServicesButton.Location = new System.Drawing.Point(3, 3);
            this.GoToServicesButton.Name = "GoToServicesButton";
            this.GoToServicesButton.Size = new System.Drawing.Size(75, 43);
            this.GoToServicesButton.TabIndex = 0;
            this.GoToServicesButton.Text = "Services";
            this.GoToServicesButton.UseVisualStyleBackColor = false;
            this.GoToServicesButton.Click += new System.EventHandler(this.GoToServicesButton_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(954, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.WorkTimePanel);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Service Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.WorkTimePanel.ResumeLayout(false);
            this.WorkTimePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Panel MainPanel;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OpenServices;
        private System.Windows.Forms.ToolStripMenuItem Kill_Click;
        private System.Windows.Forms.Button WorkTimerForm_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GoToServicesButton;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel WorkTimePanel;
        private System.Windows.Forms.DataGridView WorkTimeGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServiceNamesComboBox;
        private System.Windows.Forms.TextBox TimeInterval;
        private System.Windows.Forms.Button Add_WorkTime_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programmed_Services_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Interval;
    }
}

