namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_Operator = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.textBox_Results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 31);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox_Operator
            // 
            this.comboBox_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Operator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_Operator.FormattingEnabled = true;
            this.comboBox_Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox_Operator.Location = new System.Drawing.Point(74, 89);
            this.comboBox_Operator.Name = "comboBox_Operator";
            this.comboBox_Operator.Size = new System.Drawing.Size(53, 21);
            this.comboBox_Operator.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 116);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 32);
            this.textBox2.TabIndex = 3;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(61, 227);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // textBox_Results
            // 
            this.textBox_Results.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Results.ForeColor = System.Drawing.Color.Green;
            this.textBox_Results.Location = new System.Drawing.Point(12, 168);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.Size = new System.Drawing.Size(179, 53);
            this.textBox_Results.TabIndex = 5;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 260);
            this.Controls.Add(this.textBox_Results);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox_Operator);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_Operator;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox textBox_Results;
    }
}

