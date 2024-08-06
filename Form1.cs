using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using System.Windows.Forms;

namespace WindowsServiceManager
{

    [Serializable]
    public partial class MainForm : Form
    {
        // Variables
        private string Non_StopServices_filePath = "NonStopServiceList.txt";
        private string Pinned_filePath = "PinnedServiceList.txt";
        string selectedServiceName;
        bool servicesIsRunning;
        bool isRestarting;
        bool showOnlyNonStopServices;
        bool showOnlyPinned;
        bool exitsAnyMessageBox;
        List<string> Non_Stop_Services = new List<string>();
        List<string> Pinned_Services = new List<string>();
        int nameIndex = 0;
        private System.Timers.Timer[] timers;
        int timersCount;

        public MainForm()
        {
            InitializeComponent();
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                ServiceNamesComboBox.Items.Add(service.ServiceName);
            }

            // Insert to table
            dataGridViewServices.CellClick += dataGridView1_CellContentClick;
            SearchBar.Text = "";
            comboBox1.SelectedItem = "All";
            LoadServices();
            timer1.Start();
            dataGridViewServices.ClearSelection();

            Start_Click.Click += Start_ClickItem;
            Stop_Click.Click += Stop_ClickItem;
            Restart_Click.Click += Restart_ClickItem;
            Kill_Click.Click += Kill_Click_Click;
            Start_Service_Button.Visible = false;
            Stop_Services_Button.Visible = false;
            Restart_Button.Visible = false;
            Non_StopServices_filePath_LoadListFromFile();
            Pinned_filePath_LoadListFromFile();
        }


