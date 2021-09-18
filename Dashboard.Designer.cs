namespace BloodBank
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewDonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNewDonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDonerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new XanderUI.XUIButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonerToolStripMenuItem,
            this.updateNewDonerToolStripMenuItem,
            this.deleteDonerToolStripMenuItem,
            this.allDonerListToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewDonerToolStripMenuItem
            // 
            this.addNewDonerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDonerToolStripMenuItem.Image")));
            this.addNewDonerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewDonerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDonerToolStripMenuItem.Name = "addNewDonerToolStripMenuItem";
            this.addNewDonerToolStripMenuItem.Size = new System.Drawing.Size(153, 64);
            this.addNewDonerToolStripMenuItem.Text = "Add New Doner";
            this.addNewDonerToolStripMenuItem.Click += new System.EventHandler(this.addNewDonerToolStripMenuItem_Click);
            // 
            // updateNewDonerToolStripMenuItem
            // 
            this.updateNewDonerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateNewDonerToolStripMenuItem.Image")));
            this.updateNewDonerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateNewDonerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateNewDonerToolStripMenuItem.Name = "updateNewDonerToolStripMenuItem";
            this.updateNewDonerToolStripMenuItem.Size = new System.Drawing.Size(145, 64);
            this.updateNewDonerToolStripMenuItem.Text = "Update  Doner";
            this.updateNewDonerToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateNewDonerToolStripMenuItem.Click += new System.EventHandler(this.updateNewDonerToolStripMenuItem_Click);
            // 
            // deleteDonerToolStripMenuItem
            // 
            this.deleteDonerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonerToolStripMenuItem.Image")));
            this.deleteDonerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDonerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonerToolStripMenuItem.Name = "deleteDonerToolStripMenuItem";
            this.deleteDonerToolStripMenuItem.Size = new System.Drawing.Size(137, 64);
            this.deleteDonerToolStripMenuItem.Text = "Delete Doner";
            this.deleteDonerToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteDonerToolStripMenuItem.Click += new System.EventHandler(this.deleteDonerToolStripMenuItem_Click);
            // 
            // allDonerListToolStripMenuItem
            // 
            this.allDonerListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDonerListToolStripMenuItem.Image")));
            this.allDonerListToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allDonerListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allDonerListToolStripMenuItem.Name = "allDonerListToolStripMenuItem";
            this.allDonerListToolStripMenuItem.Size = new System.Drawing.Size(139, 64);
            this.allDonerListToolStripMenuItem.Text = "All Doner List";
            this.allDonerListToolStripMenuItem.Click += new System.EventHandler(this.allDonerListToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(117, 64);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ButtonImage")));
            this.btnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.btnExit.ButtonText = "X";
            this.btnExit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnExit.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.CornerRadius = 1;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnExit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExit.Location = new System.Drawing.Point(823, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 26);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextColor = System.Drawing.Color.Maroon;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 519);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewDonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateNewDonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private XanderUI.XUIButton btnExit;
        private System.Windows.Forms.ToolStripMenuItem allDonerListToolStripMenuItem;
    }
}