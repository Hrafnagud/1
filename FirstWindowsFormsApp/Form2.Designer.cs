
namespace FirstWindowsFormsApp
{
    partial class EmreFormSecondHello
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
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textheight = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(62, 86);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(82, 20);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Weight(kg)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(62, 163);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(77, 20);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height(m)";
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(178, 79);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(313, 27);
            this.textWeight.TabIndex = 2;
            // 
            // textheight
            // 
            this.textheight.Location = new System.Drawing.Point(178, 163);
            this.textheight.Name = "textheight";
            this.textheight.Size = new System.Drawing.Size(313, 27);
            this.textheight.TabIndex = 3;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(428, 228);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(63, 24);
            this.radioMale.TabIndex = 4;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(178, 228);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(78, 24);
            this.radioFemale.TabIndex = 5;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(548, 101);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(222, 68);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate BMI";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // EmreFormSecondHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.textheight);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWeight);
            this.Name = "EmreFormSecondHello";
            this.Text = "EmreFormSecond";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textheight;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Button buttonCalculate;
    }
}