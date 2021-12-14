namespace BD50_1_19_MySQL
{
    partial class StaffEdit
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
            this.StaffNaim = new System.Windows.Forms.TextBox();
            this.Deti = new System.Windows.Forms.ComboBox();
            this.adress = new System.Windows.Forms.ComboBox();
            this.StaffsNaim = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.The_salaru = new System.Windows.Forms.NumericUpDown();
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Patronomus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.The_salaru)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(551, 603);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(175, 36);
            this.deleteButton.TabIndex = 22;
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
            this.updateButton.Location = new System.Drawing.Point(340, 603);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = true;
            this.updateButton.Size = new System.Drawing.Size(187, 36);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Изменить запись";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = true;
            this.insertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertButton.Depth = 0;
            this.insertButton.Icon = null;
            this.insertButton.Location = new System.Drawing.Point(124, 603);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertButton.Name = "insertButton";
            this.insertButton.Primary = true;
            this.insertButton.Size = new System.Drawing.Size(186, 36);
            this.insertButton.TabIndex = 24;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // StaffNaim
            // 
            this.StaffNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffNaim.Location = new System.Drawing.Point(80, 81);
            this.StaffNaim.Margin = new System.Windows.Forms.Padding(4);
            this.StaffNaim.Name = "StaffNaim";
            this.StaffNaim.Size = new System.Drawing.Size(431, 36);
            this.StaffNaim.TabIndex = 21;
            // 
            // Deti
            // 
            this.Deti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deti.FormattingEnabled = true;
            this.Deti.Location = new System.Drawing.Point(80, 475);
            this.Deti.Margin = new System.Windows.Forms.Padding(4);
            this.Deti.Name = "Deti";
            this.Deti.Size = new System.Drawing.Size(431, 37);
            this.Deti.TabIndex = 25;
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress.FormattingEnabled = true;
            this.adress.Location = new System.Drawing.Point(81, 430);
            this.adress.Margin = new System.Windows.Forms.Padding(4);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(431, 37);
            this.adress.TabIndex = 26;
            // 
            // StaffsNaim
            // 
            this.StaffsNaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffsNaim.FormattingEnabled = true;
            this.StaffsNaim.Location = new System.Drawing.Point(79, 137);
            this.StaffsNaim.Margin = new System.Windows.Forms.Padding(4);
            this.StaffsNaim.Name = "StaffsNaim";
            this.StaffsNaim.Size = new System.Drawing.Size(431, 37);
            this.StaffsNaim.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(81, 386);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 36);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(81, 342);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(431, 36);
            this.textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(81, 298);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(431, 36);
            this.textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(81, 241);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(431, 36);
            this.textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(81, 197);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(431, 36);
            this.textBox5.TabIndex = 33;
            // 
            // The_salaru
            // 
            this.The_salaru.DecimalPlaces = 2;
            this.The_salaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.The_salaru.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.The_salaru.Location = new System.Drawing.Point(81, 520);
            this.The_salaru.Margin = new System.Windows.Forms.Padding(4);
            this.The_salaru.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.The_salaru.Name = "The_salaru";
            this.The_salaru.Size = new System.Drawing.Size(432, 36);
            this.The_salaru.TabIndex = 34;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(601, 186);
            this.Name.Margin = new System.Windows.Forms.Padding(4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(431, 36);
            this.Name.TabIndex = 35;
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(601, 241);
            this.Surname.Margin = new System.Windows.Forms.Padding(4);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(431, 36);
            this.Surname.TabIndex = 36;
            // 
            // Patronomus
            // 
            this.Patronomus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronomus.Location = new System.Drawing.Point(601, 298);
            this.Patronomus.Margin = new System.Windows.Forms.Padding(4);
            this.Patronomus.Name = "Patronomus";
            this.Patronomus.Size = new System.Drawing.Size(431, 36);
            this.Patronomus.TabIndex = 37;
            this.Patronomus.TextChanged += new System.EventHandler(this.Patronomus_TextChanged);
            // 
            // StaffEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 695);
            this.Controls.Add(this.Patronomus);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.The_salaru);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Deti);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.StaffsNaim);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.StaffNaim);
  
            this.Text = "Изменение сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.The_salaru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton updateButton;
        private MaterialSkin.Controls.MaterialRaisedButton insertButton;
        private System.Windows.Forms.TextBox StaffNaim;
        private System.Windows.Forms.ComboBox Deti;
        private System.Windows.Forms.ComboBox adress;
        private System.Windows.Forms.ComboBox StaffsNaim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown The_salaru;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Patronomus;
    }
}