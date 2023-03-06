using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Device.TcpIpC
{
   public class TcpIpClass
   {
      Thread thread;
      public Action<string> actStrMsg;
      //public delegate void EventHandler(string a);
      //public event EventHandler actStrMsg;

      public string Name = "";
      public TcpIpClass()
      {

      }


      #region 客户端
      public Socket lensClient = null, shellClient = null;
      public bool lensCon = false, shellCon = false;
      /// 创建客户端
      public bool ClientLensSocket(string IP, int port)
      {
         ///创建客户端
         lensClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
         ///IP地址
         IPAddress ip = IPAddress.Parse(IP);
         ///端口号
         IPEndPoint endPoint = new IPEndPoint(ip, port);
         ///建立与服务器的远程连接
         try
         {
            thread = new Thread(ReciveMsg);
            thread.IsBackground = true;
            thread.Start(lensClient);
            lensClient.Connect(endPoint);
            this.lensCon = true;
            return true;
         }
         catch (Exception ex)
         {
            this.lensCon = false;
            return false;
         }

      }


      public void SocketClose()
      {
         try
         {
            thread?.Abort();
            client.Close();
            lensClient.Close();
         }
         catch (Exception) { }
      }


      /// 客户端发送消息，服务端接收
      public bool SendLensLoadMsg(string msg)
      {
            try
            {
                if (!this.lensCon) { return false; }
                byte[] arrMsg = Encoding.UTF8.GetBytes(msg);
                int num = lensClient.Send(arrMsg);
                if (arrMsg.Length == num)
                {
                    return true;
                }
                else
                {
                    this.lensCon = false;
                    return false;
                }
            }
            catch (Exception) { return false; }
         
      }

      Socket client;
      public string msg = string.Empty;
      /// 客户端接收到服务器发送的消息
      private void ReciveMsg(object o)
      {
         client = o as Socket;
         while (true)
         {
            try
            {
               ///定义客户端接收到的信息大小
               byte[] arrList = new byte[1024 * 1024];
               ///接收到的信息大小(所占字节数)
               int length = client.Receive(arrList);
                msg = /*DateTime.Now + */Encoding.UTF8.GetString(arrList, 0, length);
               if (actStrMsg != null && !string.IsNullOrEmpty(msg))
               {
                  actStrMsg(msg);
               }
            }
            catch (Exception)
            {
               ///关闭客户端
               //MessageBox.Show("error");
               //client.Close();
            }
         }
      }
      #endregion
   }
}
