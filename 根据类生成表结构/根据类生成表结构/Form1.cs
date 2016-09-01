using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace 根据类生成表结构
{
    public partial class Form1 : Form
    {
        //获取连接字符串
        public string conn=ConfigurationManager.ConnectionStrings["Conn"].ConnectionString.ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(this.conn))
            {
                try
                {
                    conn.Open();
                    label1.Text = "连接成功";
                }
                catch
                {
                    label1.Text = "连接失败";
                }
            }
        }

    }
}
