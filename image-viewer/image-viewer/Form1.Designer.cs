namespace images_viewer
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.multiToolStripMenuItem,
            this.slideToolStripMenuItem,
            this.changeModeToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 114);
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.singleToolStripMenuItem.Text = "Single-Mode";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // multiToolStripMenuItem
            // 
            this.multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            this.multiToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.multiToolStripMenuItem.Text = "Multi-Mode";
            this.multiToolStripMenuItem.Click += new System.EventHandler(this.multiToolStripMenuItem_Click);
            // 
            // slideToolStripMenuItem
            // 
            this.slideToolStripMenuItem.Name = "slideToolStripMenuItem";
            this.slideToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.slideToolStripMenuItem.Text = "Slide-Show-Mode";
            this.slideToolStripMenuItem.Click += new System.EventHandler(this.slideToolStripMenuItem_Click);
            // 
            // changeModeToolStripMenuItem
            // 
            this.changeModeToolStripMenuItem.Name = "changeModeToolStripMenuItem";
            this.changeModeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.changeModeToolStripMenuItem.Text = "Change-Mode";
            this.changeModeToolStripMenuItem.Visible = false;
            this.changeModeToolStripMenuItem.Click += new System.EventHandler(this.changeModeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(429, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(165, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(130, 4);
            this.listBox2.TabIndex = 8;
            this.listBox2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(176, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 309);
            this.panel1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 342);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // statusBar1
            // 
            this.statusBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar1.Location = new System.Drawing.Point(176, 331);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(448, 42);
            this.statusBar1.TabIndex = 10;
            this.statusBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 373);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 411);
            this.Name = "Form1";
            this.Text = "Images-Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem changeModeToolStripMenuItem;
    }
}

