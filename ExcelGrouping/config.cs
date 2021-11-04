using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BATEncryption
{
    public partial class Config : Form
    {
        public bool m_bOK = false;  // 关闭后状态
        public Config()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public bool OK
        {
            get { return m_bOK; }
        }
        private void Config_Load(object sender, EventArgs e)
        {
            _tabletotal.Text = Properties.Settings.Default.filetotal;
            _starttable.Text = Properties.Settings.Default.starttable;
            _startrow.Text = Properties.Settings.Default.startrow;
            _dataRow.Text = Properties.Settings.Default.datarow;
            _targetTable.Text= Properties.Settings.Default.targettable;
            _targetRow.Text = Properties.Settings.Default.targetRow;
            _state.Text = Properties.Settings.Default.state;
            _separate.Text = Properties.Settings.Default.separate;
            BOS_CK.Checked = Properties.Settings.Default.bos;
            FUEL_CK.Checked = Properties.Settings.Default.fuel;
            POS1_CK.Checked = Properties.Settings.Default.pos1;
            POS2_CK.Checked = Properties.Settings.Default.pos2;
            POS3_CK.Checked = Properties.Settings.Default.pos3;
            STATE_CK.Checked = Properties.Settings.Default.stateck;
            TaskStatusColor(BOS_CK);
            TaskStatusColor(FUEL_CK);
            TaskStatusColor(POS1_CK);
            TaskStatusColor(POS2_CK);
            TaskStatusColor(POS3_CK);
            TaskStatusColor(STATE_CK);

            _tabletotal.TextChanged += TextChangedFunction;
            _starttable.TextChanged += TextChangedFunction;
            _startrow.TextChanged += TextChangedFunction;
            _dataRow.TextChanged += TextChangedFunction;
            _targetTable.TextChanged += TextChangedFunction;
            _targetRow.TextChanged += TextChangedFunction;
            _separate.TextChanged += TextChangedFunction;
            _state.TextChanged += TextChangedFunction;
            BOS_CK.CheckStateChanged += TextChangedFunction;
            FUEL_CK.CheckStateChanged += TextChangedFunction;
            POS1_CK.CheckStateChanged += TextChangedFunction;
            POS2_CK.CheckStateChanged += TextChangedFunction;
            POS3_CK.CheckStateChanged += TextChangedFunction;
            STATE_CK.CheckStateChanged += TextChangedFunction;

            if (STATE_CK.Checked == false)
            {
                _state.Enabled = false;
                STATE_CK.Text = "已关闭";
            }
            else
            {
                STATE_CK.Text = "已开启";
            }
        }
        private void TextChangedFunction(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (c.Name == "_filetotal")
            {
                Properties.Settings.Default.filetotal = _tabletotal.Text;
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "_starttable")
            {
                Properties.Settings.Default.starttable = _starttable.Text;
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "_startrow")
            {
                Properties.Settings.Default.startrow = _startrow.Text;
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "_dataRow")
            {
                Properties.Settings.Default.datarow = _dataRow.Text;
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "_targetTable")
            {
                Properties.Settings.Default.targettable = _targetTable.Text; 
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "_targetRow")
            {
                Properties.Settings.Default.targetRow = _targetRow.Text; 
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "_separate")
            {
                Properties.Settings.Default.separate = _separate.Text;
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "_state")
            {
                Properties.Settings.Default.state = _state.Text;
                //MessageBox.Show("保存成功了！");
            }
            //复选框保存与读取
            if (c.Name == "BOS_CK")
            {
                if (BOS_CK.Checked)
                {
                    Properties.Settings.Default.bos = true;
                }
                else
                {
                    Properties.Settings.Default.bos = false;                    
                }
                TaskStatusColor(BOS_CK);
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "FUEL_CK")
            {
                if (FUEL_CK.Checked)
                {
                    Properties.Settings.Default.fuel = true;
                }
                else
                {
                    Properties.Settings.Default.fuel = false;                    
                }
                TaskStatusColor(FUEL_CK);
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "POS1_CK")
            {
                if (POS1_CK.Checked)
                {
                    Properties.Settings.Default.pos1 =true;
                }
                else
                {
                    Properties.Settings.Default.pos1 = false;                    
                }
                TaskStatusColor(POS1_CK);
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "POS2_CK")
            {
                if (POS2_CK.Checked)
                {
                    Properties.Settings.Default.pos2 = true;
                }
                else
                {
                    Properties.Settings.Default.pos2 = false;                    
                }
                TaskStatusColor(POS2_CK);
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "POS3_CK")
            {
                    if (POS3_CK.Checked)
                    {
                        Properties.Settings.Default.pos3 = true;
                }
                else
                {
                    Properties.Settings.Default.pos3 = false;                   
                }
                TaskStatusColor(POS3_CK);
                //MessageBox.Show("保存成功了！");
            }
            if (c.Name == "STATE_CK")
            {
                if (STATE_CK.Checked)
                {
                    Properties.Settings.Default.stateck = true;
                    _state.Enabled = true;
                    STATE_CK.Text = "已开启";
                }
                else
                {
                    Properties.Settings.Default.stateck = false;
                    _state.Enabled = false;
                    STATE_CK.Text = "已关闭";
                }
                TaskStatusColor(STATE_CK);
                //MessageBox.Show("保存成功了！");
            }
            Properties.Settings.Default.Save();
        }
            private void ToolMExit_Click(object sender, EventArgs e)
        {
            m_bOK = true;
            this.Close();
        }
        private void TaskStatusColor(CheckBox myCheckBOX)
        {
            if (myCheckBOX.Checked)
            {
                myCheckBOX.ForeColor = Color.Green;
                //myCheckBOX.Text = "已开启";               
            }
            else
            {
                myCheckBOX.ForeColor = Color.Red;
                //myCheckBOX.Text = "已关闭";                
            }
        }
    }
}
