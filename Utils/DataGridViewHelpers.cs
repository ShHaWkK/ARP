using System.Windows.Forms;

namespace NetControlApp
{
    public static class DataGridViewHelpers
    {
        public static void UpdateCellValue(DataGridView gridView, int rowIndex, int colIndex, object value)
        {
            if (gridView.Rows[rowIndex].Cells[colIndex].Value != value)
            {
                gridView.Rows[rowIndex].Cells[colIndex].Value = value;
            }
        }

        public static void AddDeviceRow(DataGridView gridView, PC device)
        {
            int rowIndex = gridView.Rows.Add();
            gridView.Rows[rowIndex].Cells["ColPCName"].Value = device.Name;
            gridView.Rows[rowIndex].Cells["ColPCIP"].Value = device.IP.ToString();
            gridView.Rows[rowIndex].Cells["ColPCMac"].Value = device.Mac.ToString();
            gridView.Rows[rowIndex].Cells["ColDownload"].Value = "0";
            gridView.Rows[rowIndex].Cells["ColUpload"].Value = "0";
            gridView.Rows[rowIndex].Cells["ColDownCap"].Value = device.CapDown;
            gridView.Rows[rowIndex].Cells["ColUploadCap"].Value = device.CapUp;
            gridView.Rows[rowIndex].Cells["ColBlock"].Value = false;
            gridView.Rows[rowIndex].Cells["ColSpoof"].Value = false;
        }

        public static PC GetSelectedDevice(DataGridView gridView)
        {
            if (gridView.CurrentRow != null)
            {
                string ip = gridView.CurrentRow.Cells["ColPCIP"].Value.ToString();
                string mac = gridView.CurrentRow.Cells["ColPCMac"].Value.ToString();
                return new PC
                {
                    IP = NetworkUtils.ParseIPAddress(ip),
                    Mac = NetworkUtils.ParseMacAddress(mac),
                    Name = gridView.CurrentRow.Cells["ColPCName"].Value.ToString()
                };
            }
            return null;
        }
    }
}
