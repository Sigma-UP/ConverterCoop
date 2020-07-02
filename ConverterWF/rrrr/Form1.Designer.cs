namespace Converter_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbConvert = new System.Windows.Forms.Button();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.actInvitation = new System.Windows.Forms.Label();
            this.lbl_convTo2 = new System.Windows.Forms.Label();
            this.lbl_convTo1 = new System.Windows.Forms.Label();
            this.lbl_convTo3 = new System.Windows.Forms.Label();
            this.lbl_convTo4 = new System.Windows.Forms.Label();
            this.lbl_convTo5 = new System.Windows.Forms.Label();
            this.lbl_convTo6 = new System.Windows.Forms.Label();
            this.tb_convTo1 = new System.Windows.Forms.TextBox();
            this.tb_convTo6 = new System.Windows.Forms.TextBox();
            this.tb_convTo5 = new System.Windows.Forms.TextBox();
            this.tb_convTo4 = new System.Windows.Forms.TextBox();
            this.tb_convTo3 = new System.Windows.Forms.TextBox();
            this.tb_convTo2 = new System.Windows.Forms.TextBox();
            this.lbl_result1 = new System.Windows.Forms.Label();
            this.tbx_result1 = new System.Windows.Forms.TextBox();
            this.tbx_result2 = new System.Windows.Forms.TextBox();
            this.lbl_result2 = new System.Windows.Forms.Label();
            this.tbx_result3 = new System.Windows.Forms.TextBox();
            this.lbl_result3 = new System.Windows.Forms.Label();
            this.tbx_result4 = new System.Windows.Forms.TextBox();
            this.lbl_result4 = new System.Windows.Forms.Label();
            this.tbx_result5 = new System.Windows.Forms.TextBox();
            this.lbl_result5 = new System.Windows.Forms.Label();
            this.tbx_result6 = new System.Windows.Forms.TextBox();
            this.lbl_result6 = new System.Windows.Forms.Label();
            this.lbl_currInvitation = new System.Windows.Forms.Label();
            this.tbx_currVal = new System.Windows.Forms.TextBox();
            this.lbl_rareDescription = new System.Windows.Forms.Label();
            this.lbl_convDescription = new System.Windows.Forms.Label();
            this.tbx_rareDFLT = new System.Windows.Forms.TextBox();
            this.tbx_result0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbConvert
            // 
            this.tbConvert.Location = new System.Drawing.Point(181, 200);
            this.tbConvert.Name = "tbConvert";
            this.tbConvert.Size = new System.Drawing.Size(121, 21);
            this.tbConvert.TabIndex = 0;
            this.tbConvert.Text = "CONVERT";
            this.tbConvert.UseVisualStyleBackColor = true;
            this.tbConvert.Click += new System.EventHandler(this.btn_convert_click);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(10, 65);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 1;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // actInvitation
            // 
            this.actInvitation.AutoSize = true;
            this.actInvitation.Location = new System.Drawing.Point(25, 36);
            this.actInvitation.Name = "actInvitation";
            this.actInvitation.Size = new System.Drawing.Size(90, 26);
            this.actInvitation.TabIndex = 2;
            this.actInvitation.Text = "Choose currency \r\n     to convert";
            // 
            // lbl_convTo2
            // 
            this.lbl_convTo2.AutoSize = true;
            this.lbl_convTo2.Location = new System.Drawing.Point(178, 62);
            this.lbl_convTo2.Name = "lbl_convTo2";
            this.lbl_convTo2.Size = new System.Drawing.Size(44, 13);
            this.lbl_convTo2.TabIndex = 3;
            this.lbl_convTo2.Text = "cnvTo2";
            // 
            // lbl_convTo1
            // 
            this.lbl_convTo1.AutoSize = true;
            this.lbl_convTo1.Location = new System.Drawing.Point(178, 36);
            this.lbl_convTo1.Name = "lbl_convTo1";
            this.lbl_convTo1.Size = new System.Drawing.Size(44, 13);
            this.lbl_convTo1.TabIndex = 4;
            this.lbl_convTo1.Text = "cnvTo1";
            // 
            // lbl_convTo3
            // 
            this.lbl_convTo3.AutoSize = true;
            this.lbl_convTo3.Location = new System.Drawing.Point(178, 88);
            this.lbl_convTo3.Name = "lbl_convTo3";
            this.lbl_convTo3.Size = new System.Drawing.Size(44, 13);
            this.lbl_convTo3.TabIndex = 5;
            this.lbl_convTo3.Text = "cnvTo3";
            // 
            // lbl_convTo4
            // 
            this.lbl_convTo4.AutoSize = true;
            this.lbl_convTo4.Location = new System.Drawing.Point(178, 114);
            this.lbl_convTo4.Name = "lbl_convTo4";
            this.lbl_convTo4.Size = new System.Drawing.Size(44, 13);
            this.lbl_convTo4.TabIndex = 6;
            this.lbl_convTo4.Text = "cnvTo4";
            // 
            // lbl_convTo5
            // 
            this.lbl_convTo5.AutoSize = true;
            this.lbl_convTo5.Location = new System.Drawing.Point(178, 140);
            this.lbl_convTo5.Name = "lbl_convTo5";
            this.lbl_convTo5.Size = new System.Drawing.Size(44, 13);
            this.lbl_convTo5.TabIndex = 7;
            this.lbl_convTo5.Text = "cnvTo5";
            // 
            // lbl_convTo6
            // 
            this.lbl_convTo6.AutoSize = true;
            this.lbl_convTo6.Location = new System.Drawing.Point(178, 166);
            this.lbl_convTo6.Name = "lbl_convTo6";
            this.lbl_convTo6.Size = new System.Drawing.Size(44, 13);
            this.lbl_convTo6.TabIndex = 8;
            this.lbl_convTo6.Text = "cnvTo6";
            // 
            // tb_convTo1
            // 
            this.tb_convTo1.Location = new System.Drawing.Point(228, 36);
            this.tb_convTo1.Name = "tb_convTo1";
            this.tb_convTo1.Size = new System.Drawing.Size(100, 20);
            this.tb_convTo1.TabIndex = 9;
            this.tb_convTo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // tb_convTo2
            // 
            this.tb_convTo2.Location = new System.Drawing.Point(228, 62);
            this.tb_convTo2.Name = "tb_convTo2";
            this.tb_convTo2.Size = new System.Drawing.Size(100, 20);
            this.tb_convTo2.TabIndex = 14;
            this.tb_convTo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // tb_convTo3
            // 
            this.tb_convTo3.Location = new System.Drawing.Point(228, 88);
            this.tb_convTo3.Name = "tb_convTo3";
            this.tb_convTo3.Size = new System.Drawing.Size(100, 20);
            this.tb_convTo3.TabIndex = 13;
            this.tb_convTo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // tb_convTo4
            // 
            this.tb_convTo4.Location = new System.Drawing.Point(228, 114);
            this.tb_convTo4.Name = "tb_convTo4";
            this.tb_convTo4.Size = new System.Drawing.Size(100, 20);
            this.tb_convTo4.TabIndex = 12;
            this.tb_convTo4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // tb_convTo5
            // 
            this.tb_convTo5.Location = new System.Drawing.Point(228, 140);
            this.tb_convTo5.Name = "tb_convTo5";
            this.tb_convTo5.Size = new System.Drawing.Size(100, 20);
            this.tb_convTo5.TabIndex = 11;
            this.tb_convTo5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // tb_convTo6
            // 
            this.tb_convTo6.Location = new System.Drawing.Point(228, 166);
            this.tb_convTo6.Name = "tb_convTo6";
            this.tb_convTo6.Size = new System.Drawing.Size(100, 20);
            this.tb_convTo6.TabIndex = 10;
            this.tb_convTo6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);




            // 
            // lbl_result1
            // 
            this.lbl_result1.AutoSize = true;
            this.lbl_result1.Location = new System.Drawing.Point(392, 36);
            this.lbl_result1.Name = "lbl_result1";
            this.lbl_result1.Size = new System.Drawing.Size(35, 13);
            this.lbl_result1.TabIndex = 15;
            this.lbl_result1.Text = "label1";
            // 
            // tbx_result1
            // 
            this.tbx_result1.Location = new System.Drawing.Point(433, 36);
            this.tbx_result1.Name = "tbx_result1";
            this.tbx_result1.ReadOnly = true;
            this.tbx_result1.Size = new System.Drawing.Size(100, 20);
            this.tbx_result1.TabIndex = 16;
            // 
            // tbx_result2
            // 
            this.tbx_result2.Location = new System.Drawing.Point(433, 62);
            this.tbx_result2.Name = "tbx_result2";
            this.tbx_result2.ReadOnly = true;
            this.tbx_result2.Size = new System.Drawing.Size(100, 20);
            this.tbx_result2.TabIndex = 18;
            // 
            // lbl_result2
            // 
            this.lbl_result2.AutoSize = true;
            this.lbl_result2.Location = new System.Drawing.Point(392, 62);
            this.lbl_result2.Name = "lbl_result2";
            this.lbl_result2.Size = new System.Drawing.Size(35, 13);
            this.lbl_result2.TabIndex = 17;
            this.lbl_result2.Text = "label2";
            // 
            // tbx_result3
            // 
            this.tbx_result3.Location = new System.Drawing.Point(433, 88);
            this.tbx_result3.Name = "tbx_result3";
            this.tbx_result3.ReadOnly = true;
            this.tbx_result3.Size = new System.Drawing.Size(100, 20);
            this.tbx_result3.TabIndex = 20;
            // 
            // lbl_result3
            // 
            this.lbl_result3.AutoSize = true;
            this.lbl_result3.Location = new System.Drawing.Point(392, 88);
            this.lbl_result3.Name = "lbl_result3";
            this.lbl_result3.Size = new System.Drawing.Size(35, 13);
            this.lbl_result3.TabIndex = 19;
            this.lbl_result3.Text = "label3";
            // 
            // tbx_result4
            // 
            this.tbx_result4.Location = new System.Drawing.Point(433, 114);
            this.tbx_result4.Name = "tbx_result4";
            this.tbx_result4.ReadOnly = true;
            this.tbx_result4.Size = new System.Drawing.Size(100, 20);
            this.tbx_result4.TabIndex = 22;
            // 
            // lbl_result4
            // 
            this.lbl_result4.AutoSize = true;
            this.lbl_result4.Location = new System.Drawing.Point(392, 114);
            this.lbl_result4.Name = "lbl_result4";
            this.lbl_result4.Size = new System.Drawing.Size(35, 13);
            this.lbl_result4.TabIndex = 21;
            this.lbl_result4.Text = "label4";
            // 
            // tbx_result5
            // 
            this.tbx_result5.Location = new System.Drawing.Point(433, 140);
            this.tbx_result5.Name = "tbx_result5";
            this.tbx_result5.ReadOnly = true;
            this.tbx_result5.Size = new System.Drawing.Size(100, 20);
            this.tbx_result5.TabIndex = 24;
            // 
            // lbl_result5
            // 
            this.lbl_result5.AutoSize = true;
            this.lbl_result5.Location = new System.Drawing.Point(392, 140);
            this.lbl_result5.Name = "lbl_result5";
            this.lbl_result5.Size = new System.Drawing.Size(35, 13);
            this.lbl_result5.TabIndex = 23;
            this.lbl_result5.Text = "label5";
            // 
            // tbx_result6
            // 
            this.tbx_result6.Location = new System.Drawing.Point(433, 166);
            this.tbx_result6.Name = "tbx_result6";
            this.tbx_result6.ReadOnly = true;
            this.tbx_result6.Size = new System.Drawing.Size(100, 20);
            this.tbx_result6.TabIndex = 26;
            // 
            // lbl_result6
            // 
            this.lbl_result6.AutoSize = true;
            this.lbl_result6.Location = new System.Drawing.Point(392, 166);
            this.lbl_result6.Name = "lbl_result6";
            this.lbl_result6.Size = new System.Drawing.Size(35, 13);
            this.lbl_result6.TabIndex = 25;
            this.lbl_result6.Text = "label6";
            // 
            // currInvitation
            // 
            this.lbl_currInvitation.AutoSize = true;
            this.lbl_currInvitation.Location = new System.Drawing.Point(12, 98);
            this.lbl_currInvitation.Name = "currInvitation";
            this.lbl_currInvitation.Size = new System.Drawing.Size(35, 13);
            this.lbl_currInvitation.TabIndex = 28;
            this.lbl_currInvitation.Text = "label1";
            // 
            // tbx_currVal
            // 
            this.tbx_currVal.Location = new System.Drawing.Point(15, 114);
            this.tbx_currVal.Name = "tbx_currVal";
            this.tbx_currVal.Size = new System.Drawing.Size(100, 20);
            this.tbx_currVal.TabIndex = 29;
            this.tbx_currVal.TextChanged += new System.EventHandler(this.tbx_currVal_TextChanged);
            this.tbx_currVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            this.tbx_currVal.Text = "1";
            // 
            // lbl_rareDescription
            // 
            this.lbl_rareDescription.AutoSize = true;
            this.lbl_rareDescription.Location = new System.Drawing.Point(178, 13);
            this.lbl_rareDescription.Name = "lbl_rareDescription";
            this.lbl_rareDescription.Size = new System.Drawing.Size(25, 13);
            this.lbl_rareDescription.TabIndex = 30;
            this.lbl_rareDescription.Text = "rare";
            // 
            // lbl_convDescription
            // 
            this.lbl_convDescription.AutoSize = true;
            this.lbl_convDescription.Location = new System.Drawing.Point(392, 13);
            this.lbl_convDescription.Name = "lbl_convDescription";
            this.lbl_convDescription.Size = new System.Drawing.Size(31, 13);
            this.lbl_convDescription.TabIndex = 31;
            this.lbl_convDescription.Text = "conv";
            // 
            // tbx_rareDFLT
            // 
            this.tbx_rareDFLT.Location = new System.Drawing.Point(228, 10);
            this.tbx_rareDFLT.Name = "tbx_rareDFLT";
            this.tbx_rareDFLT.ReadOnly = true;
            this.tbx_rareDFLT.Size = new System.Drawing.Size(100, 20);
            this.tbx_rareDFLT.TabIndex = 32;
            this.tbx_rareDFLT.Text = "1";
            // 
            // tbx_result0
            // 
            this.tbx_result0.Location = new System.Drawing.Point(433, 10);
            this.tbx_result0.Name = "tbx_result0";
            this.tbx_result0.ReadOnly = true;
            this.tbx_result0.Size = new System.Drawing.Size(100, 20);
            this.tbx_result0.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 233);
            this.Controls.Add(this.tbx_result0);
            this.Controls.Add(this.tbx_rareDFLT);
            this.Controls.Add(this.lbl_convDescription);
            this.Controls.Add(this.lbl_rareDescription);
            this.Controls.Add(this.tbx_currVal);
            this.Controls.Add(this.lbl_currInvitation);
            this.Controls.Add(this.tbx_result6);
            this.Controls.Add(this.lbl_result6);
            this.Controls.Add(this.tbx_result5);
            this.Controls.Add(this.lbl_result5);
            this.Controls.Add(this.tbx_result4);
            this.Controls.Add(this.lbl_result4);
            this.Controls.Add(this.tbx_result3);
            this.Controls.Add(this.lbl_result3);
            this.Controls.Add(this.tbx_result2);
            this.Controls.Add(this.lbl_result2);
            this.Controls.Add(this.tbx_result1);
            this.Controls.Add(this.lbl_result1);
            this.Controls.Add(this.tb_convTo2);
            this.Controls.Add(this.tb_convTo3);
            this.Controls.Add(this.tb_convTo4);
            this.Controls.Add(this.tb_convTo5);
            this.Controls.Add(this.tb_convTo6);
            this.Controls.Add(this.tb_convTo1);
            this.Controls.Add(this.lbl_convTo6);
            this.Controls.Add(this.lbl_convTo5);
            this.Controls.Add(this.lbl_convTo4);
            this.Controls.Add(this.lbl_convTo3);
            this.Controls.Add(this.lbl_convTo1);
            this.Controls.Add(this.lbl_convTo2);
            this.Controls.Add(this.actInvitation);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.tbConvert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbConvert;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label actInvitation;
        private System.Windows.Forms.Label lbl_convTo2;
        private System.Windows.Forms.Label lbl_convTo1;
        private System.Windows.Forms.Label lbl_convTo3;
        private System.Windows.Forms.Label lbl_convTo4;
        private System.Windows.Forms.Label lbl_convTo5;
        private System.Windows.Forms.Label lbl_convTo6;
        private System.Windows.Forms.TextBox tb_convTo1;
        private System.Windows.Forms.TextBox tb_convTo6;
        private System.Windows.Forms.TextBox tb_convTo5;
        private System.Windows.Forms.TextBox tb_convTo4;
        private System.Windows.Forms.TextBox tb_convTo3;
        private System.Windows.Forms.TextBox tb_convTo2;
        private System.Windows.Forms.Label lbl_result1;
        private System.Windows.Forms.TextBox tbx_result1;
        private System.Windows.Forms.TextBox tbx_result2;
        private System.Windows.Forms.Label lbl_result2;
        private System.Windows.Forms.TextBox tbx_result3;
        private System.Windows.Forms.Label lbl_result3;
        private System.Windows.Forms.TextBox tbx_result4;
        private System.Windows.Forms.Label lbl_result4;
        private System.Windows.Forms.TextBox tbx_result5;
        private System.Windows.Forms.Label lbl_result5;
        private System.Windows.Forms.TextBox tbx_result6;
        private System.Windows.Forms.Label lbl_result6;
        private System.Windows.Forms.Label lbl_currInvitation;
        private System.Windows.Forms.TextBox tbx_currVal;
        private System.Windows.Forms.Label lbl_rareDescription;
        private System.Windows.Forms.Label lbl_convDescription;
        private System.Windows.Forms.TextBox tbx_rareDFLT;
        private System.Windows.Forms.TextBox tbx_result0;
    }
}

