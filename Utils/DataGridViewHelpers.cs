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
    }
}
