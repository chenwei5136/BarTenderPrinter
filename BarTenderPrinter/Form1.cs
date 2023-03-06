using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.TcpIpC;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarTenderPrinter
{
   
    public partial class Form1 : Form
    {
        AutoWindowsSize AutoSize;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打印项目
        /// </summary>
        //private Item printItem = new Item();

        /// <summary>
        /// 标签应用
        /// </summary>
        // private readonly BarTender.Application btApp = new BarTender.Application();

        /// <summary>
        /// 标签样式对象
        /// </summary>
        private BarTender.Format btFormat;
        public TcpIpClass TcpCommunication;
        public TcpIpClass TcpCommunication2;
        public string user1str;
        public string user2str;
        string SNCode = "";
        frmTcpC m_frmTcpC;
        frmTcpC m_frmTcpC2;
        //打印条码
        private void Print_Click(object sender, EventArgs e)
        {
            try
            {
                string year = DateTime.Now.Year.ToString();
                string yer = year.Substring(2);
                string mon = DateTime.Now.Month.ToString();
                // string SNCode = "XSD" + yer + mon + TaskID.Text + "1" + Convert.ToInt32(ProductNum);
                string currentTime = DateTime.Now.ToString("yyyy-MM-dd");
                ////设置打印份数
                btFormat.PrintSetup.IdenticalCopiesOfLabel = 1;

                //for (int i = 0; i < cnt; i++)
                //{
                //    //设置字段值
                btFormat.SetNamedSubStringValue("ProductDate", currentTime);
                btFormat.SetNamedSubStringValue("SNCode", SNCode);
                //打印标签
                btFormat.PrintOut(false, false);
                //}
                ////不保存标签退出
                btFormat.Close(BarTender.BtSaveOptions.btDoNotSaveChanges);
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印机打开异常:" + ex.ToString());
            }
        }


        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 弹出提示框
            DialogResult result = MessageBox.Show("确定要关闭窗体吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                TcpCommunication.SocketClose();
                TcpCommunication2.SocketClose();

                //关闭标签应用，并且不保存
                // btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges);
                // 关闭窗体
                e.Cancel = false;

            }
            else
            {
                // 不关闭窗体
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

         //自适应窗体
            AutoSize = new AutoWindowsSize(this);
         //user1
         TcpCommunication = new TcpIpClass() { Name = "产品读码器" };
            TcpCommunication.actStrMsg += DealWithCodeReaderReceiveDataTwo;
            textBox1.Text = TcpCommunication.ClientLensSocket("192.168.0.9", 8000) ? "success" : "error";
            m_frmTcpC = new frmTcpC(TcpCommunication);
            //user2
            TcpCommunication2 = new TcpIpClass() { Name = "产品读码器" };
            TcpCommunication2.actStrMsg += DealWithCodeReaderReceiveDataThree;
            textBox4.Text = TcpCommunication2.ClientLensSocket("192.168.0.9", 8000) ? "success" : "error";
            m_frmTcpC2 = new frmTcpC(TcpCommunication2);
        }

        /// <summary>
        /// 读码器数据接收new
        /// </summary>
        /// <param name="result"></param>
        private void DealWithCodeReaderReceiveDataTwo(string result)
        {
            try
            {
                if (!string.IsNullOrEmpty(result))
                {
                    user1str = result.Trim();
                    //user1str = SNCode;
                    //textBox2.Text = SNCode;
                    //textBox3.Text += result;
                    //if (SNCode != result.Trim())
                    //{
                    //    SNCode = result.Trim();
                    //    //textBox2.Text = SNCode;
                    //}
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void DealWithCodeReaderReceiveDataThree(string result)
        {
            try
            {
                if (!string.IsNullOrEmpty(result))
                {
                    user2str = result.Trim();
                    //user1str = SNCode;
                    //textBox2.Text = SNCode;
                    //textBox3.Text += result;
                    //if (SNCode != result.Trim())
                    //{
                    //    SNCode = result.Trim();
                    //    //textBox2.Text = SNCode;
                    //}
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            m_frmTcpC.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m_frmTcpC2.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            textBox3.Text = user1str;
            textBox5.Text = user2str;
            timer1.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TcpCommunication.SendLensLoadMsg(textBox2.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TcpCommunication2.SendLensLoadMsg(textBox2.Text);

        }

      private void Form1_SizeChanged(object sender, EventArgs e)
      {
         if (AutoSize != null)
         {
            AutoSize.FormSizeChanged();
         }
      }
   }
}
