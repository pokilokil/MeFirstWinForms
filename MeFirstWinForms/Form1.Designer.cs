namespace MeFirstWinForms
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
            this.LeftRubBtn = new System.Windows.Forms.TextBox();
            this.LeftKopBtn = new System.Windows.Forms.TextBox();
            this.RightRubBtn = new System.Windows.Forms.TextBox();
            this.RightKopBtn = new System.Windows.Forms.TextBox();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.UmnoshBtn = new System.Windows.Forms.Button();
            this.DelenieBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultKopBtn = new System.Windows.Forms.TextBox();
            this.ResultRubBtn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftRubBtn
            // 
            this.LeftRubBtn.Location = new System.Drawing.Point(35, 78);
            this.LeftRubBtn.Name = "LeftRubBtn";
            this.LeftRubBtn.Size = new System.Drawing.Size(100, 23);
            this.LeftRubBtn.TabIndex = 0;
            // 
            // LeftKopBtn
            // 
            this.LeftKopBtn.Location = new System.Drawing.Point(141, 78);
            this.LeftKopBtn.Name = "LeftKopBtn";
            this.LeftKopBtn.Size = new System.Drawing.Size(100, 23);
            this.LeftKopBtn.TabIndex = 1;
            // 
            // RightRubBtn
            // 
            this.RightRubBtn.Location = new System.Drawing.Point(419, 78);
            this.RightRubBtn.Name = "RightRubBtn";
            this.RightRubBtn.Size = new System.Drawing.Size(100, 23);
            this.RightRubBtn.TabIndex = 2;
            // 
            // RightKopBtn
            // 
            this.RightKopBtn.Location = new System.Drawing.Point(525, 78);
            this.RightKopBtn.Name = "RightKopBtn";
            this.RightKopBtn.Size = new System.Drawing.Size(100, 23);
            this.RightKopBtn.TabIndex = 3;
            this.RightKopBtn.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusBtn.Location = new System.Drawing.Point(266, 78);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(63, 59);
            this.PlusBtn.TabIndex = 4;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusBtn.Location = new System.Drawing.Point(335, 78);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(63, 59);
            this.MinusBtn.TabIndex = 5;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // UmnoshBtn
            // 
            this.UmnoshBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UmnoshBtn.Location = new System.Drawing.Point(335, 143);
            this.UmnoshBtn.Name = "UmnoshBtn";
            this.UmnoshBtn.Size = new System.Drawing.Size(63, 59);
            this.UmnoshBtn.TabIndex = 7;
            this.UmnoshBtn.Text = "*";
            this.UmnoshBtn.UseVisualStyleBackColor = true;
            this.UmnoshBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // DelenieBtn
            // 
            this.DelenieBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelenieBtn.Location = new System.Drawing.Point(266, 143);
            this.DelenieBtn.Name = "DelenieBtn";
            this.DelenieBtn.Size = new System.Drawing.Size(63, 59);
            this.DelenieBtn.TabIndex = 6;
            this.DelenieBtn.Text = "/";
            this.DelenieBtn.UseVisualStyleBackColor = true;
            this.DelenieBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Рублей";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Копеек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Рублей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Копеек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Копеек";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Рублей";
            // 
            // ResultKopBtn
            // 
            this.ResultKopBtn.Location = new System.Drawing.Point(325, 272);
            this.ResultKopBtn.Name = "ResultKopBtn";
            this.ResultKopBtn.Size = new System.Drawing.Size(100, 23);
            this.ResultKopBtn.TabIndex = 14;
            // 
            // ResultRubBtn
            // 
            this.ResultRubBtn.Location = new System.Drawing.Point(219, 272);
            this.ResultRubBtn.Name = "ResultRubBtn";
            this.ResultRubBtn.Size = new System.Drawing.Size(100, 23);
            this.ResultRubBtn.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Результат";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultKopBtn);
            this.Controls.Add(this.ResultRubBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UmnoshBtn);
            this.Controls.Add(this.DelenieBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.RightKopBtn);
            this.Controls.Add(this.RightRubBtn);
            this.Controls.Add(this.LeftKopBtn);
            this.Controls.Add(this.LeftRubBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LeftRubBtn;
        private TextBox LeftKopBtn;
        private TextBox RightRubBtn;
        private TextBox RightKopBtn;
        private Button PlusBtn;
        private Button MinusBtn;
        private Button UmnoshBtn;
        private Button DelenieBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label6;
        private TextBox ResultKopBtn;
        private TextBox ResultRubBtn;
        private Label label7;
    }
}