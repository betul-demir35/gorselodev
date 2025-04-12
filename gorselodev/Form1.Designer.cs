namespace gorselodev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPageTumOyunlar = new TabPage();
            dataGridViewTumOyunlar = new DataGridView();
            pictureBox2 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            çıkışToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            tabPageKategoriler = new TabPage();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            dataGridViewKategoriler = new DataGridView();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            yARDIMToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPageTumOyunlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTumOyunlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPageKategoriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKategoriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Right;
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPageTumOyunlar);
            tabControl1.Controls.Add(tabPageKategoriler);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 250);
            tabControl1.TabIndex = 1;
            // 
            // tabPageTumOyunlar
            // 
            tabPageTumOyunlar.BackColor = SystemColors.ActiveCaptionText;
            tabPageTumOyunlar.Controls.Add(dataGridViewTumOyunlar);
            tabPageTumOyunlar.Controls.Add(pictureBox2);
            tabPageTumOyunlar.Controls.Add(pictureBox3);
            tabPageTumOyunlar.Location = new Point(4, 32);
            tabPageTumOyunlar.Name = "tabPageTumOyunlar";
            tabPageTumOyunlar.Padding = new Padding(3);
            tabPageTumOyunlar.Size = new Size(794, 214);
            tabPageTumOyunlar.TabIndex = 0;
            tabPageTumOyunlar.Text = "tüm oyunlar";
            tabPageTumOyunlar.Click += tabPageTumOyunlar_Enter;
            // 
            // dataGridViewTumOyunlar
            // 
            dataGridViewTumOyunlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTumOyunlar.ContextMenuStrip = contextMenuStrip1;
            dataGridViewTumOyunlar.Location = new Point(8, 28);
            dataGridViewTumOyunlar.Name = "dataGridViewTumOyunlar";
            dataGridViewTumOyunlar.RowHeadersWidth = 51;
            dataGridViewTumOyunlar.Size = new Size(451, 154);
            dataGridViewTumOyunlar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.ContextMenuStrip = contextMenuStrip1;
            pictureBox2.Image = Properties.Resources.indir__1_;
            pictureBox2.Location = new Point(636, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 172);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            toolTip3.SetToolTip(pictureBox2, "hoa");
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { çıkışToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // çıkışToolStripMenuItem1
            // 
            çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            çıkışToolStripMenuItem1.Size = new Size(210, 24);
            çıkışToolStripMenuItem1.Text = "Çıkış";
            çıkışToolStripMenuItem1.Click += çıkışToolStripMenuItem1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.ContextMenuStrip = contextMenuStrip1;
            pictureBox3.Image = Properties.Resources.indir__2_;
            pictureBox3.Location = new Point(486, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(108, 168);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            toolTip2.SetToolTip(pictureBox3, "child or light");
            // 
            // tabPageKategoriler
            // 
            tabPageKategoriler.BackColor = SystemColors.ActiveCaptionText;
            tabPageKategoriler.Controls.Add(pictureBox7);
            tabPageKategoriler.Controls.Add(pictureBox6);
            tabPageKategoriler.Controls.Add(dataGridViewKategoriler);
            tabPageKategoriler.Controls.Add(pictureBox1);
            tabPageKategoriler.Location = new Point(4, 32);
            tabPageKategoriler.Name = "tabPageKategoriler";
            tabPageKategoriler.Padding = new Padding(3);
            tabPageKategoriler.Size = new Size(794, 214);
            tabPageKategoriler.TabIndex = 1;
            tabPageKategoriler.Text = "kategoriler";
            tabPageKategoriler.Click += tabPageKategoriler_Enter;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(641, 22);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(138, 168);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            toolTip5.SetToolTip(pictureBox7, "nıer automate");
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.indir__4_;
            pictureBox6.Location = new Point(510, 22);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 168);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            toolTip4.SetToolTip(pictureBox6, " little nightmares");
            // 
            // dataGridViewKategoriler
            // 
            dataGridViewKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKategoriler.ContextMenuStrip = contextMenuStrip1;
            dataGridViewKategoriler.Location = new Point(3, 22);
            dataGridViewKategoriler.Name = "dataGridViewKategoriler";
            dataGridViewKategoriler.RowHeadersWidth = 51;
            dataGridViewKategoriler.Size = new Size(329, 161);
            dataGridViewKategoriler.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Image = Properties.Resources.Dark_Souls_on_Switch_E_Shop;
            pictureBox1.Location = new Point(377, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "dark souls");
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { yARDIMToolStripMenuItem, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(805, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(168, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // yARDIMToolStripMenuItem
            // 
            yARDIMToolStripMenuItem.Image = Properties.Resources.question;
            yARDIMToolStripMenuItem.Name = "yARDIMToolStripMenuItem";
            yARDIMToolStripMenuItem.Size = new Size(89, 24);
            yARDIMToolStripMenuItem.Text = "yardım";
            yARDIMToolStripMenuItem.Click += yARDIMToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            çıkışToolStripMenuItem.Image = Properties.Resources._switch;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(71, 24);
            çıkışToolStripMenuItem.Text = "çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-8, 269);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(973, 228);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-8, 503);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(981, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(977, 591);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPageTumOyunlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTumOyunlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPageKategoriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKategoriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPageTumOyunlar;
        private TabPage tabPageKategoriler;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yARDIMToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private DataGridView dataGridViewTumOyunlar;
        private DataGridView dataGridViewKategoriler;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private ToolTip toolTip5;
        private ToolTip toolTip4;
        private ToolTip toolTip1;
        private ToolStripMenuItem çıkışToolStripMenuItem1;
    }
}
