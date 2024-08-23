namespace NetControlApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private AdvancedDataGridView.TreeGridView treeGridView1;
        private AdvancedDataGridView.TreeGridColumn ColPCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPCIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPCMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpload;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn ColDownCap;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn ColUploadCap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColBlock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSpoof;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.treeGridView1 = new AdvancedDataGridView.TreeGridView();
            this.ColPCName = new AdvancedDataGridView.TreeGridColumn();
            this.ColPCIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPCMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDownload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDownCap = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.ColUploadCap = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.ColBlock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColSpoof = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treeGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeGridView1
            // 
            this.treeGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPCName,
            this.ColPCIP,
            this.ColPCMac,
            this.ColDownload,
            this.ColUpload,
            this.ColDownCap,
            this.ColUploadCap,
            this.ColBlock,
            this.ColSpoof});
            this.treeGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeGridView1.Location = new System.Drawing.Point(0, 0);
            this.treeGridView1.Name = "treeGridView1";
            this.treeGridView1.Size = new System.Drawing.Size(800, 400);
            this.treeGridView1.TabIndex = 0;
            this.treeGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TreeGridView1_CellValueChanged);
            this.treeGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.TreeGridView1_CurrentCellDirtyStateChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(50, 420);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Monitoring";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(200, 420);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 30);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop Monitoring";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.treeGridView1);
            this.Name = "MainForm";
            this.Text = "Network Control Application";
            ((System.ComponentModel.ISupportInitialize)(this.treeGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
