namespace BD50_1_19_MySQL
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PerformanceButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(763, 405);
            this.dataGridView1.TabIndex = 3;
            // 
            // PerformanceButton1
            // 
            this.PerformanceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformanceButton1.AutoSize = true;
            this.PerformanceButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PerformanceButton1.BackColor = System.Drawing.Color.Transparent;
            this.PerformanceButton1.Depth = 0;
            this.PerformanceButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformanceButton1.Icon = null;
            this.PerformanceButton1.Location = new System.Drawing.Point(912, 142);
            this.PerformanceButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.PerformanceButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.PerformanceButton1.Name = "PerformanceButton1";
            this.PerformanceButton1.Primary = false;
            this.PerformanceButton1.Size = new System.Drawing.Size(186, 36);
            this.PerformanceButton1.TabIndex = 5;
            this.PerformanceButton1.Text = "Добавить запись";
            this.PerformanceButton1.UseVisualStyleBackColor = false;
            this.PerformanceButton1.Click += new System.EventHandler(this.PerformanceButton1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 519);
            this.Controls.Add(this.PerformanceButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Спектакли";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton PerformanceButton1;
    }
}