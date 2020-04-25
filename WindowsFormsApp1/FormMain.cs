﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButtonContionDB_Click(object sender, EventArgs e)
        {
            //数据库的连接测试
            //1.定义数据库连接字符串
            string url = "server=139.196.226.165;port=3306;database=test;uid=admin;pwd=admin";
            //2.创建数据库连接对象
            MySqlConnection con = new MySqlConnection(url);
            //3.打开连接
            con.Open();
            MessageBox.Show("数据库连接成功");
            con.Close();

        }
    }
}
