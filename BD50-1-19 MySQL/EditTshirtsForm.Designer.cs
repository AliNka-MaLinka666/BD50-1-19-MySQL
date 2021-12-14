
namespace BD50_1_19_MySQL
{
    partial class EditTshirtsForm
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
            this.tshirtsNaim = new System.Windows.Forms.TextBox();
            this.firmsNaim = new System.Windows.Forms.ComboBox();
            this.colorsColor = new System.Windows.Forms.ComboBox();
            this.sizesID_Size = new System.Windows.Forms.ComboBox();
            this.tshirtsPrise = new System.Windows.Forms.NumericUpDown();
            this.insertButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.updateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.tshirtsPrise)).BeginInit();
            this.SuspendLayout();
            // 
            // tshirtsNaim
            // 
            this.tshirtsNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tshirtsNaim.Location = new System.Drawing.Point(27, 90);
            this.tshirtsNaim.Name = "tshirtsNaim";
            this.tshirtsNaim.Size = new System.Drawing.Size(324, 30);
            this.tshirtsNaim.TabIndex = 0;
            // 
            // firmsNaim
            // 
            this.firmsNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firmsNaim.FormattingEnabled = true;
            this.firmsNaim.Location = new System.Drawing.Point(27, 145);
            this.firmsNaim.Name = "firmsNaim";
            this.firmsNaim.Size = new System.Drawing.Size(324, 33);
            this.firmsNaim.TabIndex = 1;
            // 
            // colorsColor
            // 
            this.colorsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorsColor.FormattingEnabled = true;
            this.colorsColor.Location = new System.Drawing.Point(27, 206);
            this.colorsColor.Name = "colorsColor";
            this.colorsColor.Size = new System.Drawing.Size(324, 33);
            this.colorsColor.TabIndex = 1;
            // 
            // sizesID_Size
            // 
            this.sizesID_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizesID_Size.FormattingEnabled = true;
            this.sizesID_Size.Location = new System.Drawing.Point(27, 273);
            this.sizesID_Size.Name = "sizesID_Size";
            this.sizesID_Size.Size = new System.Drawing.Size(324, 33);
            this.sizesID_Size.TabIndex = 1;
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
            this.tshirtsPrise.Location = new System.Drawing.Point(27, 335);
            this.tshirtsPrise.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tshirtsPrise.Name = "tshirtsPrise";
            this.tshirtsPrise.Size = new System.Drawing.Size(324, 30);
            this.tshirtsPrise.TabIndex = 2;
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = true;
            this.insertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertButton.Depth = 0;
            this.insertButton.Icon = null;
            this.insertButton.Location = new System.Drawing.Point(111, 455);
            this.insertButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertButton.Name = "insertButton";
            this.insertButton.Primary = true;
            this.insertButton.Size = new System.Drawing.Size(152, 36);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Depth = 0;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(12, 413);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = true;
            this.updateButton.Size = new System.Drawing.Size(153, 36);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Изменить запись";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(228, 413);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(143, 36);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditTshirtsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 552);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.tshirtsPrise);
            this.Controls.Add(this.sizesID_Size);
            this.Controls.Add(this.colorsColor);
            this.Controls.Add(this.firmsNaim);
            this.Controls.Add(this.tshirtsNaim);
            this.Name = "EditTshirtsForm";
            this.Text = "EditTshirtsForm";
            ((System.ComponentModel.ISupportInitialize)(this.tshirtsPrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tshirtsNaim;
        private System.Windows.Forms.ComboBox firmsNaim;
        private System.Windows.Forms.ComboBox colorsColor;
        private System.Windows.Forms.ComboBox sizesID_Size;
        private System.Windows.Forms.NumericUpDown tshirtsPrise;
        private MaterialSkin.Controls.MaterialRaisedButton insertButton;
        private MaterialSkin.Controls.MaterialRaisedButton updateButton;
        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
    }
}