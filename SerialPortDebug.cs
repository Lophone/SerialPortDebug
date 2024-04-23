using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 串口调试助手
{
    public partial class SerialPortDebug : Form
    {
        public SerialPortDebug()
        {
            InitializeComponent();
        }
        #region 初始化窗体
        private void Form1_Load(object sender, EventArgs e) //加载界面程序
        {
            try
            {
                string[] str = SerialPort.GetPortNames(); //获取连接到电脑的串口
                comboBox_PortName.Items.Clear();          //清楚串口号下拉框的内容
                comboBox_PortName.Items.AddRange(str);     //将串口号添加到下拉框
                if (str.Length > 0)
                {
                    comboBox_PortName.SelectedIndex = 0;    //设置comboBox的初始值
                    comboBox_PortName.SelectedIndex = 1;
                    comboBox_PortName.SelectedIndex = 2;
                    comboBox_PortName.SelectedIndex = 3;
                    comboBox_PortName.SelectedIndex = 7;
                }
                else
                {
                    MessageBox.Show("当前无串口连接！");                
                }
            }
            catch 
            {
                MessageBox.Show("无串口设备！/r/n请检查是否连接设备！/r/n请检查设备驱动！");
            }
        }
        #endregion


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region 串口搜索
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = SerialPort.GetPortNames(); //获取连接到电脑的串口
                comboBox_PortName.Items.Clear();          //清楚串口号下拉框的内容
                comboBox_PortName.Items.AddRange(str);     //将串口号添加到下拉框
                if (str.Length > 0)
                {
                    comboBox_PortName.SelectedIndex = 0;  //设置comboBox的初始值
                    comboBox_PortName.SelectedIndex = 1;
                    comboBox_PortName.SelectedIndex = 2;
                    comboBox_PortName.SelectedIndex = 3;
                    comboBox_PortName.SelectedIndex = 7;
                }
                else
                {
                    MessageBox.Show("当前无串口连接！");
                }
            }
            catch
            {
                MessageBox.Show("无串口设备！/r/n请检查是否连接设备！/r/n请检查设备驱动！");
            }
        }
        #endregion
        #region 打开串口
        private void button_io_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                if (comboBox_PortName.SelectedItem == null)
                {
                    MessageBox.Show("请选择正确的串口", "提示");
                    return;
                }
                //设置串口参数
                serialPort1.PortName = comboBox_PortName.SelectedItem.ToString(); //将选择的端口设为serialpORT
                serialPort1.BaudRate = Convert.ToInt32(comboBox_BaudRate.SelectedItem.ToString());
                serialPort1.DataBits = Convert.ToInt32(comboBox_DataBit.SelectedItem.ToString());

                //停止位的设置
                if (comboBox_StopBit.Text == "One")
                {
                    serialPort1.StopBits = StopBits.One;
                }
                else if (comboBox_StopBit.Text == "Two")
                {
                    serialPort1.StopBits = StopBits.Two;
                }
                else if (comboBox_StopBit.Text == "OnePointFive")
                {
                    serialPort1.StopBits = StopBits.OnePointFive;
                }
                else if (comboBox_StopBit.Text == "None")
                {
                    serialPort1.StopBits = StopBits.None;
                }
                //奇偶校验位的设置
                if (comboBox_Parity.Text == "Odd")
                {
                    serialPort1.Parity = Parity.Odd;
                }
                else if (comboBox_Parity.Text == "Even")
                {
                    serialPort1.Parity = Parity.Even;
                }
                else if (comboBox_Parity.Text == "None")
                {
                    serialPort1.Parity = Parity.None;
                }
                try
                {
                    //禁止操作组件
                    comboBox_PortName.Enabled = false;
                    comboBox_BaudRate.Enabled = false;
                    comboBox_Parity.Enabled = false;
                    comboBox_StopBit.Enabled = false;
                    comboBox_Parity.Enabled = false;
                    button_search.Enabled = false;
                    //打开串口
                    serialPort1.Open();
                    button_io.Text = "关闭";      //更改按钮的文本显示

                }
                catch
                {
                    MessageBox.Show("串口打开失败！"); 
                }

                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceive);
            }
            else if (button_io.Text == "Close")
            {
                try
                {
                    //允许操作
                    comboBox_PortName.Enabled = true;
                    comboBox_BaudRate.Enabled = true;
                    comboBox_DataBit.Enabled = true;
                    comboBox_Parity.Enabled = true;
                    comboBox_StopBit.Enabled = true;
                    button_search.Enabled = true;

                    //串口关闭

                    serialPort1.DiscardInBuffer();

                    serialPort1.Close();
                    button_io.Text = "开启";      //更改按钮的文本显示

                }
                catch
                {
                    MessageBox.Show("串口打开失败！"); 
                }
            }
        }
        #endregion
        #region 接收串口数据
        List<byte> sp_buffer = new List<byte>(4096);  //串口缓存区 
        int sp_buffer_max = 4096;  //缓存区最大缓存字节
        private void SerialDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Close();
                return;
            }

            int Byte_length = serialPort1.BytesToRead; //读取缓存的数据长度
            byte[] Rc_byte = new byte[Byte_length];

            serialPort1.Read(Rc_byte, 0, Byte_length);//将缓存数据存储进字节数组里面
            if (sp_buffer.Count > sp_buffer_max)      //缓存超过字节数的时候，丢弃前面的字节
                sp_buffer.RemoveRange(0, sp_buffer_max);//丢弃0到sp_buffer_max的字节

            sp_buffer.AddRange(Rc_byte);  //存入缓存区
            byte[] ruffer = new byte[9192];  //存放缓冲区的数据流

            //对数据流进行筛选，缓冲区每一组数据个数大于4则为我们想要的数据流

            if (sp_buffer.Count > 4)
            { 
                sp_buffer.CopyTo(0,ruffer,0,sp_buffer.Count);
                Task.Run(() => printf_data(ruffer, sp_buffer.Count, 1)); //打印数据流
            }
        }

        #endregion
        #region 打印数据流
        void printf_data(byte[] Frame, int length, int T_R) //打印串口数据
        {
            Int16 i_len;
            StringBuilder s = new StringBuilder();

            if (T_R == 0)
                s.Append("发送：");
            else
                s.Append("接收：");
            for (i_len = 0; i_len < length; i_len++)  //打印字符串
            {
                s.Append(Frame[i_len].ToString("X2"));
                s.Append(" ");
            }

            s.Append("["+ DateTime.Now.ToString("HH:mm:ss fff")+"]");
            s.Append("\r\n");
            string str_show = s.ToString();
            MethodInvoker mi = new MethodInvoker(() =>
            { 
                if(richTextBox_Receive.Lines.Count() > 20)
                    richTextBox_Receive.Clear();
                richTextBox_Receive.AppendText(str_show);




            }
            
            );
            BeginInvoke(mi);

             /*
            textBox_com_data.Focus(); //获取焦点
            textBox_com_data.Select(textBox_com_data.TextLength, 0);//光标
            textBox_com_data.ScrollToCaret(); //滚动条*/

        }
        #endregion
        #region 发送数据
        private void button_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string[] sendbuff = richTextBox_Send.Text.Split();  //分割输入的字符串，判断有多少字节需要发送
                int Buff_Len = sendbuff.Length;
                Byte[] buff = new Byte[Buff_Len];
                for (int i = 0; i < sendbuff.Length; i++)
                {
                    buff[i] = byte.Parse(sendbuff[i], System.Globalization.NumberStyles.HexNumber); //格式化字符串为十六进制
                }
                try
                {
                    serialPort1.Write(buff, 0, buff.Length);  //写入数据
                    Task.Run(() => printf_data(buff, Buff_Len, 0));
                }
                catch
                {
                    MessageBox.Show("发送失败！");
                }

            }
            else
            {
                MessageBox.Show("串口未打开!");
            }
        }
        #endregion
        #region 清除数据框
        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Receive.Clear();
        }
        #endregion

    }

}
