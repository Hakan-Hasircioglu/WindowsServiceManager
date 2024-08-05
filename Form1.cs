using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;

namespace WindowsServiceManager
{
    public partial class MainForm : Form
    {
        // Variables
        string selectedServiceName;
        bool servicesIsRunning;
        bool isRestarting;
        bool showOnlyNonStopServices;
        List<string> Non_Stop_Services = new List<string>();
        List<string> Pinned_Services = new List<string>();
        int nameIndex = 0;

        public MainForm()
        {
            InitializeComponent();
            // Insert to table
            dataGridViewServices.CellClick += dataGridView1_CellContentClick;
            SearchBar.Text = "";
            comboBox1.SelectedItem = "All";
            LoadServices();
            timer1.Start();
            dataGridViewServices.ClearSelection();
        }

        #region Context Menu Buttons
        private void Start_ClickItem(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedServiceName))
            {
                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status != ServiceControllerStatus.Running) // If service not working
                    {
                        serviceController.Start();
                        serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30)); // Wait for Running
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
        #endregion

        // Load if matching services, load all services some situation
        private void LoadServices()
        {
            List<ServiceController> servicesList = GetWindowsServices();

            dataGridViewServices.Rows.Clear();

            foreach (ServiceController service in servicesList)
            {
                // If matching to Search bar text
                if (showOnlyNonStopServices)
                {
                    foreach (string item in Non_Stop_Services)
                    {
                        if (service.ServiceName == item)
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
                else if (service.ServiceName.IndexOf(SearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0)
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
                    }
                    else
                    {
                        Start_Service_Button.Visible = true;
                        Stop_Services_Button.Visible = false;
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

                using (ServiceController serviceController = new ServiceController(selectedServiceName))
                {
                    if (serviceController.Status != ServiceControllerStatus.Running) // If service not working
                    {
                        Start_Service_Button.Visible = true;
                        Stop_Services_Button.Visible = false;
                        foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
                        {
                            if (item.Name == "Start_Click")
                            {
                                item.Enabled = true;
                            }
                            else if (item.Name == "Stop_Click")
                            {
                                item.Enabled = false;
                            }

                        }
                    }
                    else
                    {
                        Start_Service_Button.Visible = false;
                        Stop_Services_Button.Visible = true;
                        foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
                        {
                            if (item.Name == "Stop_Click")
                            {
                                item.Enabled = true;
                            }
                            else if (item.Name == "Start_Click")
                            {
                                item.Enabled = false;
                            }

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
                    if (serviceController.Status != ServiceControllerStatus.Running) // If service not working
                    {
                        serviceController.Start();
                        serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30)); // Wait for Running
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
                    }

                    if (firstCellValue == ServiceNames)
                    {
                        using (ServiceController serviceController = new ServiceController(selectedServiceName))
                        {
                            if (serviceController.Status != ServiceControllerStatus.Running)
                            {
                                serviceController.Start();
                                serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30)); // Wait for Running
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
                        return "Running";
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

        private void contextMenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void NonStopServices_Click_Click(object sender, EventArgs e)
        {
            if (!Non_Stop_Services.Contains(selectedServiceName))
            {
                Non_Stop_Services.Add(selectedServiceName);
            }
            ToolStripMenuItem delNonStopServices = contextMenuStrip1.Items["Delete_NonStopServices_Click"] as ToolStripMenuItem;
            ToolStripMenuItem addNonStopServices = contextMenuStrip1.Items["Add_NonStopServices_Click"] as ToolStripMenuItem;

            addNonStopServices.Visible = false;
            delNonStopServices.Visible = true;
        }

        private void Delete_NonStopServices_Click_Click(object sender, EventArgs e)
        {
            Non_Stop_Services.Remove(selectedServiceName);
            ToolStripMenuItem delNonStopServices = contextMenuStrip1.Items["Delete_NonStopServices_Click"] as ToolStripMenuItem;
            ToolStripMenuItem addNonStopServices = contextMenuStrip1.Items["Add_NonStopServices_Click"] as ToolStripMenuItem;

            addNonStopServices.Visible = true;
            delNonStopServices.Visible = false;

            if (showOnlyNonStopServices)
            {
                LoadServices();
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
                }
                else if (selectedItem == "Non-Stop Services")
                {
                    showOnlyNonStopServices = true;
                }

                LoadServices();
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pin_Click_Click(object sender, EventArgs e)
        {

        }
    }
}
