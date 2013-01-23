namespace SerialNumberInput
{
    partial class F_SN
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.B_SimInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.E_SNFile = new System.Windows.Forms.TextBox();
            this.tboxInfo = new System.Windows.Forms.TextBox();
            this.B_GetFromPT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioCounts = new System.Windows.Forms.RadioButton();
            this.radioReceipt = new System.Windows.Forms.RadioButton();
            this.radioFullfill = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPaste = new System.Windows.Forms.RadioButton();
            this.radioTypein = new System.Windows.Forms.RadioButton();
            this.T_SNinput = new System.Windows.Forms.TextBox();
            this.L_SNFile = new System.Windows.Forms.Label();
            this.groupInterval = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_SimInput
            // 
            this.B_SimInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SimInput.Location = new System.Drawing.Point(12, 350);
            this.B_SimInput.Name = "B_SimInput";
            this.B_SimInput.Size = new System.Drawing.Size(170, 48);
            this.B_SimInput.TabIndex = 4;
            this.B_SimInput.Text = "Input to Exact";
            this.B_SimInput.UseVisualStyleBackColor = true;
            this.B_SimInput.Click += new System.EventHandler(this.B_SimInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(632, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hans @ Newland Europe, 2013";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // E_SNFile
            // 
            this.E_SNFile.Location = new System.Drawing.Point(12, 51);
            this.E_SNFile.Name = "E_SNFile";
            this.E_SNFile.Size = new System.Drawing.Size(170, 21);
            this.E_SNFile.TabIndex = 9;
            this.E_SNFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E_SNFileKP);
            // 
            // tboxInfo
            // 
            this.tboxInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInfo.Location = new System.Drawing.Point(12, 106);
            this.tboxInfo.Multiline = true;
            this.tboxInfo.Name = "tboxInfo";
            this.tboxInfo.Size = new System.Drawing.Size(170, 207);
            this.tboxInfo.TabIndex = 10;
            // 
            // B_GetFromPT
            // 
            this.B_GetFromPT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_GetFromPT.Location = new System.Drawing.Point(12, 436);
            this.B_GetFromPT.Name = "B_GetFromPT";
            this.B_GetFromPT.Size = new System.Drawing.Size(170, 48);
            this.B_GetFromPT.TabIndex = 11;
            this.B_GetFromPT.Text = "Get SN From PT";
            this.B_GetFromPT.UseVisualStyleBackColor = true;
            this.B_GetFromPT.Click += new System.EventHandler(this.B_GetFromPT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioCounts);
            this.groupBox3.Controls.Add(this.radioReceipt);
            this.groupBox3.Controls.Add(this.radioFullfill);
            this.groupBox3.Location = new System.Drawing.Point(565, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 166);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To...";
            // 
            // radioCounts
            // 
            this.radioCounts.AutoSize = true;
            this.radioCounts.Location = new System.Drawing.Point(18, 119);
            this.radioCounts.Name = "radioCounts";
            this.radioCounts.Size = new System.Drawing.Size(149, 16);
            this.radioCounts.TabIndex = 4;
            this.radioCounts.TabStop = true;
            this.radioCounts.Text = "Create: Serial number";
            this.radioCounts.UseVisualStyleBackColor = true;
            // 
            // radioReceipt
            // 
            this.radioReceipt.AutoSize = true;
            this.radioReceipt.Location = new System.Drawing.Point(18, 75);
            this.radioReceipt.Name = "radioReceipt";
            this.radioReceipt.Size = new System.Drawing.Size(71, 16);
            this.radioReceipt.TabIndex = 2;
            this.radioReceipt.TabStop = true;
            this.radioReceipt.Text = "Receipts";
            this.radioReceipt.UseVisualStyleBackColor = true;
            // 
            // radioFullfill
            // 
            this.radioFullfill.AutoSize = true;
            this.radioFullfill.Location = new System.Drawing.Point(18, 31);
            this.radioFullfill.Name = "radioFullfill";
            this.radioFullfill.Size = new System.Drawing.Size(89, 16);
            this.radioFullfill.TabIndex = 0;
            this.radioFullfill.Text = "Fulfillment";
            this.radioFullfill.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPaste);
            this.groupBox2.Controls.Add(this.radioTypein);
            this.groupBox2.Location = new System.Drawing.Point(565, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 106);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By...";
            // 
            // radioPaste
            // 
            this.radioPaste.AutoSize = true;
            this.radioPaste.Location = new System.Drawing.Point(19, 75);
            this.radioPaste.Name = "radioPaste";
            this.radioPaste.Size = new System.Drawing.Size(53, 16);
            this.radioPaste.TabIndex = 2;
            this.radioPaste.Text = "Paste";
            this.radioPaste.UseVisualStyleBackColor = true;
            // 
            // radioTypein
            // 
            this.radioTypein.AutoSize = true;
            this.radioTypein.Checked = true;
            this.radioTypein.Location = new System.Drawing.Point(19, 31);
            this.radioTypein.Name = "radioTypein";
            this.radioTypein.Size = new System.Drawing.Size(65, 16);
            this.radioTypein.TabIndex = 0;
            this.radioTypein.TabStop = true;
            this.radioTypein.Text = "Type in";
            this.radioTypein.UseVisualStyleBackColor = true;
            // 
            // T_SNinput
            // 
            this.T_SNinput.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_SNinput.Location = new System.Drawing.Point(198, 51);
            this.T_SNinput.Multiline = true;
            this.T_SNinput.Name = "T_SNinput";
            this.T_SNinput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.T_SNinput.Size = new System.Drawing.Size(350, 469);
            this.T_SNinput.TabIndex = 16;
            this.T_SNinput.TextChanged += new System.EventHandler(this.T_SNinput_TextChanged);
            // 
            // L_SNFile
            // 
            this.L_SNFile.AutoSize = true;
            this.L_SNFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SNFile.Location = new System.Drawing.Point(12, 25);
            this.L_SNFile.Name = "L_SNFile";
            this.L_SNFile.Size = new System.Drawing.Size(131, 19);
            this.L_SNFile.TabIndex = 8;
            this.L_SNFile.Text = "Serial Number File:";
            // 
            // groupInterval
            // 
            this.groupInterval.Location = new System.Drawing.Point(565, 393);
            this.groupInterval.Name = "groupInterval";
            this.groupInterval.Size = new System.Drawing.Size(185, 127);
            this.groupInterval.TabIndex = 17;
            this.groupInterval.TabStop = false;
            this.groupInterval.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "or Input Serial Numbers Here:";
            // 
            // F_SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupInterval);
            this.Controls.Add(this.T_SNinput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tboxInfo);
            this.Controls.Add(this.E_SNFile);
            this.Controls.Add(this.B_GetFromPT);
            this.Controls.Add(this.L_SNFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_SimInput);
            this.Name = "F_SN";
            this.Text = "Serial Number Tool";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_SimInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox E_SNFile;
        private System.Windows.Forms.TextBox tboxInfo;
        private System.Windows.Forms.Button B_GetFromPT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioFullfill;
        private System.Windows.Forms.RadioButton radioReceipt;
        private System.Windows.Forms.RadioButton radioCounts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPaste;
        private System.Windows.Forms.RadioButton radioTypein;
        private System.Windows.Forms.TextBox T_SNinput;
        private System.Windows.Forms.Label L_SNFile;
        private System.Windows.Forms.GroupBox groupInterval;
        private System.Windows.Forms.Label label2;
    }
}

