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

using client.data;
using client.function;
using client.common;

namespace client
{
    public partial class Loading_Form : Form
    {
        delegate void StringParameterDelegate(string text);
        delegate void StringParameterWithStatusDelegate(string text, Status status);
        delegate void ShowCloseDelegate();

        bool close_loading_screen_flag = false;

        public Loading_Form()
        {
            InitializeComponent();

            // 배경 이미지 추가
            pictureBox1.Image = System.Drawing.Image.FromFile(common_data.startup_path + common_data.resource_Path.get_path("file_loading_image_path"));

            // 라벨 색상 추가 및 문자열 세팅
            label1.ForeColor = Color.Green;
            label1.Text = common_data.basic_str.get_text("system_loading");
            label2.Text = common_data.basic_str.get_text("program_name");
            label3.Text = common_data.basic_str.get_text("program_version");
        }

        // 로딩창 실행
        public void show_form()
        {
            if(InvokeRequired)
            {
                BeginInvoke(new ShowCloseDelegate(show_form));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        // 로딩창 닫기
        public void close_form()
        {
            if(InvokeRequired)
            {
                BeginInvoke(new ShowCloseDelegate(close_form));
                return;
            }
            close_loading_screen_flag = true;
            this.Close();
        }

        // 상태 문자열 변경
        public void update_status_text(string text)
        {
            if(InvokeRequired)
            {
                BeginInvoke(new StringParameterDelegate(update_status_text), new object[] { text });
                return;
            }
            label1.ForeColor = Color.Green;
            label1.Text = text;
        }

        // 현재 상태에 따라 문자열 변경
        public void update_status_text_with_status(string text, Status status)
        {
            if(InvokeRequired)
            {
                BeginInvoke(new StringParameterWithStatusDelegate(update_status_text_with_status), new object[] { text, status });
                return;
            }

            switch(status)
            {
                case Status.Error:
                    label1.ForeColor = Color.Red;
                    break;
                case Status.Warning:
                    label1.ForeColor = Color.Yellow;
                    break;
                case Status.Success:
                    label1.ForeColor = Color.Green;
                    break;
            }

            label1.Text = text;
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            if(close_loading_screen_flag == false)
            {
                e.Cancel = true;
            }
        }
    }
}
