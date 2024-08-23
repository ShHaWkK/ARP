namespace NetControlApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private CustomTreeGridView treeGridView1;
        private ToolBar toolBar;
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
            this.Text = "Net Control App";
            this.Width = 800;
            this.Height = 600;

            
            // 
            // treeGridView1
            // 
            this.treeGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new AdvancedDataGridView.TreeGridColumn() { HeaderText = "PC Name", Name = "ColPCName" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "IP", Name = "ColPCIP" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "MAC", Name = "ColPCMac" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Download", Name = "ColDownload" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Upload", Name = "ColUpload" },
            new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn() { HeaderText = "DownCap", Name = "ColDownCap" },
            new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn() { HeaderText = "UploadCap", Name = "ColUploadCap" },
            new System.Windows.Forms.DataGridViewCheckBoxColumn() { HeaderText = "Block", Name = "ColBlock" },
            new System.Windows.Forms.DataGridViewCheckBoxColumn() { HeaderText = "Spoof", Name = "ColSpoof" }
            });
            this.treeGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGridView1.Location = new System.Drawing.Point(0, 0);
            this.treeGridView1.Name = "treeGridView1";
            this.treeGridView1.Size = new System.Drawing.Size(800, 400);
            this.treeGridView1.TabIndex = 0;
            this.treeGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TreeGridView1_CellValueChanged);
            this.treeGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.TreeGridView1_CurrentCellDirtyStateChanged);

            // 
            // toolBar
            // 
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(800, 25);
            this.toolBar.TabIndex = 1;

            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(50, 420);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Monitoring";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);

            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(200, 420);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 30);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop Monitoring";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeGridView1);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Name = "MainForm";
            this.Text = "Network Control Application";
            ((System.ComponentModel.ISupportInitialize)(this.treeGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
