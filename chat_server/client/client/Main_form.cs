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
        private string startup_path;

        public Main_form()
        {
            configuration conf = new configuration();
            config = conf.get_config(); // 환경설정 파일 가져오기
            startup_path = Application.StartupPath; // 프로그램 시작 경로 잡기
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (config == null)
            {
                MessageBox.Show(error.config_parse);
                Application.Exit();
            }

            try
            {
                // 화면 크기 초기화
                int x = int.Parse(config["screen_weight"].ToString());
                int y = int.Parse(config["screen_height"].ToString());
                ClientSize = new Size(x, y);
                // 첫 시작 위치 초기화
                this.Location = new Point(int.Parse(config["screen_x"].ToString()), int.Parse(config["screen_y"].ToString()));
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                MessageBox.Show(error.screen_set);
            }
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
