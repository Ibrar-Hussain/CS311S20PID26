namespace Project_UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cntnubtn = new System.Windows.Forms.Button();
            this.MinW = new System.Windows.Forms.PictureBox();
            this.MaxW = new System.Windows.Forms.PictureBox();
            this.CloseW = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Compression Tool";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(290, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome To Compression Tool";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cntnubtn
            // 
            this.cntnubtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntnubtn.BackColor = System.Drawing.Color.Olive;
            this.cntnubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cntnubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cntnubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntnubtn.ForeColor = System.Drawing.Color.SeaShell;
            this.cntnubtn.Location = new System.Drawing.Point(468, 299);
            this.cntnubtn.Name = "cntnubtn";
            this.cntnubtn.Size = new System.Drawing.Size(75, 23);
            this.cntnubtn.TabIndex = 6;
            this.cntnubtn.Text = "Continue>";
            this.cntnubtn.UseVisualStyleBackColor = false;
            this.cntnubtn.Click += new System.EventHandler(this.cntnubtn_Click);
            // 
            // MinW
            // 
            this.MinW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinW.Image = global::Project_UI.Properties.Resources.minimize_window_16__1_;
            this.MinW.Location = new System.Drawing.Point(547, 5);
            this.MinW.Name = "MinW";
            this.MinW.Size = new System.Drawing.Size(16, 16);
            this.MinW.TabIndex = 5;
            this.MinW.TabStop = false;
            this.MinW.Click += new System.EventHandler(this.MinW_Click);
            // 
            // MaxW
            // 
            this.MaxW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxW.Image = global::Project_UI.Properties.Resources.maximize_window_16;
            this.MaxW.Location = new System.Drawing.Point(563, 5);
            this.MaxW.Name = "MaxW";
            this.MaxW.Size = new System.Drawing.Size(16, 16);
            this.MaxW.TabIndex = 4;
            this.MaxW.TabStop = false;
            this.MaxW.Click += new System.EventHandler(this.MaxW_Click);
            // 
            // CloseW
            // 
            this.CloseW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseW.Image = global::Project_UI.Properties.Resources.close_window_16;
            this.CloseW.Location = new System.Drawing.Point(579, 5);
            this.CloseW.Name = "CloseW";
            this.CloseW.Size = new System.Drawing.Size(16, 16);
            this.CloseW.TabIndex = 3;
            this.CloseW.TabStop = false;
            this.CloseW.Click += new System.EventHandler(this.CloseW_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Project_UI.Properties.Resources.archivio_png_8;
            this.pictureBox1.Location = new System.Drawing.Point(5, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(599, 376);
            this.Controls.Add(this.cntnubtn);
            this.Controls.Add(this.MinW);
            this.Controls.Add(this.MaxW);
            this.Controls.Add(this.CloseW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox CloseW;
        private System.Windows.Forms.PictureBox MaxW;
        private System.Windows.Forms.PictureBox MinW;
        private System.Windows.Forms.Button cntnubtn;
    }
}

