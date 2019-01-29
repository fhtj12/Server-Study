using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using client.parser;
using client.data;
using client.function;

namespace client
{
    public partial class Main_form : Form
    {
        public static Hashtable config = new Hashtable();
        private static error error = new error();
        public Main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configuration conf = new configuration();
            config = conf.get_config();

            if (config == null)
            {
                MessageBox.Show(error.config_parse);
                Application.Exit();
            }

            try
            {
                int x = int.Parse(config["screen_weight"].ToString());
                int y = int.Parse(config["screen_height"].ToString());
                ClientSize = new Size(x, y);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                MessageBox.Show(error.screen_set);
            }
            program_string set_str = new program_string(
                Application.StartupPath + @"\\Data\\string\\", config["language"].ToString()); // 프로그램 시작 경로와 파일 경로 합치기
            //set_str.set_string_on_screen(this); // 현재 폼의 객체 넘기기
            this.기능ToolStripMenuItem.Text = set_str.get_text("menu_function");
            this.LoginTool_StripMenuItem.Text = set_str.get_text("menu_function_login");
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChatToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccount_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditAccount_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteAccount_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AccountInfo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Config_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Version_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Dictionary_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Update_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
