using AdvancedDataGridView;

namespace NetControlApp
{
    public class CustomTreeGridView : TreeGridView
    {
        public CustomTreeGridView()
        {
            this.NodeMouseClick += CustomTreeGridView_NodeMouseClick;
        }

        private void CustomTreeGridView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Logic for node click event
            TreeGridNode node = (TreeGridNode)e.Node;
            System.Windows.Forms.MessageBox.Show($"Node clicked: {node.Cells[0].Value}");
        }
    }
}
