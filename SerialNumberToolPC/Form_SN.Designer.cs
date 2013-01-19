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
            this.B_Open = new System.Windows.Forms.Button();
            this.DG_SNList = new System.Windows.Forms.DataGridView();
            this.Col_SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Configuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_SimInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_NextFile = new System.Windows.Forms.Button();
            this.B_PrevFile = new System.Windows.Forms.Button();
            this.L_SNFile = new System.Windows.Forms.Label();
            this.E_SNFile = new System.Windows.Forms.TextBox();
            this.T_Info = new System.Windows.Forms.TextBox();
            this.B_GetFromPT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
<<<<<<< HEAD
=======
            this.textBox1 = new System.Windows.Forms.TextBox();
>>>>>>> add new edit box to accept pasted serial numbers
            ((System.ComponentModel.ISupportInitialize)(this.DG_SNList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Open
            // 
            this.B_Open.Location = new System.Drawing.Point(23, 20);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(167, 45);
            this.B_Open.TabIndex = 0;
            this.B_Open.Text = "Open SN file";
            this.B_Open.UseVisualStyleBackColor = true;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // DG_SNList
            // 
            this.DG_SNList.AllowUserToAddRows = false;
            this.DG_SNList.AllowUserToOrderColumns = true;
            this.DG_SNList.AllowUserToResizeRows = false;
            this.DG_SNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_SNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_SN,
            this.Col_Product,
            this.Col_Year,
            this.Col_Month,
            this.Col_Configuration});
<<<<<<< HEAD
            this.DG_SNList.Location = new System.Drawing.Point(198, 25);
=======
            this.DG_SNList.Location = new System.Drawing.Point(470, 56);
>>>>>>> add new edit box to accept pasted serial numbers
            this.DG_SNList.Name = "DG_SNList";
            this.DG_SNList.ReadOnly = true;
            this.DG_SNList.RowTemplate.Height = 23;
            this.DG_SNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
            this.DG_SNList.Size = new System.Drawing.Size(639, 508);
=======
            this.DG_SNList.Size = new System.Drawing.Size(349, 603);
>>>>>>> add new edit box to accept pasted serial numbers
            this.DG_SNList.TabIndex = 3;
            this.DG_SNList.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DG_SNList_UDRow);
            // 
            // Col_SN
            // 
            this.Col_SN.HeaderText = "SN";
            this.Col_SN.Name = "Col_SN";
            this.Col_SN.ReadOnly = true;
            this.Col_SN.Width = 150;
            // 
            // Col_Product
            // 
            this.Col_Product.HeaderText = "Product";
            this.Col_Product.Name = "Col_Product";
            this.Col_Product.ReadOnly = true;
            this.Col_Product.Width = 120;
            // 
            // Col_Year
            // 
            this.Col_Year.HeaderText = "Year";
            this.Col_Year.Name = "Col_Year";
            this.Col_Year.ReadOnly = true;
            // 
            // Col_Month
            // 
            this.Col_Month.HeaderText = "Month";
            this.Col_Month.Name = "Col_Month";
            this.Col_Month.ReadOnly = true;
            // 
            // Col_Configuration
            // 
            this.Col_Configuration.HeaderText = "Configuration";
            this.Col_Configuration.Name = "Col_Configuration";
            this.Col_Configuration.ReadOnly = true;
            // 
            // B_SimInput
            // 
            this.B_SimInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SimInput.Location = new System.Drawing.Point(5, 350);
            this.B_SimInput.Name = "B_SimInput";
            this.B_SimInput.Size = new System.Drawing.Size(187, 48);
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
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(926, 543);
=======
            this.label1.Location = new System.Drawing.Point(1094, 649);
