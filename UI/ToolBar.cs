using System.Windows.Forms;

namespace NetControlApp
{
    public class ToolBar : ToolStrip
    {
        private ToolStripButton startButton;
        private ToolStripButton stopButton;
        private ToolStripButton blockButton;
        private ToolStripButton unblockButton;

        public ToolBar()
        {
            InitializeToolBar();
        }

        private void InitializeToolBar()
        {
            // Initialize buttons
            startButton = new ToolStripButton("Start Monitoring");
            stopButton = new ToolStripButton("Stop Monitoring");
            blockButton = new ToolStripButton("Block Device");
            unblockButton = new ToolStripButton("Unblock Device");

            // Add buttons to toolbar
            this.Items.Add(startButton);
            this.Items.Add(stopButton);
            this.Items.Add(new ToolStripSeparator());
            this.Items.Add(blockButton);
            this.Items.Add(unblockButton);

            // Attach event handlers
            startButton.Click += StartButton_Click;
            stopButton.Click += StopButton_Click;
            blockButton.Click += BlockButton_Click;
            unblockButton.Click += UnblockButton_Click;
        }

        // Event handlers for button clicks
        private void StartButton_Click(object sender, System.EventArgs e)
        {
            // Logic to start monitoring
            MessageBox.Show("Start Monitoring clicked");
        }

        private void StopButton_Click(object sender, System.EventArgs e)
        {
            // Logic to stop monitoring
            MessageBox.Show("Stop Monitoring clicked");
        }

        private void BlockButton_Click(object sender, System.EventArgs e)
        {
            // Logic to block a device
            MessageBox.Show("Block Device clicked");
        }

        private void UnblockButton_Click(object sender, System.EventArgs e)
        {
            // Logic to unblock a device
            MessageBox.Show("Unblock Device clicked");
        }
    }
}