        // Load if matching services, load all services some situation
        private void LoadServices()
        {
            List<ServiceController> servicesList = GetWindowsServices();

            dataGridViewServices.Rows.Clear();

            foreach (ServiceController service in servicesList)
            {
                foreach (string item in Pinned_Services)
                {
                    if (showOnlyNonStopServices && Non_Stop_Services.Contains(item))
                    {
                        if (service.ServiceName == item && service.ServiceName.IndexOf(SearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            #region Get PID
                            int pid;
                            try
                            {
                                var process = Process.GetProcessesByName(service.ServiceName).FirstOrDefault();
                                pid = process?.Id ?? 0;
                            }
                            catch
                            {
                                pid = 0;
                            }
                            #endregion

                            // Assign value to row
                            string[] row = new string[]
                            {
                service.ServiceName,
                pid.ToString(),
                service.DisplayName,
                service.Status.ToString(),
                service.ServiceType.ToString()
                            };

                            dataGridViewServices.Rows.Add(row);
                        }
                    }
                    else if (showOnlyNonStopServices && !Non_Stop_Services.Contains(item) && service.ServiceName.IndexOf(SearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Pass 
                    }
                    else if (service.ServiceName.IndexOf(SearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (service.ServiceName == item && service.ServiceName.IndexOf(SearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            #region Get PID
                            int pid;
                            try
                            {
                                var process = Process.GetProcessesByName(service.ServiceName).FirstOrDefault();
                                pid = process?.Id ?? 0;
                            }
                            catch
                            {
                                pid = 0;
                            }
                            #endregion

                            // Assign value to row
                            string[] row = new string[] {
                                service.ServiceName,
                                pid.ToString(),
                                service.DisplayName,
                                service.Status.ToString(),
                                service.ServiceType.ToString()
                            };
                            dataGridViewServices.Rows.Add(row);
                        }
                    }
                }
                if (!showOnlyPinned && showOnlyNonStopServices && service.ServiceName.IndexOf(SearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foreach (string item in Non_Stop_Services)
                    {
                        if (service.ServiceName == item && !Pinned_Services.Contains(service.ServiceName)) // Don't add services again
                        {
                            #region Get PID
                            int pid;
                            try
                            {
                                var process = Process.GetProcessesByName(service.ServiceName).FirstOrDefault();
                                pid = process?.Id ?? 0;
                            }
                            catch
                            {
                                pid = 0;
                            }
                            #endregion

                            // Assign value to row
                            string[] row = new string[]
                            {
                service.ServiceName,
                pid.ToString(),
                service.DisplayName,
                service.Status.ToString(),
                service.ServiceType.ToString()
                            };

                            dataGridViewServices.Rows.Add(row);
                        }
                    }
                }
                // If matching to Search bar text
                else if (!showOnlyPinned && service.ServiceName.IndexOf(SearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0 && !Pinned_Services.Contains(service.ServiceName)) // Don't add services again)
                {
                    #region Get PID
                    int pid;
                    try
                    {
                        var process = Process.GetProcessesByName(service.ServiceName).FirstOrDefault();
                        pid = process?.Id ?? 0;
                    }
                    catch
                    {
                        pid = 0;
                    }
                    #endregion

                    // Assign value to row
                    string[] row = new string[]
                    {
                service.ServiceName,
                pid.ToString(),
                service.DisplayName,
                service.Status.ToString(),
                service.ServiceType.ToString()
                    };

                    dataGridViewServices.Rows.Add(row);
                }
            }
        }

        // Get all Windows Services
        private List<ServiceController> GetWindowsServices()
        {
            List<ServiceController> servicesList = new List<ServiceController>();

            try
            {
                ServiceController[] services = ServiceController.GetServices();
                servicesList.AddRange(services);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return servicesList;
        }

        #region Data Grid View
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // If row is selected
            {
                selectedServiceName = dataGridViewServices.Rows[e.RowIndex].Cells[nameIndex].Value.ToString();
                // Activated Buttons
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running) // If service not working
                    {
                        Start_Service_Button.Visible = false;
                        Stop_Services_Button.Visible = true;
                        Restart_Button.Visible = true;
                    }
                    else
                    {
                        Start_Service_Button.Visible = true;
                        Stop_Services_Button.Visible = false;
                        Restart_Button.Visible = false;
                    }
                }
            }
        }

        // Right Click Events
        private void dataGridViewServices_MouseDown(object sender, MouseEventArgs e)
        {
            var hitTestInfo = dataGridViewServices.HitTest(e.X, e.Y);

            if (hitTestInfo.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dataGridViewServices.Rows[hitTestInfo.RowIndex].Selected = true;
                selectedServiceName = dataGridViewServices.SelectedRows[nameIndex].Cells[0].Value.ToString();


                ToolStripMenuItem added = contextMenuStrip1.Items["Add_NonStopServices_Click"] as ToolStripMenuItem;
                ToolStripMenuItem pinned = contextMenuStrip1.Items["pin_Click"] as ToolStripMenuItem;

                if (Non_Stop_Services.Contains(selectedServiceName))
                {
                    added.Checked = true;
                }
                else
                {
                    added.Checked = false;
                }

                if (Pinned_Services.Contains(selectedServiceName))
                {
                    pinned.Checked = true;
                }
                else
                {
                    pinned.Checked = false;
                }

                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status != ServiceControllerStatus.Running) // If service not working
                    {
                        ToolStripMenuItem TSMP = new ToolStripMenuItem();

                        Start_Service_Button.Visible = true;
                        Stop_Services_Button.Visible = false;
                        Restart_Button.Visible = false;
                        try
                        {
                            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
                            {
                                if (serviceController.Status != ServiceControllerStatus.Stopped) // Other Situations
                                {
                                    if (item.Name == "Kill_Click")
                                    {
                                        item.Enabled = true;
                                    }
                                    else
                                    {
                                        item.Enabled = false;
                                    }
                                }
                                if (item.Name == "Stop_Click")
                                {
                                    item.Enabled = false;
                                }
                                else if (item.Name == "Restart_Click")
                                {
                                    item.Enabled = false;
                                }
                                else if (item.Name == "Start_Click")
                                {
                                    item.Enabled = true;
                                }
                            }
                        }
                        catch
                        {
                            // Pass
                        }
                    }
                    else
                    {
                        Start_Service_Button.Visible = false;
                        Stop_Services_Button.Visible = true;
                        Restart_Button.Visible = true;
                        try
                        {
                            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
                            {
                                if (item.Name == "Stop_Click")
                                {
                                    item.Enabled = true;
                                }
                                else if (item.Name == "Restart_Click")
                                {
                                    item.Enabled = true;
                                }
                                else if (item.Name == "Start_Click")
                                {
                                    item.Enabled = false;
                                }
                            }
                        }
                        catch
                        {
                            // Pass
                        }
                    }
                }

                contextMenuStrip1.Show(dataGridViewServices, e.Location);

            }
        }

        private void dataGridViewServices_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewServices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Buttons
        private void Start_Service_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    try
                    {
                        serviceController.Start();
                        // Wait for Running
                        serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                    }
                    catch
                    {
                        // if cant't process or access
                        Non_Stop_Services.Remove(selectedServiceName);
                        if (!exitsAnyMessageBox) // dont't stack message boxes
                        {
                            exitsAnyMessageBox = true;
                            MessageBox.Show("This service can't start", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            exitsAnyMessageBox = false;
                        }
                    }
                }
            }
        }