>>>>>>> add new edit box to accept pasted serial numbers
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hans @ Newland Europe, 2011";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // B_NextFile
            // 
            this.B_NextFile.Location = new System.Drawing.Point(120, 91);
            this.B_NextFile.Name = "B_NextFile";
            this.B_NextFile.Size = new System.Drawing.Size(70, 56);
            this.B_NextFile.TabIndex = 6;
            this.B_NextFile.Text = "Next SN File";
            this.B_NextFile.UseVisualStyleBackColor = true;
            this.B_NextFile.Click += new System.EventHandler(this.B_NextFile_Click);
            // 
            // B_PrevFile
            // 
            this.B_PrevFile.Location = new System.Drawing.Point(23, 91);
            this.B_PrevFile.Name = "B_PrevFile";
            this.B_PrevFile.Size = new System.Drawing.Size(70, 56);
            this.B_PrevFile.TabIndex = 7;
            this.B_PrevFile.Text = "Previous SN File";
            this.B_PrevFile.UseVisualStyleBackColor = true;
            this.B_PrevFile.Click += new System.EventHandler(this.B_PrevFile_Click);
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
            // E_SNFile
            // 
            this.E_SNFile.Location = new System.Drawing.Point(12, 51);
            this.E_SNFile.Name = "E_SNFile";
            this.E_SNFile.Size = new System.Drawing.Size(170, 21);
            this.E_SNFile.TabIndex = 9;
            this.E_SNFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E_SNFileKP);
            // 
            // T_Info
            // 
            this.T_Info.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Info.Location = new System.Drawing.Point(12, 106);
            this.T_Info.Multiline = true;
            this.T_Info.Name = "T_Info";
            this.T_Info.Size = new System.Drawing.Size(170, 207);
            this.T_Info.TabIndex = 10;
            // 
            // B_GetFromPT
            // 
            this.B_GetFromPT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_GetFromPT.Location = new System.Drawing.Point(5, 436);
            this.B_GetFromPT.Name = "B_GetFromPT";
            this.B_GetFromPT.Size = new System.Drawing.Size(187, 48);
            this.B_GetFromPT.TabIndex = 11;
            this.B_GetFromPT.Text = "Get SN Files From PT";
            this.B_GetFromPT.UseVisualStyleBackColor = true;
            this.B_GetFromPT.Click += new System.EventHandler(this.B_GetFromPT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Open);
            this.groupBox1.Controls.Add(this.B_PrevFile);
            this.groupBox1.Controls.Add(this.B_NextFile);
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(843, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 160);
=======
            this.groupBox1.Location = new System.Drawing.Point(848, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 160);
>>>>>>> add new edit box to accept pasted serial numbers
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PC File Operation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(848, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 166);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To...";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(18, 119);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(149, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Create: Serial number";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Receipts";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fulfillment";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(1039, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 166);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By...";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(19, 75);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 16);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "Paste";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(19, 31);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 16);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Type";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
=======
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 603);
            this.textBox1.TabIndex = 16;
            // 
>>>>>>> add new edit box to accept pasted serial numbers
            // F_SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1234, 561);
=======
            this.ClientSize = new System.Drawing.Size(1234, 671);
            this.Controls.Add(this.textBox1);
>>>>>>> add new edit box to accept pasted serial numbers
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.T_Info);
            this.Controls.Add(this.E_SNFile);
            this.Controls.Add(this.B_GetFromPT);
            this.Controls.Add(this.L_SNFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_SimInput);
            this.Controls.Add(this.DG_SNList);
            this.Name = "F_SN";
            this.Text = "Serial Number Tool";
            ((System.ComponentModel.ISupportInitialize)(this.DG_SNList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.DataGridView DG_SNList;
        private System.Windows.Forms.Button B_SimInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Configuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_NextFile;
        private System.Windows.Forms.Button B_PrevFile;
        private System.Windows.Forms.Label L_SNFile;
        private System.Windows.Forms.TextBox E_SNFile;
        private System.Windows.Forms.TextBox T_Info;
        private System.Windows.Forms.Button B_GetFromPT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
<<<<<<< HEAD
=======
        private System.Windows.Forms.TextBox textBox1;
>>>>>>> add new edit box to accept pasted serial numbers
    }
}

