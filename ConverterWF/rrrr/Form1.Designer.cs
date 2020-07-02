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
            this.lbl_currInvitation = new System.Windows.Forms.Label();
            this.tbx_currVal = new System.Windows.Forms.TextBox();
            this.btn_AddCurrency = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_screamer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tbConvert
            // 
            this.tbConvert.Location = new System.Drawing.Point(497, 200);
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
            // lbl_currInvitation
            // 
            this.lbl_currInvitation.AutoSize = true;
            this.lbl_currInvitation.Location = new System.Drawing.Point(16, 98);
            this.lbl_currInvitation.Name = "lbl_currInvitation";
            this.lbl_currInvitation.Size = new System.Drawing.Size(99, 26);
            this.lbl_currInvitation.TabIndex = 28;
            this.lbl_currInvitation.Text = "  Enter amount of \r\nconverted currency";
            // 
            // tbx_currVal
            // 
            this.tbx_currVal.Location = new System.Drawing.Point(10, 127);
            this.tbx_currVal.Name = "tbx_currVal";
            this.tbx_currVal.Size = new System.Drawing.Size(121, 20);
            this.tbx_currVal.TabIndex = 29;
            this.tbx_currVal.Text = "1";
            this.tbx_currVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // btn_AddCurrency
            // 
            this.btn_AddCurrency.Location = new System.Drawing.Point(137, 200);
            this.btn_AddCurrency.Name = "btn_AddCurrency";
            this.btn_AddCurrency.Size = new System.Drawing.Size(121, 21);
            this.btn_AddCurrency.TabIndex = 34;
            this.btn_AddCurrency.Text = "ADD CURRENCY";
            this.btn_AddCurrency.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.CausesValidation = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(137, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(481, 164);
            this.dgv.TabIndex = 35;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // btn_screamer
            // 
            this.btn_screamer.Location = new System.Drawing.Point(333, 198);
            this.btn_screamer.Name = "btn_screamer";
            this.btn_screamer.Size = new System.Drawing.Size(100, 23);
            this.btn_screamer.TabIndex = 34;
            this.btn_screamer.Text = "Screamer";
            this.btn_screamer.UseVisualStyleBackColor = true;
            this.btn_screamer.Click += new System.EventHandler(this.btn_screamer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 233);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_AddCurrency);
            this.Controls.Add(this.btn_screamer);
            this.Controls.Add(this.tbx_currVal);
            this.Controls.Add(this.lbl_currInvitation);
            this.Controls.Add(this.actInvitation);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.tbConvert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbConvert;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label actInvitation;
        private System.Windows.Forms.Label lbl_currInvitation;
        private System.Windows.Forms.TextBox tbx_currVal;
        private System.Windows.Forms.Button btn_AddCurrency;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_screamer;
  }
}

