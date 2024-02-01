namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblAnswer = new Label();
            txtFnum = new TextBox();
            txtSnum = new TextBox();
            btnSum = new Button();
            label5 = new Label();
            label6 = new Label();
            btnDiff = new Button();
            btnQuo = new Button();
            btnProd = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE CALCULATOR";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(413, 149);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 1;
            label2.Text = "First Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(387, 223);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 2;
            label3.Text = "Second Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(458, 286);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 3;
            label4.Text = "Answer";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswer.ForeColor = Color.White;
            lblAnswer.Location = new Point(584, 286);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(36, 28);
            lblAnswer.TabIndex = 4;
            lblAnswer.Text = "---";
            // 
            // txtFnum
            // 
            txtFnum.Location = new Point(584, 146);
            txtFnum.Name = "txtFnum";
            txtFnum.Size = new Size(183, 31);
            txtFnum.TabIndex = 5;
            // 
            // txtSnum
            // 
            txtSnum.Location = new Point(584, 220);
            txtSnum.Name = "txtSnum";
            txtSnum.Size = new Size(183, 31);
            txtSnum.TabIndex = 6;
            // 
            // btnSum
            // 
            btnSum.BackColor = Color.Tan;
            btnSum.FlatStyle = FlatStyle.Flat;
            btnSum.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSum.ForeColor = Color.White;
            btnSum.Location = new Point(27, 140);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(131, 45);
            btnSum.TabIndex = 7;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += btnSum_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 83);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 12;
            label5.Text = "Operators:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(432, 83);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 13;
            label6.Text = "Operations:";
            // 
            // btnDiff
            // 
            btnDiff.BackColor = Color.Tan;
            btnDiff.FlatStyle = FlatStyle.Flat;
            btnDiff.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiff.ForeColor = Color.White;
            btnDiff.Location = new Point(190, 140);
            btnDiff.Name = "btnDiff";
            btnDiff.Size = new Size(131, 45);
            btnDiff.TabIndex = 14;
            btnDiff.Text = "-";
            btnDiff.UseVisualStyleBackColor = false;
            btnDiff.Click += btnDiff_Click;
            // 
            // btnQuo
            // 
            btnQuo.BackColor = Color.DarkKhaki;
            btnQuo.FlatStyle = FlatStyle.Flat;
            btnQuo.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuo.ForeColor = Color.White;
            btnQuo.Location = new Point(190, 223);
            btnQuo.Name = "btnQuo";
            btnQuo.Size = new Size(131, 45);
            btnQuo.TabIndex = 15;
            btnQuo.Text = "/";
            btnQuo.UseVisualStyleBackColor = false;
            btnQuo.Click += btnQuo_Click;
            // 
            // btnProd
            // 
            btnProd.BackColor = Color.DarkKhaki;
            btnProd.FlatStyle = FlatStyle.Flat;
            btnProd.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProd.ForeColor = Color.White;
            btnProd.Location = new Point(27, 220);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(131, 45);
            btnProd.TabIndex = 16;
            btnProd.Text = "x";
            btnProd.UseVisualStyleBackColor = false;
            btnProd.Click += btnProd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkKhaki;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(512, 353);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 45);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnProd);
            Controls.Add(btnQuo);
            Controls.Add(btnDiff);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSum);
            Controls.Add(txtSnum);
            Controls.Add(txtFnum);
            Controls.Add(lblAnswer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAnswer;
        private TextBox txtFnum;
        private TextBox txtSnum;
        private Button btnSum;
        private Label label5;
        private Label label6;
        private Button btnDiff;
        private Button btnQuo;
        private Button btnProd;
        private Button btnClear;
    }
}
