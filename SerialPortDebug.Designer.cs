namespace 串口调试助手
{
    partial class SerialPortDebug
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
            this.components = new System.ComponentModel.Container();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_DataBit = new System.Windows.Forms.ComboBox();
            this.comboBox_StopBit = new System.Windows.Forms.ComboBox();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_io = new System.Windows.Forms.Button();
            this.richTextBox_Receive = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Send = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(82, 33);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_PortName.TabIndex = 0;
            this.comboBox_PortName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(82, 72);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_BaudRate.TabIndex = 1;
            this.comboBox_BaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_BaudRate_SelectedIndexChanged);
            // 
            // comboBox_DataBit
            // 
            this.comboBox_DataBit.FormattingEnabled = true;
            this.comboBox_DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_DataBit.Location = new System.Drawing.Point(82, 111);
            this.comboBox_DataBit.Name = "comboBox_DataBit";
            this.comboBox_DataBit.Size = new System.Drawing.Size(121, 20);
            this.comboBox_DataBit.TabIndex = 2;
            // 
            // comboBox_StopBit
            // 
            this.comboBox_StopBit.FormattingEnabled = true;
            this.comboBox_StopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "None"});
            this.comboBox_StopBit.Location = new System.Drawing.Point(82, 150);
            this.comboBox_StopBit.Name = "comboBox_StopBit";
            this.comboBox_StopBit.Size = new System.Drawing.Size(121, 20);
            this.comboBox_StopBit.TabIndex = 3;
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.comboBox_Parity.Location = new System.Drawing.Point(82, 189);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Parity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "串口号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "停止位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "校验位";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(25, 251);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(96, 33);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_io
            // 
            this.button_io.Location = new System.Drawing.Point(148, 251);
            this.button_io.Name = "button_io";
            this.button_io.Size = new System.Drawing.Size(101, 33);
            this.button_io.TabIndex = 11;
            this.button_io.Text = "打开/关闭串口";
            this.button_io.UseVisualStyleBackColor = true;
            this.button_io.Click += new System.EventHandler(this.button_io_Click);
            // 
            // richTextBox_Receive
            // 
            this.richTextBox_Receive.Location = new System.Drawing.Point(305, 39);
            this.richTextBox_Receive.Name = "richTextBox_Receive";
            this.richTextBox_Receive.Size = new System.Drawing.Size(407, 271);
            this.richTextBox_Receive.TabIndex = 12;
            this.richTextBox_Receive.Text = "数据接收显示窗口";
            this.richTextBox_Receive.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox_Send
            // 
            this.richTextBox_Send.Location = new System.Drawing.Point(125, 384);
            this.richTextBox_Send.Name = "richTextBox_Send";
            this.richTextBox_Send.Size = new System.Drawing.Size(518, 24);
            this.richTextBox_Send.TabIndex = 13;
            this.richTextBox_Send.Text = "数据发送窗口";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(660, 384);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(52, 24);
            this.button_send.TabIndex = 14;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(499, 325);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(52, 24);
            this.button_clear.TabIndex = 15;
            this.button_clear.Text = "清除";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // SerialPortDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.richTextBox_Send);
            this.Controls.Add(this.richTextBox_Receive);
            this.Controls.Add(this.button_io);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Parity);
            this.Controls.Add(this.comboBox_StopBit);
            this.Controls.Add(this.comboBox_DataBit);
            this.Controls.Add(this.comboBox_BaudRate);
            this.Controls.Add(this.comboBox_PortName);
            this.Name = "SerialPortDebug";
            this.Text = "SerialPortDebug";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_DataBit;
        private System.Windows.Forms.ComboBox comboBox_StopBit;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_io;
        private System.Windows.Forms.RichTextBox richTextBox_Receive;
        private System.Windows.Forms.RichTextBox richTextBox_Send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_clear;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

