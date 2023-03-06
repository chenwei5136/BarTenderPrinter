namespace System.Device.TcpIpC
{
    partial class frmTcpC
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
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(259, 350);
         this.button1.Margin = new System.Windows.Forms.Padding(4);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(100, 29);
         this.button1.TabIndex = 3;
         this.button1.Text = "button1";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox1
         // 
         this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
         this.textBox1.Location = new System.Drawing.Point(0, 0);
         this.textBox1.Margin = new System.Windows.Forms.Padding(4);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(644, 104);
         this.textBox1.TabIndex = 4;
         this.textBox1.Text = "21321";
         this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
         this.label1.Location = new System.Drawing.Point(200, 192);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(55, 15);
         this.label1.TabIndex = 5;
         this.label1.Text = "label1";
         // 
         // frmTcpC
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(644, 454);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmTcpC";
         this.Text = "frmTcpC";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTcpC_FormClosing);
         this.Load += new System.EventHandler(this.frmTcpC_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Button button1;
        private Windows.Forms.TextBox textBox1;
      private Windows.Forms.Label label1;
   }
}