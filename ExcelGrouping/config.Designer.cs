namespace BATEncryption
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this._ToolMExit = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuMain = new System.Windows.Forms.MenuStrip();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._separate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._targetRow = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._targetTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.STATE_CK = new System.Windows.Forms.CheckBox();
            this.POS3_CK = new System.Windows.Forms.CheckBox();
            this.POS2_CK = new System.Windows.Forms.CheckBox();
            this.POS1_CK = new System.Windows.Forms.CheckBox();
            this.FUEL_CK = new System.Windows.Forms.CheckBox();
            this.BOS_CK = new System.Windows.Forms.CheckBox();
            this._state = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._dataRow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._startrow = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._starttable = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this._tabletotal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._MenuMain.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ToolMExit
            // 
            this._ToolMExit.Image = ((System.Drawing.Image)(resources.GetObject("_ToolMExit.Image")));
            this._ToolMExit.Name = "_ToolMExit";
            this._ToolMExit.Size = new System.Drawing.Size(28, 20);
            this._ToolMExit.Click += new System.EventHandler(this.ToolMExit_Click);
            // 
            // _MenuMain
            // 
            this._MenuMain.BackColor = System.Drawing.Color.DimGray;
            this._MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ToolMExit});
            this._MenuMain.Location = new System.Drawing.Point(0, 0);
            this._MenuMain.Name = "_MenuMain";
            this._MenuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._MenuMain.ShowItemToolTips = true;
            this._MenuMain.Size = new System.Drawing.Size(444, 24);
            this._MenuMain.TabIndex = 39;
            this._MenuMain.Text = "menuStrip1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._separate);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this._targetRow);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this._targetTable);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.STATE_CK);
            this.groupBox5.Controls.Add(this.POS3_CK);
            this.groupBox5.Controls.Add(this.POS2_CK);
            this.groupBox5.Controls.Add(this.POS1_CK);
            this.groupBox5.Controls.Add(this.FUEL_CK);
            this.groupBox5.Controls.Add(this.BOS_CK);
            this.groupBox5.Controls.Add(this._state);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this._dataRow);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this._startrow);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this._starttable);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this._tabletotal);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(1, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 334);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "用户配置";
            // 
            // _separate
            // 
            this._separate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._separate.Location = new System.Drawing.Point(138, 147);
            this._separate.Name = "_separate";
            this._separate.Size = new System.Drawing.Size(126, 21);
            this._separate.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(90, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 72;
            this.label11.Text = "分隔符:";
            // 
            // _targetRow
            // 
            this._targetRow.BackColor = System.Drawing.Color.White;
            this._targetRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._targetRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._targetRow.FormattingEnabled = true;
            this._targetRow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this._targetRow.Location = new System.Drawing.Point(140, 225);
            this._targetRow.Name = "_targetRow";
            this._targetRow.Size = new System.Drawing.Size(141, 20);
            this._targetRow.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(67, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "插入第几列:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.SpringGreen;
            this.label10.Location = new System.Drawing.Point(143, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 68;
            // 
            // _targetTable
            // 
            this._targetTable.BackColor = System.Drawing.Color.White;
            this._targetTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._targetTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._targetTable.FormattingEnabled = true;
            this._targetTable.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this._targetTable.Location = new System.Drawing.Point(141, 200);
            this._targetTable.Name = "_targetTable";
            this._targetTable.Size = new System.Drawing.Size(141, 20);
            this._targetTable.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "插入第几张表格:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(143, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 65;
            // 
            // STATE_CK
            // 
            this.STATE_CK.AutoSize = true;
            this.STATE_CK.Location = new System.Drawing.Point(291, 123);
            this.STATE_CK.Name = "STATE_CK";
            this.STATE_CK.Size = new System.Drawing.Size(60, 16);
            this.STATE_CK.TabIndex = 64;
            this.STATE_CK.Text = "已关闭";
            this.STATE_CK.UseVisualStyleBackColor = true;
            // 
            // POS3_CK
            // 
            this.POS3_CK.AutoSize = true;
            this.POS3_CK.Location = new System.Drawing.Point(348, 277);
            this.POS3_CK.Name = "POS3_CK";
            this.POS3_CK.Size = new System.Drawing.Size(48, 16);
            this.POS3_CK.TabIndex = 55;
            this.POS3_CK.Text = "POS3";
            this.POS3_CK.UseVisualStyleBackColor = true;
            this.POS3_CK.Visible = false;
            // 
            // POS2_CK
            // 
            this.POS2_CK.AutoSize = true;
            this.POS2_CK.Location = new System.Drawing.Point(275, 277);
            this.POS2_CK.Name = "POS2_CK";
            this.POS2_CK.Size = new System.Drawing.Size(48, 16);
            this.POS2_CK.TabIndex = 54;
            this.POS2_CK.Text = "POS2";
            this.POS2_CK.UseVisualStyleBackColor = true;
            this.POS2_CK.Visible = false;
            // 
            // POS1_CK
            // 
            this.POS1_CK.AutoSize = true;
            this.POS1_CK.Location = new System.Drawing.Point(203, 277);
            this.POS1_CK.Name = "POS1_CK";
            this.POS1_CK.Size = new System.Drawing.Size(48, 16);
            this.POS1_CK.TabIndex = 53;
            this.POS1_CK.Text = "POS1";
            this.POS1_CK.UseVisualStyleBackColor = true;
            this.POS1_CK.Visible = false;
            // 
            // FUEL_CK
            // 
            this.FUEL_CK.AutoSize = true;
            this.FUEL_CK.Location = new System.Drawing.Point(127, 277);
            this.FUEL_CK.Name = "FUEL_CK";
            this.FUEL_CK.Size = new System.Drawing.Size(48, 16);
            this.FUEL_CK.TabIndex = 52;
            this.FUEL_CK.Text = "FUEL";
            this.FUEL_CK.UseVisualStyleBackColor = true;
            this.FUEL_CK.Visible = false;
            // 
            // BOS_CK
            // 
            this.BOS_CK.AutoSize = true;
            this.BOS_CK.Location = new System.Drawing.Point(59, 277);
            this.BOS_CK.Name = "BOS_CK";
            this.BOS_CK.Size = new System.Drawing.Size(42, 16);
            this.BOS_CK.TabIndex = 51;
            this.BOS_CK.Text = "BOS";
            this.BOS_CK.UseVisualStyleBackColor = true;
            this.BOS_CK.Visible = false;
            // 
            // _state
            // 
            this._state.BackColor = System.Drawing.Color.White;
            this._state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._state.FormattingEnabled = true;
            this._state.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this._state.Location = new System.Drawing.Point(140, 121);
            this._state.Name = "_state";
            this._state.Size = new System.Drawing.Size(141, 20);
            this._state.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "过滤条件所在行(是/否):";
            // 
            // _dataRow
            // 
            this._dataRow.BackColor = System.Drawing.Color.White;
            this._dataRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dataRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._dataRow.FormattingEnabled = true;
            this._dataRow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this._dataRow.Location = new System.Drawing.Point(141, 95);
            this._dataRow.Name = "_dataRow";
            this._dataRow.Size = new System.Drawing.Size(141, 20);
            this._dataRow.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "拆分所在列:";
            // 
            // _startrow
            // 
            this._startrow.BackColor = System.Drawing.Color.White;
            this._startrow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._startrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startrow.FormattingEnabled = true;
            this._startrow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this._startrow.Location = new System.Drawing.Point(141, 69);
            this._startrow.Name = "_startrow";
            this._startrow.Size = new System.Drawing.Size(141, 20);
            this._startrow.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "表头占用行数:";
            // 
            // _starttable
            // 
            this._starttable.BackColor = System.Drawing.Color.White;
            this._starttable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._starttable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._starttable.FormattingEnabled = true;
            this._starttable.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this._starttable.Location = new System.Drawing.Point(141, 43);
            this._starttable.Name = "_starttable";
            this._starttable.Size = new System.Drawing.Size(141, 20);
            this._starttable.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(68, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "拆分所在表:";
            // 
            // _tabletotal
            // 
            this._tabletotal.BackColor = System.Drawing.Color.White;
            this._tabletotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._tabletotal.Enabled = false;
            this._tabletotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._tabletotal.FormattingEnabled = true;
            this._tabletotal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this._tabletotal.Location = new System.Drawing.Point(141, 17);
            this._tabletotal.Name = "_tabletotal";
            this._tabletotal.Size = new System.Drawing.Size(141, 20);
            this._tabletotal.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(93, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "表格数:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.SpringGreen;
            this.label8.Location = new System.Drawing.Point(164, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 26;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this._MenuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置";
            this.Load += new System.EventHandler(this.Config_Load);
            this._MenuMain.ResumeLayout(false);
            this._MenuMain.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem _ToolMExit;
        private System.Windows.Forms.MenuStrip _MenuMain;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox _starttable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _tabletotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox _startrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _dataRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _state;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox POS3_CK;
        private System.Windows.Forms.CheckBox POS2_CK;
        private System.Windows.Forms.CheckBox POS1_CK;
        private System.Windows.Forms.CheckBox FUEL_CK;
        private System.Windows.Forms.CheckBox BOS_CK;
        private System.Windows.Forms.CheckBox STATE_CK;
        private System.Windows.Forms.ComboBox _targetRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _targetTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _separate;
        private System.Windows.Forms.Label label11;
    }
}