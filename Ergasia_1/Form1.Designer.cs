namespace Ergasia_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleatAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isoskelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAngleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFIleToolStripMenuItem,
            this.cleatAllToolStripMenuItem,
            this.eraserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveFIleToolStripMenuItem
            // 
            this.saveFIleToolStripMenuItem.Name = "saveFIleToolStripMenuItem";
            this.saveFIleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveFIleToolStripMenuItem.Text = "Save";
            this.saveFIleToolStripMenuItem.Click += new System.EventHandler(this.saveFIleToolStripMenuItem_Click);
            // 
            // cleatAllToolStripMenuItem
            // 
            this.cleatAllToolStripMenuItem.Name = "cleatAllToolStripMenuItem";
            this.cleatAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cleatAllToolStripMenuItem.Text = "Clear all";
            this.cleatAllToolStripMenuItem.Click += new System.EventHandler(this.cleatAllToolStripMenuItem_Click);
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eraserToolStripMenuItem.Text = "Eraser";
            this.eraserToolStripMenuItem.Click += new System.EventHandler(this.eraserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrowToolStripMenuItem,
            this.starToolStripMenuItem,
            this.ringToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.crossToolStripMenuItem,
            this.isoskelesToolStripMenuItem,
            this.ovalToolStripMenuItem,
            this.diamondToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.rightAngleToolStripMenuItem});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // arrowToolStripMenuItem
            // 
            this.arrowToolStripMenuItem.Name = "arrowToolStripMenuItem";
            this.arrowToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.arrowToolStripMenuItem.Text = "Arrow  ";
            this.arrowToolStripMenuItem.Click += new System.EventHandler(this.arrowToolStripMenuItem_Click);
            // 
            // starToolStripMenuItem
            // 
            this.starToolStripMenuItem.Name = "starToolStripMenuItem";
            this.starToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.starToolStripMenuItem.Text = "Star";
            this.starToolStripMenuItem.Click += new System.EventHandler(this.starToolStripMenuItem_Click);
            // 
            // ringToolStripMenuItem
            // 
            this.ringToolStripMenuItem.Name = "ringToolStripMenuItem";
            this.ringToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.ringToolStripMenuItem.Text = "Ring";
            this.ringToolStripMenuItem.Click += new System.EventHandler(this.ringToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // crossToolStripMenuItem
            // 
            this.crossToolStripMenuItem.Name = "crossToolStripMenuItem";
            this.crossToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.crossToolStripMenuItem.Text = "Cross";
            this.crossToolStripMenuItem.Click += new System.EventHandler(this.crossToolStripMenuItem_Click);
            // 
            // isoskelesToolStripMenuItem
            // 
            this.isoskelesToolStripMenuItem.Name = "isoskelesToolStripMenuItem";
            this.isoskelesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.isoskelesToolStripMenuItem.Text = "Isoskeles";
            this.isoskelesToolStripMenuItem.Click += new System.EventHandler(this.isoskelesToolStripMenuItem_Click);
            // 
            // ovalToolStripMenuItem
            // 
            this.ovalToolStripMenuItem.Name = "ovalToolStripMenuItem";
            this.ovalToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.ovalToolStripMenuItem.Text = "Oval";
            this.ovalToolStripMenuItem.Click += new System.EventHandler(this.ovalToolStripMenuItem_Click);
            // 
            // diamondToolStripMenuItem
            // 
            this.diamondToolStripMenuItem.Name = "diamondToolStripMenuItem";
            this.diamondToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.diamondToolStripMenuItem.Text = "Diamond";
            this.diamondToolStripMenuItem.Click += new System.EventHandler(this.diamondToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // rightAngleToolStripMenuItem
            // 
            this.rightAngleToolStripMenuItem.Name = "rightAngleToolStripMenuItem";
            this.rightAngleToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.rightAngleToolStripMenuItem.Text = "Right Angle";
            this.rightAngleToolStripMenuItem.Click += new System.EventHandler(this.rightAngleToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penColorToolStripMenuItem,
            this.penSizeToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.colorsToolStripMenuItem.Text = "Pen";
            // 
            // penColorToolStripMenuItem
            // 
            this.penColorToolStripMenuItem.Name = "penColorToolStripMenuItem";
            this.penColorToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.penColorToolStripMenuItem.Text = "Pen Color";
            this.penColorToolStripMenuItem.Click += new System.EventHandler(this.penColorToolStripMenuItem_Click);
            // 
            // penSizeToolStripMenuItem
            // 
            this.penSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.bigToolStripMenuItem,
            this.hugeToolStripMenuItem});
            this.penSizeToolStripMenuItem.Name = "penSizeToolStripMenuItem";
            this.penSizeToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.penSizeToolStripMenuItem.Text = "Pen Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.bigToolStripMenuItem.Text = "Big";
            this.bigToolStripMenuItem.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
            // 
            // hugeToolStripMenuItem
            // 
            this.hugeToolStripMenuItem.Name = "hugeToolStripMenuItem";
            this.hugeToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.hugeToolStripMenuItem.Text = "Huge";
            this.hugeToolStripMenuItem.Click += new System.EventHandler(this.hugeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Write a text and then choose a location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "When you finish with the shape press enter to confirm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isoskelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem ovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightAngleToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem saveFIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleatAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem penSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label2;
    }
}

