namespace DataManagmentSystem
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息展示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息录入ToolStripMenuItem,
            this.信息展示ToolStripMenuItem,
            this.信息加载ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2430, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 信息录入ToolStripMenuItem
            // 
            this.信息录入ToolStripMenuItem.Name = "信息录入ToolStripMenuItem";
            this.信息录入ToolStripMenuItem.Size = new System.Drawing.Size(152, 48);
            this.信息录入ToolStripMenuItem.Text = "信息录入";
            this.信息录入ToolStripMenuItem.Click += new System.EventHandler(this.信息录入ToolStripMenuItem_Click);
            // 
            // 信息展示ToolStripMenuItem
            // 
            this.信息展示ToolStripMenuItem.Name = "信息展示ToolStripMenuItem";
            this.信息展示ToolStripMenuItem.Size = new System.Drawing.Size(150, 48);
            this.信息展示ToolStripMenuItem.Text = "信息展示";
            this.信息展示ToolStripMenuItem.Click += new System.EventHandler(this.信息展示ToolStripMenuItem_Click);
            // 
            // 信息加载ToolStripMenuItem
            // 
            this.信息加载ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息导入ToolStripMenuItem});
            this.信息加载ToolStripMenuItem.Name = "信息加载ToolStripMenuItem";
            this.信息加载ToolStripMenuItem.Size = new System.Drawing.Size(152, 48);
            this.信息加载ToolStripMenuItem.Text = "信息加载";
            // 
            // 信息导入ToolStripMenuItem
            // 
            this.信息导入ToolStripMenuItem.Name = "信息导入ToolStripMenuItem";
            this.信息导入ToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.信息导入ToolStripMenuItem.Text = "信息导入";
            this.信息导入ToolStripMenuItem.Click += new System.EventHandler(this.信息导入ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2430, 1471);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息展示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息导入ToolStripMenuItem;
    }
}

