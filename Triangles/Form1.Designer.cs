namespace Triangles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIso = new System.Windows.Forms.RadioButton();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSide3 = new System.Windows.Forms.RadioButton();
            this.rbSide2 = new System.Windows.Forms.RadioButton();
            this.rbSide1 = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.txtBoxSide1 = new System.Windows.Forms.TextBox();
            this.txtBoxSide2 = new System.Windows.Forms.TextBox();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSide3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBoxExit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Controls.Add(this.rbEqual);
            this.groupBox1.Controls.Add(this.rbIso);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangle";
            // 
            // rbIso
            // 
            this.rbIso.AutoSize = true;
            this.rbIso.Location = new System.Drawing.Point(7, 43);
            this.rbIso.Name = "rbIso";
            this.rbIso.Size = new System.Drawing.Size(110, 17);
            this.rbIso.TabIndex = 1;
            this.rbIso.TabStop = true;
            this.rbIso.Text = "Isosolese Triangle";
            this.rbIso.UseVisualStyleBackColor = true;
            this.rbIso.CheckedChanged += new System.EventHandler(this.rbIso_CheckedChanged);
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Location = new System.Drawing.Point(7, 66);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(119, 17);
            this.rbEqual.TabIndex = 2;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Equalateral Triangle";
            this.rbEqual.UseVisualStyleBackColor = true;
            this.rbEqual.CheckedChanged += new System.EventHandler(this.rbEqual_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSide3);
            this.groupBox2.Controls.Add(this.rbSide2);
            this.groupBox2.Controls.Add(this.rbSide1);
            this.groupBox2.Location = new System.Drawing.Point(151, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Missing";
            // 
            // rbSide3
            // 
            this.rbSide3.AutoSize = true;
            this.rbSide3.Location = new System.Drawing.Point(7, 66);
            this.rbSide3.Name = "rbSide3";
            this.rbSide3.Size = new System.Drawing.Size(28, 17);
            this.rbSide3.TabIndex = 2;
            this.rbSide3.TabStop = true;
            this.rbSide3.Text = " ";
            this.rbSide3.UseVisualStyleBackColor = true;
            this.rbSide3.CheckedChanged += new System.EventHandler(this.rbSide3_CheckedChanged);
            // 
            // rbSide2
            // 
            this.rbSide2.AutoSize = true;
            this.rbSide2.Location = new System.Drawing.Point(7, 43);
            this.rbSide2.Name = "rbSide2";
            this.rbSide2.Size = new System.Drawing.Size(28, 17);
            this.rbSide2.TabIndex = 1;
            this.rbSide2.TabStop = true;
            this.rbSide2.Text = " ";
            this.rbSide2.UseVisualStyleBackColor = true;
            this.rbSide2.CheckedChanged += new System.EventHandler(this.rbSide2_CheckedChanged);
            // 
            // rbSide1
            // 
            this.rbSide1.AutoSize = true;
            this.rbSide1.Location = new System.Drawing.Point(7, 20);
            this.rbSide1.Name = "rbSide1";
            this.rbSide1.Size = new System.Drawing.Size(28, 17);
            this.rbSide1.TabIndex = 0;
            this.rbSide1.TabStop = true;
            this.rbSide1.Text = " ";
            this.rbSide1.UseVisualStyleBackColor = true;
            this.rbSide1.CheckedChanged += new System.EventHandler(this.rbSide1_CheckedChanged);
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(7, 20);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(91, 17);
            this.rbRight.TabIndex = 3;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "Right Triangle";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.rbRight_CheckedChanged);
            // 
            // txtBoxSide1
            // 
            this.txtBoxSide1.Location = new System.Drawing.Point(136, 121);
            this.txtBoxSide1.Name = "txtBoxSide1";
            this.txtBoxSide1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSide1.TabIndex = 4;
            // 
            // txtBoxSide2
            // 
            this.txtBoxSide2.Location = new System.Drawing.Point(136, 147);
            this.txtBoxSide2.Name = "txtBoxSide2";
            this.txtBoxSide2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSide2.TabIndex = 5;
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(18, 125);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(10, 13);
            this.lblSide1.TabIndex = 6;
            this.lblSide1.Text = " ";
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Location = new System.Drawing.Point(18, 145);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(10, 13);
            this.lblSide2.TabIndex = 7;
            this.lblSide2.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Length of missing :";
            // 
            // lblSide3
            // 
            this.lblSide3.AutoSize = true;
            this.lblSide3.Location = new System.Drawing.Point(115, 194);
            this.lblSide3.Name = "lblSide3";
            this.lblSide3.Size = new System.Drawing.Size(10, 13);
            this.lblSide3.TabIndex = 9;
            this.lblSide3.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Length of perimeter :";
            // 
            // lblPerim
            // 
            this.lblPerim.AutoSize = true;
            this.lblPerim.Location = new System.Drawing.Point(123, 217);
            this.lblPerim.Name = "lblPerim";
            this.lblPerim.Size = new System.Drawing.Size(10, 13);
            this.lblPerim.TabIndex = 11;
            this.lblPerim.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Area :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(54, 239);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(10, 13);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "To exit, spell out \'Exit\'\r\nwith the buttons\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "E";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "I";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(378, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "T";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(291, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 50);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBoxExit
            // 
            this.txtBoxExit.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBoxExit.Location = new System.Drawing.Point(296, 54);
            this.txtBoxExit.Name = "txtBoxExit";
            this.txtBoxExit.Size = new System.Drawing.Size(100, 23);
            this.txtBoxExit.TabIndex = 22;
            this.txtBoxExit.Text = " ";
            this.txtBoxExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 262);
            this.Controls.Add(this.txtBoxExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPerim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSide3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSide2);
            this.Controls.Add(this.lblSide1);
            this.Controls.Add(this.txtBoxSide2);
            this.Controls.Add(this.txtBoxSide1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbIso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSide3;
        private System.Windows.Forms.RadioButton rbSide2;
        private System.Windows.Forms.RadioButton rbSide1;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.TextBox txtBoxSide1;
        private System.Windows.Forms.TextBox txtBoxSide2;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSide3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label txtBoxExit;
    }
}

