using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace images_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // to exit from the application
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // to memory cleanup from the old PictureBoxes
        private void clearMemory()
        {
            while (panel1.Controls.Count > 1)
            {
                panel1.Controls[1].Dispose();
            }
        }
        // create open file dialog to choose the images
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "jpg Images|*.jpg|jpeg Images|*.jpeg|png Images|*.png|All Images|*.jpg;*.png;*.jpeg";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String img in ofd.FileNames)
                {
                    listBox2.Items.Add(img); // to store image path
                    listBox1.Items.Add(Path.GetFileName(img)); // to store image name
                }
            }
        }
        // timer to help slide-show-mode 
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox2.Items[listBox1.SelectedIndex].ToString());
            statusBar1.Text = "Image name : " + (listBox1.SelectedItem.ToString());
            listBox1.SelectedIndex = (listBox1.SelectedIndex + 1) % listBox1.Items.Count;
        }
        void setMode(byte a, byte b, byte c,byte d,bool b1,bool b2 ,bool b3)
        {
            ((ToolStripMenuItem)contextMenuStrip1.Items[a]).Checked = true;
            contextMenuStrip1.Items[b].Visible = false;
            contextMenuStrip1.Items[c].Visible = false;
            contextMenuStrip1.Items[d].Visible = true;
            panel1.AutoScroll = b1;
            pictureBox1.Visible = b2; 
            statusBar1.Visible = b3;
            if(b2==true)
                listBox1.SelectionMode = SelectionMode.One;
            else
                listBox1.SelectionMode = SelectionMode.MultiExtended;
            clearMemory(); 
        }
        // Single-mode
        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMode(0, 1, 2, 3, false, true, false); 
            
        }
        // Multi-mode
        private void multiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMode(1, 0, 2, 3, true, false, false);
        }
        // Slide-Show-mode
        private void slideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMode(2, 0, 1, 3, false, true, true);
            if (listBox1.Items.Count >= 1)
            {
                listBox1.SelectedIndex = 0;
                if (listBox1.Items.Count == 1)
                    pictureBox1.Image = Image.FromFile(listBox2.Items[0].ToString());
                else
                    timer1.Start();
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // single-mode
            if (((ToolStripMenuItem)contextMenuStrip1.Items[0]).Checked == true)
            {
                clearMemory();
                if (listBox1.SelectedIndex > -1)
                {
                    pictureBox1.Image = Image.FromFile(listBox2.Items[listBox1.SelectedIndex].ToString());
                    statusBar1.Text = "Image name : " + (listBox1.SelectedItem.ToString());
                }
            }
            // multi-mode
            else if (((ToolStripMenuItem)contextMenuStrip1.Items[1]).Checked == true)
            {
                clearMemory();
                int x = 0, y = 0;
                foreach (int item in listBox1.SelectedIndices)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(listBox2.Items[item].ToString());
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Size = new Size(100, 100); x += 110;
                    if (x > panel1.ClientSize.Width - 100)
                    {
                        x = 0; y += 110;
                    }
                    panel1.Controls.Add(pic);
                }
            }
            else if (((ToolStripMenuItem)contextMenuStrip1.Items[2]).Checked == false && listBox1.SelectedIndex != -1)
            {
                timer1.Stop();
                MessageBox.Show("Please Select The Mode First");
                listBox1.SelectedIndex = -1;
            }
        }
        private void changeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop(); clearMemory(); pictureBox1.Image = null;
            ((ToolStripMenuItem)contextMenuStrip1.Items[0]).Checked = false;
            ((ToolStripMenuItem)contextMenuStrip1.Items[1]).Checked = false;
            ((ToolStripMenuItem)contextMenuStrip1.Items[2]).Checked = false;
            contextMenuStrip1.Items[0].Visible = true;
            contextMenuStrip1.Items[1].Visible = true;
            contextMenuStrip1.Items[2].Visible = true;
            contextMenuStrip1.Items[3].Visible = false;
            statusBar1.Visible = false;
            listBox1.SelectedIndex = -1;
        }

    }
}