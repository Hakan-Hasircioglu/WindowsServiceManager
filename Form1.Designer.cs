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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.Name_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop_Services_Button = new System.Windows.Forms.Button();
            this.Start_Service_Button = new System.Windows.Forms.Button();
            this.Restart_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_NonStopServices_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.pin_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Kill_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.Restart_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTimerWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFiveMinutesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveMinutesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.startaFifteenMinutesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.startThirtyMinutesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.startAHourTool = new System.Windows.Forms.ToolStripMenuItem();
            this.startThreeHoursTool = new System.Windows.Forms.ToolStripMenuItem();
            this.startSixHoursTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAfterAWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopFiveMinutesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopFifteenMinutesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopThirtyMinutesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAHourTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopThreeHoursTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSixHoursTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenServices = new System.Windows.Forms.ToolStripMenuItem();
            this.FiveMinutes = new System.Windows.Forms.Timer(this.components);
            this.FifteenMinutes = new System.Windows.Forms.Timer(this.components);
            this.ThirtyMinutes = new System.Windows.Forms.Timer(this.components);
            this.AHour = new System.Windows.Forms.Timer(this.components);
            this.ThreeHour = new System.Windows.Forms.Timer(this.components);
            this.SixHours = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.AllowUserToResizeColumns = false;
            this.dataGridViewServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServices.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Service,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServices.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dataGridViewServices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewServices.MultiSelect = false;
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(1229, 654);
            this.dataGridViewServices.TabIndex = 1;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewServices.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellEnter);
            this.dataGridViewServices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellValueChanged);
            this.dataGridViewServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewServices_MouseDown);
            // 
            // Name_Service
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Name_Service.DefaultCellStyle = dataGridViewCellStyle3;
            this.Name_Service.HeaderText = "Name";
            this.Name_Service.MinimumWidth = 6;
            this.Name_Service.Name = "Name_Service";
            this.Name_Service.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "PID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column4.HeaderText = "Group";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Stop_Services_Button
            // 
            this.Stop_Services_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_Services_Button.BackColor = System.Drawing.Color.Black;
            this.Stop_Services_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_Services_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stop_Services_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Stop_Services_Button.Location = new System.Drawing.Point(921, 72);
            this.Stop_Services_Button.Name = "Stop_Services_Button";
            this.Stop_Services_Button.Size = new System.Drawing.Size(75, 30);
            this.Stop_Services_Button.TabIndex = 3;
            this.Stop_Services_Button.Text = "Stop";
            this.Stop_Services_Button.UseVisualStyleBackColor = false;
            this.Stop_Services_Button.Visible = false;
            this.Stop_Services_Button.Click += new System.EventHandler(this.Stop_Services_Button_Click);
            // 
            // Start_Service_Button
            // 
            this.Start_Service_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_Service_Button.BackColor = System.Drawing.SystemColors.InfoText;
            this.Start_Service_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_Service_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start_Service_Button.ForeColor = System.Drawing.Color.White;
            this.Start_Service_Button.Location = new System.Drawing.Point(921, 72);
            this.Start_Service_Button.Name = "Start_Service_Button";
            this.Start_Service_Button.Size = new System.Drawing.Size(75, 30);
            this.Start_Service_Button.TabIndex = 2;
            this.Start_Service_Button.Text = "Start";
            this.Start_Service_Button.UseVisualStyleBackColor = false;
            this.Start_Service_Button.Click += new System.EventHandler(this.Start_Service_Button_Click);
            // 
            // Restart_Button
            // 
            this.Restart_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Restart_Button.BackColor = System.Drawing.Color.Black;
            this.Restart_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Restart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Restart_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Restart_Button.Location = new System.Drawing.Point(1002, 72);
            this.Restart_Button.Name = "Restart_Button";
            this.Restart_Button.Size = new System.Drawing.Size(91, 30);
            this.Restart_Button.TabIndex = 4;
            this.Restart_Button.Text = "Restart";
            this.Restart_Button.UseVisualStyleBackColor = false;
            this.Restart_Button.Click += new System.EventHandler(this.Restart_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Non-Stop Services",
            "Pinned"});
            this.comboBox1.Location = new System.Drawing.Point(1128, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 30);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchBar.BackColor = System.Drawing.Color.Gainsboro;
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBar.ForeColor = System.Drawing.Color.Black;
            this.SearchBar.Location = new System.Drawing.Point(93, 73);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(493, 30);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start_Click
            // 
            this.Start_Click.Name = "Start_Click";
            this.Start_Click.Size = new System.Drawing.Size(241, 24);
            this.Start_Click.Text = "Start";
            // 
            // Stop_Click
            // 
            this.Stop_Click.Name = "Stop_Click";
            this.Stop_Click.Size = new System.Drawing.Size(241, 24);
            this.Stop_Click.Text = "Stop";
            // 
            // Add_NonStopServices_Click
            // 
            this.Add_NonStopServices_Click.Name = "Add_NonStopServices_Click";
            this.Add_NonStopServices_Click.Size = new System.Drawing.Size(241, 24);
            this.Add_NonStopServices_Click.Text = "Non-Stop Services";
            this.Add_NonStopServices_Click.Click += new System.EventHandler(this.NonStopServices_Click_Click);
            // 
            // pin_Click
            // 
            this.pin_Click.Name = "pin_Click";
            this.pin_Click.Size = new System.Drawing.Size(241, 24);
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
            this.scheduleTimerWorkerToolStripMenuItem,
            this.Add_NonStopServices_Click,
            this.pin_Click,
            this.toolStripSeparator2,
            this.OpenServices});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 208);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseDown);
            // 
            // Kill_Click
            // 
            this.Kill_Click.Enabled = false;
            this.Kill_Click.Name = "Kill_Click";
            this.Kill_Click.Size = new System.Drawing.Size(241, 24);
            this.Kill_Click.Text = "Kill";
            this.Kill_Click.Click += new System.EventHandler(this.Kill_Click_Click);
            // 
            // Restart_Click
            // 
            this.Restart_Click.Name = "Restart_Click";
            this.Restart_Click.Size = new System.Drawing.Size(241, 24);
            this.Restart_Click.Text = "Restart";
            this.Restart_Click.Click += new System.EventHandler(this.Restart_ClickItem);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // scheduleTimerWorkerToolStripMenuItem
            // 
            this.scheduleTimerWorkerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startFiveMinutesTool,
            this.stopAfterAWhileToolStripMenuItem});
            this.scheduleTimerWorkerToolStripMenuItem.Name = "scheduleTimerWorkerToolStripMenuItem";
            this.scheduleTimerWorkerToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.scheduleTimerWorkerToolStripMenuItem.Text = "* Schedule Timer Worker";
            // 
            // startFiveMinutesTool
            // 
            this.startFiveMinutesTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiveMinutesTool,
            this.startaFifteenMinutesTool,
            this.startThirtyMinutesTool,
            this.startAHourTool,
            this.startThreeHoursTool,
            this.startSixHoursTool});
            this.startFiveMinutesTool.Name = "startFiveMinutesTool";
            this.startFiveMinutesTool.Size = new System.Drawing.Size(209, 26);
            this.startFiveMinutesTool.Text = "Start after a while";
            // 
            // fiveMinutesTool
            // 
            this.fiveMinutesTool.Name = "fiveMinutesTool";
            this.fiveMinutesTool.Size = new System.Drawing.Size(164, 26);
            this.fiveMinutesTool.Text = "5 minutes";
            this.fiveMinutesTool.Click += new System.EventHandler(this.fiveMinutesTool_Click);
            // 
            // startaFifteenMinutesTool
            // 
            this.startaFifteenMinutesTool.Name = "startaFifteenMinutesTool";
            this.startaFifteenMinutesTool.Size = new System.Drawing.Size(164, 26);
            this.startaFifteenMinutesTool.Text = "15 minutes";
            this.startaFifteenMinutesTool.Click += new System.EventHandler(this.startaFifteenMinutesTool_Click);
            // 
            // startThirtyMinutesTool
            // 
            this.startThirtyMinutesTool.Name = "startThirtyMinutesTool";
            this.startThirtyMinutesTool.Size = new System.Drawing.Size(164, 26);
            this.startThirtyMinutesTool.Text = "30 minutes";
            this.startThirtyMinutesTool.Click += new System.EventHandler(this.startThirtyMinutesTool_Click);
            // 
            // startAHourTool
            // 
            this.startAHourTool.Name = "startAHourTool";
            this.startAHourTool.Size = new System.Drawing.Size(164, 26);
            this.startAHourTool.Text = "1 hour";
            this.startAHourTool.Click += new System.EventHandler(this.startAHourTool_Click);
            // 
            // startThreeHoursTool
            // 
            this.startThreeHoursTool.Name = "startThreeHoursTool";
            this.startThreeHoursTool.Size = new System.Drawing.Size(164, 26);
            this.startThreeHoursTool.Text = "3 hours";
            this.startThreeHoursTool.Click += new System.EventHandler(this.startThreeHoursTool_Click);
            // 
            // startSixHoursTool
            // 
            this.startSixHoursTool.Name = "startSixHoursTool";
            this.startSixHoursTool.Size = new System.Drawing.Size(164, 26);
            this.startSixHoursTool.Text = "6 hours";
            this.startSixHoursTool.Click += new System.EventHandler(this.startSixHoursTool_Click);
            // 
            // stopAfterAWhileToolStripMenuItem
            // 
            this.stopAfterAWhileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopFiveMinutesTool,
            this.stopFifteenMinutesTool,
            this.stopThirtyMinutesTool,
            this.stopAHourTool,
            this.stopThreeHoursTool,
            this.stopSixHoursTool});
            this.stopAfterAWhileToolStripMenuItem.Name = "stopAfterAWhileToolStripMenuItem";
            this.stopAfterAWhileToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.stopAfterAWhileToolStripMenuItem.Text = "Stop after a while";
            // 
            // stopFiveMinutesTool
            // 
            this.stopFiveMinutesTool.Name = "stopFiveMinutesTool";
            this.stopFiveMinutesTool.Size = new System.Drawing.Size(164, 26);
            this.stopFiveMinutesTool.Text = "5 minutes";
            this.stopFiveMinutesTool.Click += new System.EventHandler(this.stopFiveMinutesTool_Click);
            // 
            // stopFifteenMinutesTool
            // 
            this.stopFifteenMinutesTool.Name = "stopFifteenMinutesTool";
            this.stopFifteenMinutesTool.Size = new System.Drawing.Size(164, 26);
            this.stopFifteenMinutesTool.Text = "15 minutes";
            this.stopFifteenMinutesTool.Click += new System.EventHandler(this.stopFifteenMinutesTool_Click);
            // 
            // stopThirtyMinutesTool
            // 
            this.stopThirtyMinutesTool.Name = "stopThirtyMinutesTool";
            this.stopThirtyMinutesTool.Size = new System.Drawing.Size(164, 26);
            this.stopThirtyMinutesTool.Text = "30 minutes";
            this.stopThirtyMinutesTool.Click += new System.EventHandler(this.stopThirtyMinutesTool_Click);
            // 
            // stopAHourTool
            // 
            this.stopAHourTool.Name = "stopAHourTool";
            this.stopAHourTool.Size = new System.Drawing.Size(164, 26);
            this.stopAHourTool.Text = "1 hour";
            this.stopAHourTool.Click += new System.EventHandler(this.stopAHourTool_Click);
            // 
            // stopThreeHoursTool
            // 
            this.stopThreeHoursTool.Name = "stopThreeHoursTool";
            this.stopThreeHoursTool.Size = new System.Drawing.Size(164, 26);
            this.stopThreeHoursTool.Text = "3 hours";
            this.stopThreeHoursTool.Click += new System.EventHandler(this.stopThreeHoursTool_Click);
            // 
            // stopSixHoursTool
            // 
            this.stopSixHoursTool.Name = "stopSixHoursTool";
            this.stopSixHoursTool.Size = new System.Drawing.Size(164, 26);
            this.stopSixHoursTool.Text = "6 hours";
            this.stopSixHoursTool.Click += new System.EventHandler(this.stopSixHoursTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // OpenServices
            // 
            this.OpenServices.Name = "OpenServices";
            this.OpenServices.Size = new System.Drawing.Size(241, 24);
            this.OpenServices.Text = "Open Services";
            this.OpenServices.Click += new System.EventHandler(this.OpenServices_Click);
            // 
            // FiveMinutes
            // 
            this.FiveMinutes.Interval = 300000;
            this.FiveMinutes.Tick += new System.EventHandler(this.FiveMinutes_Tick);
            // 
            // FifteenMinutes
            // 
            this.FifteenMinutes.Interval = 900000;
            // 
            // ThirtyMinutes
            // 
            this.ThirtyMinutes.Interval = 1800000;
            // 
            // AHour
            // 
            this.AHour.Interval = 3600000;
            // 
            // ThreeHour
            // 
            this.ThreeHour.Interval = 10800000;
            // 
            // SixHours
            // 
            this.SixHours.Interval = 21600000;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataGridViewServices);
            this.panel1.Location = new System.Drawing.Point(93, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 654);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1422, 763);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Stop_Services_Button);
            this.Controls.Add(this.Start_Service_Button);
            this.Controls.Add(this.Restart_Button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SearchBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1440, 810);
            this.MinimumSize = new System.Drawing.Size(920, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Manager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button Restart_Button;
        private System.Windows.Forms.Button Stop_Services_Button;
        private System.Windows.Forms.Button Start_Service_Button;
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
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem scheduleTimerWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAfterAWhileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFiveMinutesTool;
        private System.Windows.Forms.ToolStripMenuItem fiveMinutesTool;
        private System.Windows.Forms.ToolStripMenuItem startaFifteenMinutesTool;
        private System.Windows.Forms.ToolStripMenuItem startThirtyMinutesTool;
        private System.Windows.Forms.ToolStripMenuItem startAHourTool;
        private System.Windows.Forms.ToolStripMenuItem startThreeHoursTool;
        private System.Windows.Forms.ToolStripMenuItem startSixHoursTool;
        private System.Windows.Forms.ToolStripMenuItem stopFiveMinutesTool;
        private System.Windows.Forms.ToolStripMenuItem stopFifteenMinutesTool;
        private System.Windows.Forms.ToolStripMenuItem stopThirtyMinutesTool;
        private System.Windows.Forms.ToolStripMenuItem stopAHourTool;
        private System.Windows.Forms.ToolStripMenuItem stopThreeHoursTool;
        private System.Windows.Forms.ToolStripMenuItem stopSixHoursTool;
        private System.Windows.Forms.Timer FiveMinutes;
        private System.Windows.Forms.Timer FifteenMinutes;
        private System.Windows.Forms.Timer ThirtyMinutes;
        private System.Windows.Forms.Timer AHour;
        private System.Windows.Forms.Timer ThreeHour;
        private System.Windows.Forms.Timer SixHours;
        private System.Windows.Forms.Panel panel1;
    }
}

