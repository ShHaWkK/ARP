using System.Windows.Forms;

namespace NetControlApp
{
    public class ContextMenuHandlers
    {
        public static void HandleContextMenuOpening(ContextMenuStrip menu, DataGridView gridView)
        {
            // Clear previous items
            menu.Items.Clear();

            // Add new items based on selected cell
            if (gridView.CurrentCell != null)
            {
                menu.Items.Add(new ToolStripMenuItem("Block Device", null, (s, e) => BlockDevice(gridView)));
                menu.Items.Add(new ToolStripMenuItem("Unblock Device", null, (s, e) => UnblockDevice(gridView)));
            }
        }

        private static void BlockDevice(DataGridView gridView)
        {
            string ip = gridView.CurrentRow.Cells["ColPCIP"].Value.ToString();
            MessageBox.Show($"Blocking device with IP: {ip}");
            // Logic to block device
        }

        private static void UnblockDevice(DataGridView gridView)
        {
            string ip = gridView.CurrentRow.Cells["ColPCIP"].Value.ToString();
            MessageBox.Show($"Unblocking device with IP: {ip}");
            // Logic to unblock device
        }
    }
}
