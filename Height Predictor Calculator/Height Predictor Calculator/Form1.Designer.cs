namespace Height_Predictor_Calculator
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
            this.numFHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMHeight = new System.Windows.Forms.NumericUpDown();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // numFHeight
            // 
            this.numFHeight.Location = new System.Drawing.Point(93, 106);
            this.numFHeight.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.numFHeight.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numFHeight.Name = "numFHeight";
            this.numFHeight.Size = new System.Drawing.Size(120, 22);
            this.numFHeight.TabIndex = 0;
            this.numFHeight.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Father Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mother Height";
            // 
            // numMHeight
            // 
            this.numMHeight.Location = new System.Drawing.Point(93, 210);
            this.numMHeight.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.numMHeight.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numMHeight.Name = "numMHeight";
            this.numMHeight.Size = new System.Drawing.Size(120, 22);
            this.numMHeight.TabIndex = 2;
            this.numMHeight.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(93, 299);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(92, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 43);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numFHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMHeight;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
    }
}

