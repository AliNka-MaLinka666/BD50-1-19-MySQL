﻿namespace BD50_1_19_MySQL
{
    partial class DoljnostEdit
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
            this.deleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.insertButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.firmsNaim = new System.Windows.Forms.ComboBox();
            this.DoljNaim = new System.Windows.Forms.TextBox();
            this.colorsColor = new System.Windows.Forms.ComboBox();
            this.sizesID_Size = new System.Windows.Forms.ComboBox();
            this.tshirtsPrise = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tshirtsPrise)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(569, 228);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(175, 36);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Depth = 0;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(309, 228);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = true;
            this.updateButton.Size = new System.Drawing.Size(187, 36);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Изменить запись";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = true;
            this.insertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertButton.Depth = 0;
            this.insertButton.Icon = null;
            this.insertButton.Location = new System.Drawing.Point(92, 228);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertButton.Name = "insertButton";
            this.insertButton.Primary = true;
            this.insertButton.Size = new System.Drawing.Size(186, 36);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click_1);
            // 
            // firmsNaim
            // 
            this.firmsNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firmsNaim.FormattingEnabled = true;
            this.firmsNaim.Location = new System.Drawing.Point(189, 146);
            this.firmsNaim.Margin = new System.Windows.Forms.Padding(4);
            this.firmsNaim.Name = "firmsNaim";
            this.firmsNaim.Size = new System.Drawing.Size(431, 37);
            this.firmsNaim.TabIndex = 7;
            this.firmsNaim.SelectedIndexChanged += new System.EventHandler(this.firmsNaim_SelectedIndexChanged);
            // 
            // DoljNaim
            // 
            this.DoljNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoljNaim.Location = new System.Drawing.Point(188, 90);
            this.DoljNaim.Margin = new System.Windows.Forms.Padding(4);
            this.DoljNaim.Name = "DoljNaim";
            this.DoljNaim.Size = new System.Drawing.Size(431, 36);
            this.DoljNaim.TabIndex = 4;
            this.DoljNaim.TextChanged += new System.EventHandler(this.tshirtsNaim_TextChanged);
            // 
            // colorsColor
            // 
            this.colorsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorsColor.FormattingEnabled = true;
            this.colorsColor.Location = new System.Drawing.Point(1048, 284);
            this.colorsColor.Margin = new System.Windows.Forms.Padding(4);
            this.colorsColor.Name = "colorsColor";
            this.colorsColor.Size = new System.Drawing.Size(431, 37);
            this.colorsColor.TabIndex = 6;
            this.colorsColor.SelectedIndexChanged += new System.EventHandler(this.colorsColor_SelectedIndexChanged);
            // 
            // sizesID_Size
            // 
            this.sizesID_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizesID_Size.FormattingEnabled = true;
            this.sizesID_Size.Location = new System.Drawing.Point(1048, 366);
            this.sizesID_Size.Margin = new System.Windows.Forms.Padding(4);
            this.sizesID_Size.Name = "sizesID_Size";
            this.sizesID_Size.Size = new System.Drawing.Size(431, 37);
            this.sizesID_Size.TabIndex = 5;
            this.sizesID_Size.SelectedIndexChanged += new System.EventHandler(this.sizesID_Size_SelectedIndexChanged);
            // 
            // tshirtsPrise
            // 
            this.tshirtsPrise.DecimalPlaces = 2;
            this.tshirtsPrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tshirtsPrise.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tshirtsPrise.Location = new System.Drawing.Point(1048, 442);
            this.tshirtsPrise.Margin = new System.Windows.Forms.Padding(4);
            this.tshirtsPrise.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tshirtsPrise.Name = "tshirtsPrise";
            this.tshirtsPrise.Size = new System.Drawing.Size(432, 36);
            this.tshirtsPrise.TabIndex = 8;
            this.tshirtsPrise.ValueChanged += new System.EventHandler(this.tshirtsPrise_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1049, 224);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 36);
            this.textBox1.TabIndex = 12;
            // 
            // DoljnostEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 413);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.tshirtsPrise);
            this.Controls.Add(this.sizesID_Size);
            this.Controls.Add(this.colorsColor);
            this.Controls.Add(this.firmsNaim);
            this.Controls.Add(this.DoljNaim);
            this.Name = "DoljnostEdit";
            this.Text = "Изменение должности";
            ((System.ComponentModel.ISupportInitialize)(this.tshirtsPrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton updateButton;
        private MaterialSkin.Controls.MaterialRaisedButton insertButton;
        private System.Windows.Forms.ComboBox firmsNaim;
        private System.Windows.Forms.TextBox DoljNaim;
        private System.Windows.Forms.ComboBox colorsColor;
        private System.Windows.Forms.ComboBox sizesID_Size;
        private System.Windows.Forms.NumericUpDown tshirtsPrise;
        private System.Windows.Forms.TextBox textBox1;
    }
}