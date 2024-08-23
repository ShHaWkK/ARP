using System;
using System.Windows.Forms;

namespace NetControlApp
{
    public partial class MainForm : Form
    {
        private ARPManager arpManager;
        private NetworkMonitor networkMonitor;
        private DeviceBlocker deviceBlocker;

        public MainForm()
                {
                    InitializeComponent();
                }

        private void InitializeNetworkComponents()
        {
            var devices = SharpPcap.CaptureDeviceList.Instance;
            if (devices.Count < 1)
            {
                MessageBox.Show("No network devices found! Please install a network driver.");
                return;
            }

            var device = devices[0]; 
            arpManager = new ARPManager(device);
            networkMonitor = new NetworkMonitor(device);
            deviceBlocker = new DeviceBlocker(arpManager);
        }

        private void TreeGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColBlock.Index)
            {
                var block = (bool)treeGridView1.Rows[e.RowIndex].Cells[ColBlock.Index].Value;
                var ipAddress = treeGridView1.Rows[e.RowIndex].Cells[ColPCIP.Index].Value.ToString();
                if (block)
                {
                    deviceBlocker.BlockDevice(ipAddress);
                }
                else
                {
                    deviceBlocker.UnblockDevice(ipAddress);
                }
            }
        }

        private void TreeGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (treeGridView1.IsCurrentCellDirty)
            {
                treeGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            networkMonitor.StartMonitoring();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            networkMonitor.StopMonitoring();
        }
    }
}
