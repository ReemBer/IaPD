namespace Wireless
{
    partial class WifiManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.macAdressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connectionQualityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectionListView
            // 
            this.connectionListView.AllowColumnReorder = true;
            this.connectionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.macAdressColumnHeader,
            this.connectionQualityColumnHeader,
            this.authTypeColumnHeader});
            this.connectionListView.FullRowSelect = true;
            this.connectionListView.Location = new System.Drawing.Point(12, 12);
            this.connectionListView.Name = "connectionListView";
            this.connectionListView.Size = new System.Drawing.Size(462, 271);
            this.connectionListView.TabIndex = 0;
            this.connectionListView.UseCompatibleStateImageBehavior = false;
            this.connectionListView.View = System.Windows.Forms.View.Details;
            this.connectionListView.SelectedIndexChanged += new System.EventHandler(this.connectionListView_SelectedIndexChanged);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 107;
            // 
            // macAdressColumnHeader
            // 
            this.macAdressColumnHeader.Text = "MAC-address";
            this.macAdressColumnHeader.Width = 108;
            // 
            // connectionQualityColumnHeader
            // 
            this.connectionQualityColumnHeader.Text = "Connection quality";
            this.connectionQualityColumnHeader.Width = 107;
            // 
            // authTypeColumnHeader
            // 
            this.authTypeColumnHeader.Text = "Auth";
            this.authTypeColumnHeader.Width = 136;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(9, 300);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 4;
            // 
            // WifiManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 322);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectionListView);
            this.Name = "WifiManagerForm";
            this.Text = "Wifi Manager";
            this.Load += new System.EventHandler(this.InitializeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView connectionListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader macAdressColumnHeader;
        private System.Windows.Forms.ColumnHeader connectionQualityColumnHeader;
        private System.Windows.Forms.ColumnHeader authTypeColumnHeader;
        private System.Windows.Forms.Label statusLabel;
    }
}

