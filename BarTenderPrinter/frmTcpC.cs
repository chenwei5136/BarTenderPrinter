using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Device.TcpIpC
{
   public partial class frmTcpC : Form
   {
      TcpIpClass tic;
      public frmTcpC()
      {
         InitializeComponent();
      }
      public frmTcpC(TcpIpClass _tic) : this()
      {
         tic = _tic;
      }

      private void frmTcpC_Load(object sender, EventArgs e)
      {
         tic.actStrMsg += WayMessage;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.tic.SendLensLoadMsg("CanAccess");
      }

      public void WayMessage(string strM)
      {
         label1.Text = strM;
         //textBox1.Text = strM;
      }

      private void frmTcpC_FormClosing(object sender, FormClosingEventArgs e)
      {
         tic.actStrMsg -= WayMessage;
      }

      private void button2_Click(object sender, EventArgs e)
      {
         // tic.actStrMsg += WayMessage;
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }
   }
}
