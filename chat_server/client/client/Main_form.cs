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
using System.Threading;

using client.common;
using client.data;

namespace client
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            common_data.startup_path = Application.StartupPath; // 프로그램 시작 경로 잡기 반드시 가장 먼저 실행되어야 함.
            // 로딩으로 전환(컴포넌트 초기화도 이 안에서 진행)
            loading loading = new loading();
            loading.loading_process(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (common_data.config == null)
            {
                MessageBox.Show(common_data.error.config_parse);
                Application.Exit();
            }

            try
            {
                // 화면 크기 초기화
                int x = int.Parse(common_data.config["screen_weight"].ToString());
                int y = int.Parse(common_data.config["screen_height"].ToString());
                ClientSize = new Size(x, y);
                // 첫 시작 위치 초기화
                this.Location = new Point
                    (int.Parse(common_data.config["screen_x"].ToString()), int.Parse(common_data.config["screen_y"].ToString()));
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                MessageBox.Show(common_data.error.screen_set);
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
            Config_Form cf = new Config_Form();
            cf.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void Version_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(common_data.basic_str.get_text("system_version_string") + " : " + common_data.basic_str.get_text("program_version"));
        }

        private void Help_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("도움말");
        }

        private void Update_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
