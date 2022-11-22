namespace Menu
{
    partial class Drawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawing));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.volverAlMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Black_Btn = new System.Windows.Forms.ToolStripButton();
            this.Red_Btn = new System.Windows.Forms.ToolStripButton();
            this.Yellow_Btn = new System.Windows.Forms.ToolStripButton();
            this.Blue_Btn = new System.Windows.Forms.ToolStripButton();
            this.Green_Btn = new System.Windows.Forms.ToolStripButton();
            this.PenSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.PenSize_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Abrir,
            this.Tsm_Guardar,
            this.toolStripSeparator1,
            this.volverAlMenuToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // Tsm_Abrir
            // 
            this.Tsm_Abrir.Name = "Tsm_Abrir";
            this.Tsm_Abrir.Size = new System.Drawing.Size(180, 22);
            this.Tsm_Abrir.Text = "Abrir";
            this.Tsm_Abrir.Click += new System.EventHandler(this.Tsm_Abrir_Click);
            // 
            // Tsm_Guardar
            // 
            this.Tsm_Guardar.Name = "Tsm_Guardar";
            this.Tsm_Guardar.Size = new System.Drawing.Size(180, 22);
            this.Tsm_Guardar.Text = "Guardar como";
            this.Tsm_Guardar.Click += new System.EventHandler(this.Tsm_Guardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // volverAlMenuToolStripMenuItem
            // 
            this.volverAlMenuToolStripMenuItem.Name = "volverAlMenuToolStripMenuItem";
            this.volverAlMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.volverAlMenuToolStripMenuItem.Text = "Volver al menu";
            this.volverAlMenuToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Black_Btn,
            this.Red_Btn,
            this.Yellow_Btn,
            this.Blue_Btn,
            this.Green_Btn,
            this.PenSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Black_Btn
            // 
            this.Black_Btn.AutoSize = false;
            this.Black_Btn.BackColor = System.Drawing.Color.Black;
            this.Black_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Black_Btn.ForeColor = System.Drawing.Color.White;
            this.Black_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black_Btn.Name = "Black_Btn";
            this.Black_Btn.Size = new System.Drawing.Size(50, 22);
            this.Black_Btn.Text = "Black";
            this.Black_Btn.Click += new System.EventHandler(this.Black_Btn_Click);
            // 
            // Red_Btn
            // 
            this.Red_Btn.AutoSize = false;
            this.Red_Btn.BackColor = System.Drawing.Color.Red;
            this.Red_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Red_Btn.ForeColor = System.Drawing.Color.White;
            this.Red_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red_Btn.Name = "Red_Btn";
            this.Red_Btn.Size = new System.Drawing.Size(50, 22);
            this.Red_Btn.Text = "Red";
            this.Red_Btn.Click += new System.EventHandler(this.Red_Btn_Click);
            // 
            // Yellow_Btn
            // 
            this.Yellow_Btn.AutoSize = false;
            this.Yellow_Btn.BackColor = System.Drawing.Color.Yellow;
            this.Yellow_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Yellow_Btn.ForeColor = System.Drawing.Color.Black;
            this.Yellow_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Yellow_Btn.Name = "Yellow_Btn";
            this.Yellow_Btn.Size = new System.Drawing.Size(50, 22);
            this.Yellow_Btn.Text = "Yellow";
            this.Yellow_Btn.Click += new System.EventHandler(this.Yellow_Btn_Click);
            // 
            // Blue_Btn
            // 
            this.Blue_Btn.AutoSize = false;
            this.Blue_Btn.BackColor = System.Drawing.Color.Blue;
            this.Blue_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Blue_Btn.ForeColor = System.Drawing.Color.White;
            this.Blue_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Blue_Btn.Name = "Blue_Btn";
            this.Blue_Btn.Size = new System.Drawing.Size(50, 22);
            this.Blue_Btn.Text = "Blue";
            this.Blue_Btn.Click += new System.EventHandler(this.Blue_Btn_Click);
            // 
            // Green_Btn
            // 
            this.Green_Btn.AutoSize = false;
            this.Green_Btn.BackColor = System.Drawing.Color.Green;
            this.Green_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Green_Btn.ForeColor = System.Drawing.Color.White;
            this.Green_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Green_Btn.Name = "Green_Btn";
            this.Green_Btn.Size = new System.Drawing.Size(50, 22);
            this.Green_Btn.Text = "Green";
            this.Green_Btn.Click += new System.EventHandler(this.Green_Btn_Click);
            // 
            // PenSize
            // 
            this.PenSize.AutoSize = false;
            this.PenSize.BackColor = System.Drawing.Color.DarkOrange;
            this.PenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PenSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenSize_5,
            this.PenSize_10,
            this.PenSize_15});
            this.PenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(90, 22);
            this.PenSize.Text = "PenSize";
            this.PenSize.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // PenSize_5
            // 
            this.PenSize_5.Name = "PenSize_5";
            this.PenSize_5.Size = new System.Drawing.Size(86, 22);
            this.PenSize_5.Text = "5";
            this.PenSize_5.Click += new System.EventHandler(this.PenSize_5_Click);
            // 
            // PenSize_10
            // 
            this.PenSize_10.Name = "PenSize_10";
            this.PenSize_10.Size = new System.Drawing.Size(86, 22);
            this.PenSize_10.Text = "10";
            this.PenSize_10.Click += new System.EventHandler(this.PenSize_10_Click);
            // 
            // PenSize_15
            // 
            this.PenSize_15.Name = "PenSize_15";
            this.PenSize_15.Size = new System.Drawing.Size(86, 22);
            this.PenSize_15.Text = "15";
            this.PenSize_15.Click += new System.EventHandler(this.PenSize_15_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox2.Image = global::Menu.Properties.Resources.goma_de_borrar;
            this.pictureBox2.Location = new System.Drawing.Point(748, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 392);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Drawing";
            this.Text = "Drawing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Drawing_FormClosed);
            this.Load += new System.EventHandler(this.Drawing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Abrir;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Guardar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Black_Btn;
        private System.Windows.Forms.ToolStripButton Red_Btn;
        private System.Windows.Forms.ToolStripButton Yellow_Btn;
        private System.Windows.Forms.ToolStripButton Blue_Btn;
        private System.Windows.Forms.ToolStripButton Green_Btn;
        private System.Windows.Forms.ToolStripDropDownButton PenSize;
        private System.Windows.Forms.ToolStripMenuItem PenSize_5;
        private System.Windows.Forms.ToolStripMenuItem PenSize_10;
        private System.Windows.Forms.ToolStripMenuItem PenSize_15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}