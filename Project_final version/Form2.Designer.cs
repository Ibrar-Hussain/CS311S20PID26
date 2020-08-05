namespace Project_UI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MinW = new System.Windows.Forms.PictureBox();
            this.MaxW = new System.Windows.Forms.PictureBox();
            this.CloseW = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 7;
            this.label1.Text = "File Compression Tool";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Compress File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Decompress File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MinW
            // 
            this.MinW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinW.Image = global::Project_UI.Properties.Resources.minimize_window_16__1_;
            this.MinW.Location = new System.Drawing.Point(549, 4);
            this.MinW.Name = "MinW";
            this.MinW.Size = new System.Drawing.Size(16, 16);
            this.MinW.TabIndex = 10;
            this.MinW.TabStop = false;
            this.MinW.Click += new System.EventHandler(this.MinW_Click);
            // 
            // MaxW
            // 
            this.MaxW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxW.Image = global::Project_UI.Properties.Resources.maximize_window_16;
            this.MaxW.Location = new System.Drawing.Point(564, 4);
            this.MaxW.Name = "MaxW";
            this.MaxW.Size = new System.Drawing.Size(16, 16);
            this.MaxW.TabIndex = 9;
            this.MaxW.TabStop = false;
            this.MaxW.Click += new System.EventHandler(this.MaxW_Click);
            // 
            // CloseW
            // 
            this.CloseW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseW.Image = global::Project_UI.Properties.Resources.close_window_16;
            this.CloseW.Location = new System.Drawing.Point(579, 4);
            this.CloseW.Name = "CloseW";
            this.CloseW.Size = new System.Drawing.Size(16, 16);
            this.CloseW.TabIndex = 8;
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(393, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(599, 376);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MinW);
            this.Controls.Add(this.MaxW);
            this.Controls.Add(this.CloseW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.MinW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MinW;
        private System.Windows.Forms.PictureBox MaxW;
        private System.Windows.Forms.PictureBox CloseW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}