        private void Stop_Services_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running) // If service working
                    {
                        try
                        {
                            serviceController.Stop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (System.ComponentModel.Win32Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running || serviceController.Status == ServiceControllerStatus.Paused)
                    {
                        try
                        {
                            // First stop the service
                            serviceController.Stop();
                            isRestarting = true;
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Occur some erros: {ex.Message}");
                        }
                        catch (System.ComponentModel.Win32Exception ex)
                        {
                            Console.WriteLine($"Acces Error: {ex.Message}");
                        }

                    }
                }
            }
        }
        #endregion

        #region Context Menu Strip // Right Click Events
        private void contextMenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void NonStopServices_Click_Click(object sender, EventArgs e)
        {
            if (!Non_Stop_Services.Contains(selectedServiceName))
            {
                Non_Stop_Services.Add(selectedServiceName);
            }
            else
            {
                Non_Stop_Services.Remove(selectedServiceName);
            }

            LoadServices();
        }

        private void pin_Click_Click(object sender, EventArgs e)
        {
            if (!Pinned_Services.Contains(selectedServiceName))
            {
                Pinned_Services.Add(selectedServiceName);
            }
            else
            {
                Pinned_Services.Remove(selectedServiceName);
            }

            LoadServices();
        }

        private void Start_ClickItem(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    try
                    {
                        serviceController.Start();
                        // Wait for Running
                        serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                    }
                    catch
                    {
                        // if cant't process or access
                        Non_Stop_Services.Remove(selectedServiceName);
                        if (!exitsAnyMessageBox) // dont't stack message boxes
                        {
                            exitsAnyMessageBox = true;
                            MessageBox.Show("This service can't start", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            exitsAnyMessageBox = false;
                        }
                    }
                }
            }
        }

        private void Stop_ClickItem(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running) // If service working
                    {
                        try
                        {
                            serviceController.Stop();
                        }
                        catch
                        {
                            // if cant't process or access
                            Non_Stop_Services.Remove(selectedServiceName);
                            if (!exitsAnyMessageBox) // dont't stack message boxes
                            {
                                exitsAnyMessageBox = true;
                                MessageBox.Show("This service can't stop", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                exitsAnyMessageBox = false;
                            }
                        }
                    }
                }
            }
        }

        private void Kill_Click_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    try
                    {
                        serviceController.Stop();
                        Process[] process = Process.GetProcessesByName(selectedServiceName);
                        if (process.Length > 0)
                        {
                            foreach (Process proc in process)
                            {
                                proc.Kill();
                            }
                        }
                    }
                    catch
                    {
                        // if cant't process or access
                        Non_Stop_Services.Remove(selectedServiceName);
                        if (!exitsAnyMessageBox) // dont't stack message boxes
                        {
                            exitsAnyMessageBox = true;
                            MessageBox.Show("This service can't stop", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            exitsAnyMessageBox = false;
                        }
                    }
                }
            }
        }

        private void Restart_ClickItem(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running || serviceController.Status == ServiceControllerStatus.Paused)
                    {
                        try
                        {
                            // First stop the service
                            serviceController.Stop();
                            isRestarting = true;
                        }
                        catch
                        {
                            // if cant't process or access
                            Non_Stop_Services.Remove(selectedServiceName);
                            if (!exitsAnyMessageBox) // dont't stack message boxes
                            {
                                exitsAnyMessageBox = true;
                                MessageBox.Show("This service can't stop", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                exitsAnyMessageBox = false;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        private int MinLetter()
        {
            int letterCounter = 0;
            foreach (var item in SearchBar.Text)
            {
                letterCounter++;
            }
            return letterCounter;
        }

        private void SearchBar_TextChanged_1(object sender, EventArgs e)
        {
            if (MinLetter() >= 3)
            {
                dataGridViewServices.Rows.Clear();
                LoadServices();
            }
            else if (MinLetter() > 0)
            {
                //Alert_Label.Text = $"ALERT! \t The minimum number of characters is 3.";
                dataGridViewServices.Rows.Clear();
            }
            else if (MinLetter() == 0)
            {
                dataGridViewServices.Rows.Clear();
                LoadServices();
            }
            else
            {
                //Alert_Label.Text = "";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Update Service Statuses for check status every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            Non_StopServices_filePath_SaveListToFile();
            PinnedServices_filePath_SaveListToFile();

            UpdateAllServiceStatuses();

            // Non-Stop Services
            foreach (DataGridViewRow item in dataGridViewServices.Rows)
            {
                string firstCellValue = "";
                foreach (string ServiceNames in Non_Stop_Services)
                {
                    if (!item.IsNewRow)
                    {
                        firstCellValue = item.Cells[0].Value?.ToString();

                        if (firstCellValue == ServiceNames)
                        {
                            if (!string.IsNullOrEmpty(ServiceNames) && !string.IsNullOrEmpty(firstCellValue))
                            {
                                using (ServiceController serviceController = new ServiceController(ServiceNames))
                                {
                                    if (serviceController.Status != ServiceControllerStatus.Running) // If service not working
                                    {
                                        try
                                        {
                                            serviceController.Start();
                                            // Wait for Running
                                            serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                                        }
                                        catch
                                        {
                                            // if cant't process or access
                                            Non_Stop_Services.Remove(ServiceNames);
                                            if (!exitsAnyMessageBox) // dont't stack message boxes
                                            {
                                                exitsAnyMessageBox = true;
                                                MessageBox.Show("This service can't start", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                exitsAnyMessageBox = false;
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Continue restarting
            if (isRestarting)
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status != ServiceControllerStatus.Running)
                    {
                        serviceController.Start();
                        serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30)); // Wait for Running
                    }
                }
                isRestarting = false;
            }
        }

        #region Pinned Services Save - Load
        private void PinnedServices_filePath_SaveListToFile()
        {
            File.WriteAllLines(Pinned_filePath, Pinned_Services);
        }

        private void Pinned_filePath_LoadListFromFile()
        {
            if (File.Exists(Pinned_filePath))
            {
                Pinned_Services = new List<string>(File.ReadAllLines(Pinned_filePath));
            }
        }
        #endregion

        #region Non-Stop Services Save - Load
        private void Non_StopServices_filePath_SaveListToFile()
        {
            try
            {
                File.WriteAllLines(Non_StopServices_filePath, Non_Stop_Services);
                Console.WriteLine("Liste başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }

        private void Non_StopServices_filePath_LoadListFromFile()
        {
            try
            {
                if (File.Exists(Non_StopServices_filePath))
                {
                    Non_Stop_Services = new List<string>(File.ReadAllLines(Non_StopServices_filePath));
                    Console.WriteLine("Liste başarıyla yüklendi.");
                }
                else
                {
                    Console.WriteLine("Dosya bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }
        #endregion

        // Update every service statuses
        private void UpdateAllServiceStatuses()
        {
            int nameColumnIndex = dataGridViewServices.Columns[nameIndex].Index;
            int statusColumnIndex = dataGridViewServices.Columns[3].Index;

            foreach (DataGridViewRow row in dataGridViewServices.Rows)
            {
                if (!row.IsNewRow) // if not new row
                {
                    // Take service name
                    string serviceName = row.Cells[nameIndex].Value.ToString();

                    // check the service status
                    string status = GetServiceStatus(serviceName);

                    // assign to status column
                    row.Cells[statusColumnIndex].Value = status;
                }
            }
        }

        // Determine statuses value
        private string GetServiceStatus(string serviceName)
        {
            try
            {
                ServiceController service = new ServiceController(serviceName);

                switch (service.Status)
                {
                    case ServiceControllerStatus.Running:
                        {
                            return "Running";
                        }
                    case ServiceControllerStatus.Stopped:
                        return "Stopped";
                    case ServiceControllerStatus.Paused:
                        return "Paused";
                    case ServiceControllerStatus.StartPending:
                    case ServiceControllerStatus.StopPending:
                        return "Pending";
                    default:
                        return "Unknown";
                }

            }
            catch (Exception)
            {
                return "Unknown";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBox1.SelectedItem as string;
            if (selectedItem != null)
            {
                if (selectedItem == "All")
                {
                    showOnlyNonStopServices = false;
                    showOnlyPinned = false;
                }
                else if (selectedItem == "Non-Stop Services")
                {
                    showOnlyNonStopServices = true;
                    showOnlyPinned = false;
                }
                else if (selectedItem == "Pinned")
                {
                    showOnlyNonStopServices = false;
                    showOnlyPinned = true;
                }

                LoadServices();
            }
        }

        private void OpenServices_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void GoToServicesButton_Click_1(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            WorkTimePanel.Visible = false;
        }

        private void WorkTimerForm_Button_Click_1(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            WorkTimePanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            WorkTimePanel.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Add_WorkTime_Button_Click(object sender, EventArgs e)
        {
            timersCount++;
            DataGridViewColumn firstColumn = dataGridViewServices.Columns[0];
            ServiceController[] services = ServiceController.GetServices();
            try
            {
                if (timersCount > 10)
                {

                    MessageBox.Show("Worker can not be more than ten.", "Limit crossed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timersCount--;
                }
                else
                {
                    int timeInterval = Convert.ToInt32(TimeInterval.Text);
                    string[] row = new string[2];
                    if (timersCount < 10)
                    {
                        foreach (ServiceController service in services)
                        {
                            if (service.ServiceName == ServiceNamesComboBox.Text && timeInterval > 0)
                            {
                                row[0] = ServiceNamesComboBox.Text.ToString();
                                row[1] = TimeInterval.Text.ToString();
                                WorkTimeGrid.Rows.Add(row);
                            }
                        }
                        if (row[0] == null)
                        {
                            MessageBox.Show("System can't found service name", "Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            timersCount--;
                        }
                        else
                        {
                            #region Timers
                            timers = new System.Timers.Timer[timersCount];
                            timers[timersCount] = new System.Timers.Timer();
                            timers[timersCount].Interval = Convert.ToInt32(TimeInterval.Text) * 1000;
                            timers[timersCount].Elapsed += TimerElapsed;

                            timers[timersCount].Start();
                            #endregion
                        }
                    }
                    else if (timeInterval <= 0)
                    {
                        MessageBox.Show("Time Interval's time Couldn't smaller than 1 ", "Unacceptable Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timersCount--;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Time Interval's time Couldn't empty ", "Unacceptable Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timersCount--;
            }
        }
        #region Timers Methods
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            StartService(TimeInterval.Text);         
        }

        private void StartService(string serviceName)
        {
            try
            {
                // ServiceController ile belirtilen servisi başlat
                using (ServiceController service = new ServiceController(serviceName))
                {
                    // Servisin mevcut durumunu kontrol et
                    if (service.Status == ServiceControllerStatus.Stopped || service.Status == ServiceControllerStatus.StopPending)
                    {
                        // Servisi başlat
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30)); // Başlaması için 30 saniye bekle
                        MessageBox.Show($"Servis '{serviceName}' başarıyla başlatıldı.");
                    }
                    else
                    {
                        MessageBox.Show($"Servis '{serviceName}' zaten çalışıyor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Servis başlatılırken hata oluştu: {ex.Message}");
            }
        }

        #endregion
    }
}
