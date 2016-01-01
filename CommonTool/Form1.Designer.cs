namespace CommonTool
{
    partial class Form1
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
            this.常用工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hex2StringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.常用工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 常用工具ToolStripMenuItem
            // 
            this.常用工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hex2StringToolStripMenuItem});
            this.常用工具ToolStripMenuItem.Name = "常用工具ToolStripMenuItem";
            this.常用工具ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.常用工具ToolStripMenuItem.Text = "常用工具";
            // 
            // hex2StringToolStripMenuItem
            // 
            this.hex2StringToolStripMenuItem.Name = "hex2StringToolStripMenuItem";
            this.hex2StringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hex2StringToolStripMenuItem.Text = "Hex2String";
            this.hex2StringToolStripMenuItem.Click += new System.EventHandler(this.hex2StringToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 75);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 常用工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hex2StringToolStripMenuItem;
    }
}

