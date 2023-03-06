using System.Windows.Forms;

namespace BarTenderPrinter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
      protected override CreateParams CreateParams
      {
         get
         {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;
            return cp;
         }
      }
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
         this.components = new System.ComponentModel.Container();
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.button2 = new System.Windows.Forms.Button();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.textBox4 = new System.Windows.Forms.TextBox();
         this.button3 = new System.Windows.Forms.Button();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.textBox5 = new System.Windows.Forms.TextBox();
         this.button4 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(64, 14);
         this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 22);
         this.button1.TabIndex = 0;
         this.button1.Text = "print";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Visible = false;
         this.button1.Click += new System.EventHandler(this.Print_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(195, 204);
         this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 25);
         this.textBox1.TabIndex = 2;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(64, 116);
         this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(972, 25);
         this.textBox2.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(61, 208);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(122, 15);
         this.label2.TabIndex = 4;
         this.label2.Text = "user1联接状态：";
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(64, 161);
         this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(117, 22);
         this.button2.TabIndex = 5;
         this.button2.Text = "扫码枪界面";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(16, 252);
         this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.textBox3.Multiline = true;
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(412, 25);
         this.textBox3.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(532, 208);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(122, 15);
         this.label3.TabIndex = 7;
         this.label3.Text = "user2联接状态：";
         // 
         // textBox4
         // 
         this.textBox4.Location = new System.Drawing.Point(668, 201);
         this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.textBox4.Name = "textBox4";
         this.textBox4.Size = new System.Drawing.Size(132, 25);
         this.textBox4.TabIndex = 8;
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(535, 155);
         this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(100, 29);
         this.button3.TabIndex = 9;
         this.button3.Text = "user2界面";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // timer1
         // 
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // textBox5
         // 
         this.textBox5.Location = new System.Drawing.Point(535, 252);
         this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.textBox5.Name = "textBox5";
         this.textBox5.Size = new System.Drawing.Size(501, 25);
         this.textBox5.TabIndex = 10;
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(64, 81);
         this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(100, 29);
         this.button4.TabIndex = 11;
         this.button4.Text = "发送一";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(457, 81);
         this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(100, 29);
         this.button5.TabIndex = 12;
         this.button5.Text = "发送二";
         this.button5.UseVisualStyleBackColor = true;
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(264, 51);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(331, 15);
         this.label1.TabIndex = 13;
         this.label1.Text = "ps:作为客户端，发送给服务器，接收服务器数据";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(267, 16);
         this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(69, 15);
         this.label4.TabIndex = 14;
         this.label4.Text = "demo说明";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1067, 562);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.button5);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.textBox5);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.textBox4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "Form1";
         this.Text = "Form1";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

