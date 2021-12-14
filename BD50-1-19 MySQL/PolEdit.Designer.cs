namespace BD50_1_19_MySQL
{
    partial class PolEdit
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
            this.tshirtsPrise = new System.Windows.Forms.NumericUpDown();
            this.sizesID_Size = new System.Windows.Forms.ComboBox();
            this.colorsColor = new System.Windows.Forms.ComboBox();
            this.staffsNaim = new System.Windows.Forms.ComboBox();
            this.PolNaim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tshirtsPrise)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(472, 227);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(175, 36);
            this.deleteButton.TabIndex = 18;
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
            this.updateButton.Location = new System.Drawing.Point(261, 227);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = true;
            this.updateButton.Size = new System.Drawing.Size(187, 36);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Изменить запись";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_2);
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = true;
            this.insertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertButton.Depth = 0;
            this.insertButton.Icon = null;
            this.insertButton.Location = new System.Drawing.Point(45, 227);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertButton.Name = "insertButton";
            this.insertButton.Primary = true;
            this.insertButton.Size = new System.Drawing.Size(186, 36);
            this.insertButton.TabIndex = 20;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click_2);
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
            this.tshirtsPrise.Location = new System.Drawing.Point(1032, 463);
            this.tshirtsPrise.Margin = new System.Windows.Forms.Padding(4);
            this.tshirtsPrise.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tshirtsPrise.Name = "tshirtsPrise";
            this.tshirtsPrise.Size = new System.Drawing.Size(432, 36);
            this.tshirtsPrise.TabIndex = 17;
            // 
            // sizesID_Size
            // 
            this.sizesID_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizesID_Size.FormattingEnabled = true;
            this.sizesID_Size.Location = new System.Drawing.Point(1032, 387);
            this.sizesID_Size.Margin = new System.Windows.Forms.Padding(4);
            this.sizesID_Size.Name = "sizesID_Size";
            this.sizesID_Size.Size = new System.Drawing.Size(431, 37);
            this.sizesID_Size.TabIndex = 14;
            // 
            // colorsColor
            // 
            this.colorsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorsColor.FormattingEnabled = true;
            this.colorsColor.Location = new System.Drawing.Point(1032, 305);
            this.colorsColor.Margin = new System.Windows.Forms.Padding(4);
            this.colorsColor.Name = "colorsColor";
            this.colorsColor.Size = new System.Drawing.Size(431, 37);
            this.colorsColor.TabIndex = 15;
            // 
            // staffsNaim
            // 
            this.staffsNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staffsNaim.FormattingEnabled = true;
            this.staffsNaim.Location = new System.Drawing.Point(1032, 230);
            this.staffsNaim.Margin = new System.Windows.Forms.Padding(4);
            this.staffsNaim.Name = "staffsNaim";
            this.staffsNaim.Size = new System.Drawing.Size(431, 37);
            this.staffsNaim.TabIndex = 16;
            // 
            // PolNaim
            // 
            this.PolNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolNaim.Location = new System.Drawing.Point(127, 146);
            this.PolNaim.Margin = new System.Windows.Forms.Padding(4);
            this.PolNaim.Name = "PolNaim";
            this.PolNaim.Size = new System.Drawing.Size(431, 36);
            this.PolNaim.TabIndex = 13;
            this.PolNaim.TextChanged += new System.EventHandler(this.PolNaim_TextChanged);
            // 
            // PolEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 660);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.tshirtsPrise);
            this.Controls.Add(this.sizesID_Size);
            this.Controls.Add(this.colorsColor);
            this.Controls.Add(this.staffsNaim);
            this.Controls.Add(this.PolNaim);
            this.Name = "PolEdit";
            this.Text = "Изменение пола";
            this.Load += new System.EventHandler(this.PolEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tshirtsPrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton updateButton;
        private MaterialSkin.Controls.MaterialRaisedButton insertButton;
        private System.Windows.Forms.NumericUpDown tshirtsPrise;
        private System.Windows.Forms.ComboBox sizesID_Size;
        private System.Windows.Forms.ComboBox colorsColor;
        private System.Windows.Forms.ComboBox staffsNaim;
        private System.Windows.Forms.TextBox PolNaim;
    }
}