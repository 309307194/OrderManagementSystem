using MySql.Data.MySqlClient;
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
    public partial class UserLoginInfoAdd : Form
    {
        public UserLoginInfoAdd()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 增加信息按钮代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisteredAccountButton_Click(object sender, EventArgs e)
        {
            //1.定义变量接收一下
            int id = Convert.ToInt32(textBoxUserId.Text.Trim());  //去两边的空格
            String password = textBoxPassWord.Text.Trim();
            String name = textBoxName.Text.Trim();
            String gender = radioButtonMale.Checked ? "男" : "女";
            int age = Convert.ToInt32(numericUpDownAge.Value);
            String birthday = dateTimePickerBirthDay.Value.ToString();
            String address = textBoxAddress.Text.Trim();

            //string sql = String.Format("insert UserInfo(ID,PassWd,Name,Gender,Age,BirthDay,Address) values('309307194','strPassword','小王','男','30','1990-09-07','江苏省苏州市万枫家园')");
            string sql = String.Format("insert UserInfo(ID,PassWd,Name,Gender,Age,BirthDay,Address) values('{0}','{1}','{2}','{3}',{4},'{5}','{6}')",id, password, name,gender, age, birthday, address);
            //连接字符串
            String conStr = "server=139.196.226.165;port=3306;database=test;uid=admin;pwd=admin;Charset=utf8";
            MySqlConnection conn = new MySqlConnection(conStr);
            conn.Open();
            MySqlCommand comm = new MySqlCommand(sql, conn);
            int result = comm.ExecuteNonQuery();
            if(result > 0)
            {
                MessageBox.Show("AddSuccess");
            }
            else
            {
                MessageBox.Show("AddFail");
            }

        }
    }
}
