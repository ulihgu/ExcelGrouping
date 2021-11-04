namespace BATEncryption
{
    partial class ExcelGrouping
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelGrouping));
            this._MenuMain = new System.Windows.Forms.MenuStrip();
            this._ToolMExit = new System.Windows.Forms.ToolStripMenuItem();
            this._Toolconfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._generatedFile = new System.Windows.Forms.Button();
            this._Path = new System.Windows.Forms.TextBox();
            this._ButPath = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.myProgressBar2 = new BATEncryption.MyProgressBar();
            this.myProgressBar1 = new BATEncryption.MyProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this._MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _MenuMain
            // 
            this._MenuMain.BackColor = System.Drawing.Color.DimGray;
            this._MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ToolMExit,
            this._Toolconfig,
            this.toolStripMenuItem1});
            this._MenuMain.Location = new System.Drawing.Point(0, 0);
            this._MenuMain.Name = "_MenuMain";
            this._MenuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._MenuMain.ShowItemToolTips = true;
            this._MenuMain.Size = new System.Drawing.Size(576, 24);
            this._MenuMain.TabIndex = 38;
            this._MenuMain.Text = "menuStrip1";
            this._MenuMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuMain_MouseDown);
            // 
            // _ToolMExit
            // 
            this._ToolMExit.Image = ((System.Drawing.Image)(resources.GetObject("_ToolMExit.Image")));
            this._ToolMExit.Name = "_ToolMExit";
            this._ToolMExit.Size = new System.Drawing.Size(28, 20);
            this._ToolMExit.Click += new System.EventHandler(this.ToolMExit_Click);
            // 
            // _Toolconfig
            // 
            this._Toolconfig.Image = global::BATEncryption.Properties.Resources.配置;
            this._Toolconfig.Name = "_Toolconfig";
            this._Toolconfig.Size = new System.Drawing.Size(28, 20);
            this._Toolconfig.ToolTipText = "Ping测试网络.";
            this._Toolconfig.Click += new System.EventHandler(this.Toolconfig_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            // 
            // _generatedFile
            // 
            this._generatedFile.BackColor = System.Drawing.Color.SteelBlue;
            this._generatedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._generatedFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._generatedFile.ForeColor = System.Drawing.Color.Transparent;
            this._generatedFile.Location = new System.Drawing.Point(462, 28);
            this._generatedFile.Name = "_generatedFile";
            this._generatedFile.Size = new System.Drawing.Size(109, 23);
            this._generatedFile.TabIndex = 42;
            this._generatedFile.Text = "开始执行";
            this._generatedFile.UseVisualStyleBackColor = false;
            this._generatedFile.Click += new System.EventHandler(this.GeneratedFile_Click);
            // 
            // _Path
            // 
            this._Path.Location = new System.Drawing.Point(7, 30);
            this._Path.Name = "_Path";
            this._Path.Size = new System.Drawing.Size(342, 21);
            this._Path.TabIndex = 41;
            // 
            // _ButPath
            // 
            this._ButPath.BackColor = System.Drawing.Color.SteelBlue;
            this._ButPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._ButPath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._ButPath.ForeColor = System.Drawing.Color.Transparent;
            this._ButPath.Location = new System.Drawing.Point(355, 28);
            this._ButPath.Name = "_ButPath";
            this._ButPath.Size = new System.Drawing.Size(103, 23);
            this._ButPath.TabIndex = 40;
            this._ButPath.Text = "选择文件目录";
            this._ButPath.UseVisualStyleBackColor = false;
            this._ButPath.Click += new System.EventHandler(this.ButPath_Click);
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.BackColor = System.Drawing.SystemColors.Control;
            this.tbLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.Location = new System.Drawing.Point(8, 57);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(561, 332);
            this.tbLog.TabIndex = 43;
            this.tbLog.Text = "";
            // 
            // myProgressBar2
            // 
            this.myProgressBar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myProgressBar2.Location = new System.Drawing.Point(7, 429);
            this.myProgressBar2.Name = "myProgressBar2";
            this.myProgressBar2.Size = new System.Drawing.Size(564, 28);
            this.myProgressBar2.Step = 1;
            this.myProgressBar2.TabIndex = 45;
            // 
            // myProgressBar1
            // 
            this.myProgressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myProgressBar1.Location = new System.Drawing.Point(7, 395);
            this.myProgressBar1.Name = "myProgressBar1";
            this.myProgressBar1.Size = new System.Drawing.Size(564, 28);
            this.myProgressBar1.Step = 1;
            this.myProgressBar1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Excel拆分工具";
            // 
            // ExcelGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myProgressBar2);
            this.Controls.Add(this.myProgressBar1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this._generatedFile);
            this.Controls.Add(this._Path);
            this.Controls.Add(this._ButPath);
            this.Controls.Add(this._MenuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcelGrouping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel拆分工具v1.0";
            this._MenuMain.ResumeLayout(false);
            this._MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _MenuMain;
        private System.Windows.Forms.ToolStripMenuItem _ToolMExit;
        private System.Windows.Forms.ToolStripMenuItem _Toolconfig;
        private System.Windows.Forms.Button _generatedFile;
        private System.Windows.Forms.TextBox _Path;
        private System.Windows.Forms.Button _ButPath;
        private System.Windows.Forms.RichTextBox tbLog;
        private MyProgressBar myProgressBar1;
        private MyProgressBar myProgressBar2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label3;
    }
}

