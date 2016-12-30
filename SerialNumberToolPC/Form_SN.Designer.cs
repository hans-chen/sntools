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
            this.L_Version = new System.Windows.Forms.Label();
            this.tboxInfo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioCounts = new System.Windows.Forms.RadioButton();
            this.radioReceipt = new System.Windows.Forms.RadioButton();
            this.radioFullfill = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPaste = new System.Windows.Forms.RadioButton();
            this.radioTypein = new System.Windows.Forms.RadioButton();
            this.T_SNinput = new System.Windows.Forms.TextBox();
            this.L_SNFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T_SNdone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_SimInput
            // 
            this.B_SimInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SimInput.Location = new System.Drawing.Point(963, 511);
            this.B_SimInput.Name = "B_SimInput";
            this.B_SimInput.Size = new System.Drawing.Size(223, 52);
            this.B_SimInput.TabIndex = 4;
            this.B_SimInput.Text = "Input to Exact";
            this.B_SimInput.UseVisualStyleBackColor = true;
            this.B_SimInput.Click += new System.EventHandler(this.B_SimInput_Click);
            // 
            // L_Version
            // 
            this.L_Version.AutoSize = true;
            this.L_Version.Font = new System.Drawing.Font("Calibri", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.L_Version.Location = new System.Drawing.Point(985, 586);
            this.L_Version.Name = "L_Version";
            this.L_Version.Size = new System.Drawing.Size(0, 13);
            this.L_Version.TabIndex = 5;
            this.L_Version.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tboxInfo
            // 
            this.tboxInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInfo.Location = new System.Drawing.Point(12, 55);
            this.tboxInfo.Multiline = true;
            this.tboxInfo.Name = "tboxInfo";
            this.tboxInfo.Size = new System.Drawing.Size(170, 508);
            this.tboxInfo.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioCounts);
            this.groupBox3.Controls.Add(this.radioReceipt);
            this.groupBox3.Controls.Add(this.radioFullfill);
            this.groupBox3.Location = new System.Drawing.Point(963, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 180);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To...";
            // 
            // radioCounts
            // 
            this.radioCounts.AutoSize = true;
            this.radioCounts.Location = new System.Drawing.Point(18, 129);
            this.radioCounts.Name = "radioCounts";
            this.radioCounts.Size = new System.Drawing.Size(200, 17);
            this.radioCounts.TabIndex = 4;
            this.radioCounts.TabStop = true;
            this.radioCounts.Text = "050 Aanmaken: Serienummer - Exact";
            this.radioCounts.UseVisualStyleBackColor = true;
            // 
            // radioReceipt
            // 
            this.radioReceipt.AutoSize = true;
            this.radioReceipt.Location = new System.Drawing.Point(18, 81);
            this.radioReceipt.Name = "radioReceipt";
            this.radioReceipt.Size = new System.Drawing.Size(143, 17);
            this.radioReceipt.TabIndex = 2;
            this.radioReceipt.TabStop = true;
            this.radioReceipt.Text = "050 Ontvangsten - Exact";
            this.radioReceipt.UseVisualStyleBackColor = true;
            // 
            // radioFullfill
            // 
            this.radioFullfill.AutoSize = true;
            this.radioFullfill.Location = new System.Drawing.Point(18, 34);
            this.radioFullfill.Name = "radioFullfill";
            this.radioFullfill.Size = new System.Drawing.Size(135, 17);
            this.radioFullfill.TabIndex = 0;
            this.radioFullfill.Text = "050 Leveringen - Exact";
            this.radioFullfill.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPaste);
            this.groupBox2.Controls.Add(this.radioTypein);
            this.groupBox2.Location = new System.Drawing.Point(963, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 115);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By...";
            // 
            // radioPaste
            // 
            this.radioPaste.AutoSize = true;
            this.radioPaste.Location = new System.Drawing.Point(19, 81);
            this.radioPaste.Name = "radioPaste";
            this.radioPaste.Size = new System.Drawing.Size(52, 17);
            this.radioPaste.TabIndex = 2;
            this.radioPaste.Text = "Paste";
            this.radioPaste.UseVisualStyleBackColor = true;
            // 
            // radioTypein
            // 
            this.radioTypein.AutoSize = true;
            this.radioTypein.Checked = true;
            this.radioTypein.Location = new System.Drawing.Point(19, 34);
            this.radioTypein.Name = "radioTypein";
            this.radioTypein.Size = new System.Drawing.Size(60, 17);
            this.radioTypein.TabIndex = 0;
            this.radioTypein.TabStop = true;
            this.radioTypein.Text = "Type in";
            this.radioTypein.UseVisualStyleBackColor = true;
            // 
            // T_SNinput
            // 
            this.T_SNinput.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_SNinput.Location = new System.Drawing.Point(198, 55);
            this.T_SNinput.Multiline = true;
            this.T_SNinput.Name = "T_SNinput";
            this.T_SNinput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.T_SNinput.Size = new System.Drawing.Size(350, 508);
            this.T_SNinput.TabIndex = 16;
            this.T_SNinput.TextChanged += new System.EventHandler(this.T_SNinput_TextChanged);
            // 
            // L_SNFile
            // 
            this.L_SNFile.AutoSize = true;
            this.L_SNFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SNFile.Location = new System.Drawing.Point(12, 27);
            this.L_SNFile.Name = "L_SNFile";
            this.L_SNFile.Size = new System.Drawing.Size(36, 19);
            this.L_SNFile.TabIndex = 8;
            this.L_SNFile.Text = "Log:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "SN:";
            // 
            // T_SNdone
            // 
            this.T_SNdone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_SNdone.Location = new System.Drawing.Point(586, 55);
            this.T_SNdone.Multiline = true;
            this.T_SNdone.Name = "T_SNdone";
            this.T_SNdone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.T_SNdone.Size = new System.Drawing.Size(350, 508);
            this.T_SNdone.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "SN inputted:";
            // 
            // F_SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 608);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T_SNdone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_SNinput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tboxInfo);
            this.Controls.Add(this.L_SNFile);
            this.Controls.Add(this.L_Version);
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
        private System.Windows.Forms.Label L_Version;
        private System.Windows.Forms.TextBox tboxInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioFullfill;
        private System.Windows.Forms.RadioButton radioReceipt;
        private System.Windows.Forms.RadioButton radioCounts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPaste;
        private System.Windows.Forms.RadioButton radioTypein;
        private System.Windows.Forms.TextBox T_SNinput;
        private System.Windows.Forms.Label L_SNFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_SNdone;
        private System.Windows.Forms.Label label3;
    }
}

