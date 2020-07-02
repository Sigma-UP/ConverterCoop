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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tbx_currVal = new System.Windows.Forms.TextBox();
            this.btn_AddCurrency = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_screamer = new System.Windows.Forms.Button();
            this.lbl_currInvitation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(10, 12);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 190);
            this.cbFrom.TabIndex = 1;
            this.cbFrom.Text = "Currency to convert";
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // tbx_currVal
            // 
            this.tbx_currVal.Location = new System.Drawing.Point(137, 201);
            this.tbx_currVal.Name = "tbx_currVal";
            this.tbx_currVal.Size = new System.Drawing.Size(121, 20);
            this.tbx_currVal.TabIndex = 29;
            this.tbx_currVal.Text = "1";
            this.tbx_currVal.TextChanged += new System.EventHandler(this.tbx_currVal_TextChanged);
            this.tbx_currVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // btn_AddCurrency
            // 
            this.btn_AddCurrency.Location = new System.Drawing.Point(497, 201);
            this.btn_AddCurrency.Name = "btn_AddCurrency";
            this.btn_AddCurrency.Size = new System.Drawing.Size(121, 20);
            this.btn_AddCurrency.TabIndex = 34;
            this.btn_AddCurrency.Text = "ADD CURRENCY";
            this.btn_AddCurrency.UseVisualStyleBackColor = true;
            this.btn_AddCurrency.Click += new System.EventHandler(this.btn_AddCurrency_Click);
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
            this.dgv.Size = new System.Drawing.Size(481, 180);
            this.dgv.TabIndex = 35;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // btn_screamer
            // 
            this.btn_screamer.Location = new System.Drawing.Point(391, 201);
            this.btn_screamer.Name = "btn_screamer";
            this.btn_screamer.Size = new System.Drawing.Size(100, 20);
            this.btn_screamer.TabIndex = 34;
            this.btn_screamer.Text = "Screamer";
            this.btn_screamer.UseVisualStyleBackColor = true;
            this.btn_screamer.Click += new System.EventHandler(this.btn_screamer_Click);
            // 
            // lbl_currInvitation
            // 
            this.lbl_currInvitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_currInvitation.Location = new System.Drawing.Point(10, 200);
            this.lbl_currInvitation.Name = "lbl_currInvitation";
            this.lbl_currInvitation.Size = new System.Drawing.Size(121, 20);
            this.lbl_currInvitation.TabIndex = 28;
            this.lbl_currInvitation.Text = "Enter amount:";
            this.lbl_currInvitation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.cbFrom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.TextBox tbx_currVal;
        private System.Windows.Forms.Button btn_AddCurrency;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_screamer;
        private System.Windows.Forms.Label lbl_currInvitation;
    }
}

