namespace WindowsFormsApp1
{
    partial class Calculatrice
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
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btLess = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btSigne = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCE
            // 
            this.btCE.Location = new System.Drawing.Point(7, 72);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(55, 43);
            this.btCE.TabIndex = 0;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(78, 72);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(55, 43);
            this.btC.TabIndex = 1;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(151, 72);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(55, 43);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "<--";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(224, 72);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(55, 43);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(224, 138);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(55, 43);
            this.btMul.TabIndex = 8;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(151, 138);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(55, 43);
            this.bt9.TabIndex = 7;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(78, 138);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(55, 43);
            this.bt8.TabIndex = 6;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(7, 138);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(55, 43);
            this.bt7.TabIndex = 5;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // btLess
            // 
            this.btLess.Location = new System.Drawing.Point(224, 202);
            this.btLess.Name = "btLess";
            this.btLess.Size = new System.Drawing.Size(55, 43);
            this.btLess.TabIndex = 12;
            this.btLess.Text = "-";
            this.btLess.UseVisualStyleBackColor = true;
            this.btLess.Click += new System.EventHandler(this.btLess_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(151, 202);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(55, 43);
            this.bt6.TabIndex = 11;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(78, 202);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(55, 43);
            this.bt5.TabIndex = 10;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(7, 202);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(55, 43);
            this.bt4.TabIndex = 9;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(224, 273);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(55, 43);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(151, 273);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(55, 43);
            this.bt3.TabIndex = 15;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(78, 273);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(55, 43);
            this.bt2.TabIndex = 14;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(7, 273);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(55, 43);
            this.bt1.TabIndex = 13;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btEqual
            // 
            this.btEqual.Location = new System.Drawing.Point(224, 334);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(55, 43);
            this.btEqual.TabIndex = 20;
            this.btEqual.Text = "=";
            this.btEqual.UseVisualStyleBackColor = true;
            this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(151, 335);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(55, 43);
            this.btDot.TabIndex = 19;
            this.btDot.Text = ",";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.btDot_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(78, 335);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(55, 43);
            this.bt0.TabIndex = 18;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btSigne
            // 
            this.btSigne.Location = new System.Drawing.Point(7, 335);
            this.btSigne.Name = "btSigne";
            this.btSigne.Size = new System.Drawing.Size(55, 43);
            this.btSigne.TabIndex = 17;
            this.btSigne.Text = "+-";
            this.btSigne.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(7, 6);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(272, 20);
            this.tb1.TabIndex = 21;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(7, 33);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(272, 20);
            this.tb2.TabIndex = 22;
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 394);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btSigne);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btLess);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btCE);
            this.Name = "Calculatrice";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btLess;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btSigne;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
    }
}