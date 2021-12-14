
namespace BD50_1_19_MySQL
{
    partial class Menu
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
            this.DoljnostButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PolButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SotrudnikButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SpecButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoljnostButton1
            // 
            this.DoljnostButton1.AutoSize = true;
            this.DoljnostButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DoljnostButton1.Depth = 0;
            this.DoljnostButton1.Icon = null;
            this.DoljnostButton1.Location = new System.Drawing.Point(180, 160);
            this.DoljnostButton1.Margin = new System.Windows.Forms.Padding(4);
            this.DoljnostButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoljnostButton1.Name = "DoljnostButton1";
            this.DoljnostButton1.Primary = true;
            this.DoljnostButton1.Size = new System.Drawing.Size(133, 36);
            this.DoljnostButton1.TabIndex = 0;
            this.DoljnostButton1.Text = "Должности";
            this.DoljnostButton1.UseVisualStyleBackColor = true;
            this.DoljnostButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // PolButton2
            // 
            this.PolButton2.AutoSize = true;
            this.PolButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PolButton2.Depth = 0;
            this.PolButton2.Icon = null;
            this.PolButton2.Location = new System.Drawing.Point(180, 282);
            this.PolButton2.Margin = new System.Windows.Forms.Padding(4);
            this.PolButton2.MinimumSize = new System.Drawing.Size(133, 36);
            this.PolButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.PolButton2.Name = "PolButton2";
            this.PolButton2.Primary = true;
            this.PolButton2.Size = new System.Drawing.Size(133, 36);
            this.PolButton2.TabIndex = 1;
            this.PolButton2.Text = "Пол";
            this.PolButton2.UseVisualStyleBackColor = true;
            this.PolButton2.Click += new System.EventHandler(this.PolButton2_Click);
            // 
            // SotrudnikButton3
            // 
            this.SotrudnikButton3.AutoSize = true;
            this.SotrudnikButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SotrudnikButton3.Depth = 0;
            this.SotrudnikButton3.Icon = null;
            this.SotrudnikButton3.Location = new System.Drawing.Point(13, 160);
            this.SotrudnikButton3.Margin = new System.Windows.Forms.Padding(4);
            this.SotrudnikButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.SotrudnikButton3.Name = "SotrudnikButton3";
            this.SotrudnikButton3.Primary = true;
            this.SotrudnikButton3.Size = new System.Drawing.Size(138, 36);
            this.SotrudnikButton3.TabIndex = 2;
            this.SotrudnikButton3.Text = "Сотрудники";
            this.SotrudnikButton3.UseVisualStyleBackColor = true;
            this.SotrudnikButton3.Click += new System.EventHandler(this.SotrudnikButton3_Click);
            // 
            // SpecButton4
            // 
            this.SpecButton4.AutoSize = true;
            this.SpecButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpecButton4.Depth = 0;
            this.SpecButton4.Icon = null;
            this.SpecButton4.Location = new System.Drawing.Point(13, 282);
            this.SpecButton4.Margin = new System.Windows.Forms.Padding(4);
            this.SpecButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.SpecButton4.Name = "SpecButton4";
            this.SpecButton4.Primary = true;
            this.SpecButton4.Size = new System.Drawing.Size(123, 36);
            this.SpecButton4.TabIndex = 3;
            this.SpecButton4.Text = "Спектакли";
            this.SpecButton4.UseVisualStyleBackColor = true;
            this.SpecButton4.Click += new System.EventHandler(this.SpecButton4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BD50_1_19_MySQL.Properties.Resources.caption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(425, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 468);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(993, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpecButton4);
            this.Controls.Add(this.SotrudnikButton3);
            this.Controls.Add(this.PolButton2);
            this.Controls.Add(this.DoljnostButton1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "ИС театра Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton DoljnostButton1;
        private MaterialSkin.Controls.MaterialRaisedButton PolButton2;
        private MaterialSkin.Controls.MaterialRaisedButton SotrudnikButton3;
        private MaterialSkin.Controls.MaterialRaisedButton SpecButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}