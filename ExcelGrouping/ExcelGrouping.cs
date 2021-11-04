using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using NPOI;
using NPOI.SS.UserModel;

namespace BATEncryption
{
    public partial class ExcelGrouping : Form
    {
        //配置提示窗口颜色
        readonly Color COLORDEFAULT = Color.Black;				// default color in text-output panel
        readonly Color COLORCOMMAND = Color.DarkGreen;           // ftp command color
        readonly Color COLORERROR = Color.Red;               // color of error messages	

        //窗口移动处理
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;        
        public ExcelGrouping()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //线程可以访问UI
            CheckForIllegalCrossThreadCalls = false;            
        }

        private void ToolMExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                if (e.Clicks == 1)
                {
                    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                }
                else
                {
                    //MessageBox.Show("双周-0000");
                    //SendMessage(this.Handle, WM_LBUTTONUP, 0, 0);
                }
            }
        }

        private void ButPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    //设置打开标题、后缀
                    Title = "请选择导入文件",
                    Filter = "xls,xlsx文件|*.xls;*xlsx"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName == "")
                    {
                        tbLog.Clear();
                        WriteToLog("空的文件，请重新选择！", COLORERROR);
                        return;
                    }
                    _Path.Text = dialog.FileName;
                    WriteToLog("文件正常，准备就绪！", COLORCOMMAND);
                    WriteToLog("路径:"+_Path.Text, COLORCOMMAND);
                    myProgressBar1.Value = 0;
                    myProgressBar2.Value = 0;
                    WriteToLog("读取配置项------------------开始----------------------" , COLORERROR);
                    WriteToLog("开 始 表:" + Properties.Settings.Default.starttable, COLORCOMMAND);
                    WriteToLog("表 头 数:" + Properties.Settings.Default.startrow, COLORCOMMAND);
                    WriteToLog("数 据 列:" + Properties.Settings.Default.datarow, COLORCOMMAND);
                    WriteToLog("过滤状态:" + Properties.Settings.Default.stateck, COLORCOMMAND);
                    WriteToLog("过滤字符:" + Properties.Settings.Default.separate, COLORCOMMAND);
                    WriteToLog("插 入 表:" + Properties.Settings.Default.targettable, COLORCOMMAND);
                    WriteToLog("插 入 列:" + Properties.Settings.Default.targetRow, COLORCOMMAND);
                    WriteToLog("读取配置项-----------------完成请开始执行-------------------", COLORERROR);
                }
            }
            catch (Exception)
            {
                WriteToLog("空的文件，请重新选择！", COLORERROR);
            }
        }
        public void WriteToLog(string message)
        {
            WriteToLog(message, COLORDEFAULT, true);
        }

        public void WriteToLog(string message, Color color)
        {
            WriteToLog(message, color, true);
        }

        public void WriteToLog(string message, bool crlf)
        {
            WriteToLog(message, COLORDEFAULT, crlf);
        }

        public void WriteToLog(string message, Color color, bool crlf)
        {
            tbLog.Focus();
            tbLog.AppendText("");
            tbLog.SelectionColor = color;
            tbLog.AppendText(message + (crlf ? "\r\n" : null));
        }
    /// <summary>
    /// 拆分EXCEL列到另一张表
    /// </summary>
        public void NPOIExcel()
        {
            //开始表格 第1行开始 当前值为:0
            int startTable = Convert.ToInt16(Properties.Settings.Default.starttable) - 1;
            //修改配置方案---------------------------------------------------------
            IWorkbook workbook = WorkbookFactory.Create(_Path.Text);
            //WriteToLog("总表数:" + workbook.NumberOfSheets, COLORCOMMAND);
            WriteToLog("总行数:" + workbook.GetSheetAt(startTable).PhysicalNumberOfRows, COLORCOMMAND);        
            //总表格数
            int tableNumber = workbook.NumberOfSheets;
            //开始行 第1行开始 当前值为:0
            int startRow = Convert.ToInt16(Properties.Settings.Default.startrow);
            //表记录条数
            int currentRecord = workbook.GetSheetAt(startTable).PhysicalNumberOfRows - startRow;
            //取得数据所在行
            int dataRow = Convert.ToInt16(Properties.Settings.Default.datarow)-1;
            //插入到第几张表格中
            int targettable = Convert.ToInt16(Properties.Settings.Default.targettable) - 1;
            //插入到表格中那列
            int targetrow = Convert.ToInt16(Properties.Settings.Default.targetRow) - 1;
            //分隔符号
            char[] separate = (Properties.Settings.Default.separate).ToCharArray();
            //当前行数
            int currentNumber = 0;
            //myProgressBar1.Value = couTabeNumber;
            //表格数量-进度条                   
            myProgressBar1.Maximum = tableNumber;
            //MessageBox.Show("表记录条数:" + currentRecord);
            myProgressBar2.Maximum = currentRecord;
            //myProgressBar1显示进度条文本
            string strText1 = "执行表总数: " + tableNumber + "/" + tableNumber;
            Font font1 = new Font("微软雅黑", (float)8, FontStyle.Regular);
            PointF pointF1 = new PointF(10, this.myProgressBar1.Height / 2 - 10);
            this.myProgressBar1.CreateGraphics().DrawString(strText1, font1, Brushes.Black, pointF1);
            //读取配置状态
            Boolean stateck_s;
            stateck_s = Properties.Settings.Default.stateck;
            //BOSIP列 第2行开始 当前值为:1
            //int state = Convert.ToInt16(Properties.Settings.Default.state) - 1;
            int state = Convert.ToInt16(Properties.Settings.Default.state) - 1; ;//过滤条件行号            
            int rowNumber = 0;//总行数
            int filterNumberNo = 0;//过滤行数 否
            int filterNumberYes = 0;//过滤行数 是
            string myStr;
            string thrName;
            //当前行数
            int currentNumber22 = 0;
            for (int j = startRow; j < workbook.GetSheetAt(startTable).PhysicalNumberOfRows; j++)
            {
                rowNumber++;
                //WriteToLog("开始行:" + j, COLORERROR);
                //Console.WriteLine("开始行：" + j);
                if (stateck_s == false || (stateck_s == true && workbook.GetSheetAt(startTable).GetRow(j).GetCell(state).ToString() == "是"))
                {
                   // myStr = dataList.Tables[startTable].Rows[j][dataRow].ToString();
                    myStr = workbook.GetSheetAt(startTable).GetRow(j).GetCell(dataRow).ToString();
                    string[] charMystr = myStr.Split(separate);
                    //WriteToLog("------------输出的值:" + myStr, COLORERROR);
                    filterNumberYes++;
                    foreach (string str in charMystr)
                    {
                        if (str != "")
                        {
                            currentNumber++;
                            thrName = workbook.GetSheetAt(startTable).GetRow(j).GetCell(2).ToString() + ",";
                            string oldstr = workbook.GetSheetAt(targettable).GetRow(Convert.ToInt16(str)).GetCell(targetrow).ToString();
                            workbook.GetSheetAt(targettable).GetRow(Convert.ToInt16(str)).GetCell(targetrow).SetCellValue(oldstr + thrName);
                            currentNumber22++;
                            WriteToLog("序号:" + rowNumber + " 位置第:" + (startTable + 1) + " 张表,第:" + j + " 行,条件为: 是 共" + filterNumberYes + " 记录拆分数:" + currentNumber22, COLORCOMMAND);
                        }

                    }
                    //myProgressBar2.Value = j - 1;                   
                }
                else
                {
                    filterNumberNo++;
                      if (stateck_s == true && workbook.GetSheetAt(startTable).GetRow(j).GetCell(state).ToString() == "否")
                    {
                        WriteToLog("序号:" + rowNumber + " 位置第:" + (startTable + 1) + " 张表,第:" + j + " 行,条件为: 否 过滤删除 共：" + filterNumberNo, COLORERROR);
                    }
                    if ((stateck_s == true && workbook.GetSheetAt(startTable).GetRow(j).GetCell(state).ToString() != "是") && (stateck_s == true && workbook.GetSheetAt(startTable).GetRow(j).GetCell(state).ToString() != "否"))
                    {
                        WriteToLog("序号:" + rowNumber + " 位置第:" + (startTable + 1) + " 张表,第:" + j + " 行,条件为: 未知 过滤删除 共：" + filterNumberNo, COLORERROR);
                    }
                }
                tbLog.ScrollToCaret();
                myProgressBar2.Value = rowNumber;
                string strText2 = "当前表行数: " + rowNumber + "/" + currentRecord;
                Font font2 = new Font("微软雅黑", (float)8, FontStyle.Regular);
                PointF pointF2 = new PointF(10, this.myProgressBar2.Height / 2 - 10);
                this.myProgressBar2.CreateGraphics().DrawString(strText2, font2, Brushes.Black, pointF2);
            }
            //导出excel
            FileStream fs = new FileStream(_Path.Text, FileMode.Create, FileAccess.ReadWrite);
            workbook.Write(fs);
            WriteToLog("导出Excel文件完成:" + _Path.Text, COLORCOMMAND);
            fs.Close();
            WriteToLog("关闭Excel文件:" + _Path.Text, COLORCOMMAND);
            tbLog.ScrollToCaret();
        }
        private void GeneratedFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(_Path.Text))
            {
                //WriteToLog("路径:"+_Path.Text, COLORCOMMAND);                
                //ThreadPool.QueueUserWorkItem(state => GenerateFile());
                //ThreadPool.QueueUserWorkItem(state => ExcelGenerateFile());
                ThreadPool.QueueUserWorkItem(state => NPOIExcel());
            }
            else
            {
                WriteToLog("选择的文件路径错误，请重新选择。", COLORERROR);
            }
        }
        private void Toolconfig_Click(object sender, EventArgs e)
        {
            Config cf = new Config();
            this.Opacity = 0.6;
            cf.ShowDialog();
            if (cf.OK == true)
            {
                this.Opacity = 1;
            }
        }
    }
    class MyProgressBar : ProgressBar //新建一个MyProgressBar类，它继承了ProgressBar的所有属性与方法
    {
        public MyProgressBar()
        {
            base.SetStyle(ControlStyles.UserPaint, true);//使控件可由用户自由重绘
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                SolidBrush brush = null;
                Rectangle bounds = new Rectangle(0, 0, base.Width, base.Height);
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), 1, 1, bounds.Width - 2, bounds.Height - 2);//此处完成背景重绘，并且按照属性中的BackColor设置背景色
                bounds.Height -= 4;
                bounds.Width = ((int)(bounds.Width * (((double)base.Value) / ((double)base.Maximum)))) - 4;//是的进度条跟着ProgressBar.Value值变化
                brush = new SolidBrush(this.ForeColor);
                e.Graphics.FillRectangle(brush, 2, 2, bounds.Width, bounds.Height);//此处完成前景重绘，依旧按照Progressbar的属性设置前景色
            }
            catch (Exception err)
            {
                MessageBox.Show("空的文件夹：" + err);
            }
        }
    }
}
