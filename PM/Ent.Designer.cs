namespace PM
{
    partial class Ent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.BtnEnt = new System.Windows.Forms.Button();
            this.lbReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите данные для входа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер телефона";
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(25, 147);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(240, 23);
            this.TbPhone.TabIndex = 4;
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(25, 224);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(240, 23);
            this.TbPass.TabIndex = 5;
            // 
            // BtnEnt
            // 
            this.BtnEnt.Location = new System.Drawing.Point(100, 289);
            this.BtnEnt.Name = "BtnEnt";
            this.BtnEnt.Size = new System.Drawing.Size(75, 23);
            this.BtnEnt.TabIndex = 6;
            this.BtnEnt.Text = "button1";
            this.BtnEnt.UseVisualStyleBackColor = true;
            this.BtnEnt.Click += new System.EventHandler(this.BtnEnt_Click);
            // 
            // lbReg
            // 
            this.lbReg.AutoSize = true;
            this.lbReg.Location = new System.Drawing.Point(82, 348);
            this.lbReg.Name = "lbReg";
            this.lbReg.Size = new System.Drawing.Size(119, 15);
            this.lbReg.TabIndex = 7;
            this.lbReg.Text = "Зарегистрироваться";
            this.lbReg.Click += new System.EventHandler(this.lbReg_Click);
            // 
            // Ent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 429);
            this.Controls.Add(this.lbReg);
            this.Controls.Add(this.BtnEnt);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.TbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Ent";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TbPhone;
        private TextBox TbPass;
        private Button BtnEnt;
        private Label lbReg;
    }
}