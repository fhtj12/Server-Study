using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

using client.data;
using client.function;

namespace client.common
{
    class loading
    {
        public void loading_process(Main_form main)
        {
            string status_string = null;

            #region Loading Form 사용을 위한 전처리
            int sleep_time = 500; // 시간 설정
            Thread loading_thread = new Thread(new ThreadStart(loading_screen.show_form));
            loading_thread.IsBackground = true;
            loading_thread.Start();
            #endregion

            #region Initializing Data
            // 반드시 컴포넌트 초기화 이전에 넣어야만 함.
            configuration conf = new configuration();
            common_data.config = conf.get_config(); // 환경설정 파일 가져오기
            // 기획 데이터 문자열 가져오기
            common_data.basic_str = new program_string(common_data.startup_path + @"\\Data\\string\\", common_data.config["language"].ToString());
            common_data.resource_Path = new resource_path(); // 리소스 경로 가져오기

            Thread.Sleep(sleep_time);
            loading_screen.update_status_text(status_string);

            // 각 로딩 때 해야할 것들을 이 안에 넣으면 됨.
            try
            {
                // 상태 문자열 실제 변경하는 곳
                status_string = common_data.basic_str.get_text("system_loading_initializing_data");
                // 컴포넌트 초기화
                main.InitializeComponent();
                // 문자열 초기화
                main.Text = common_data.basic_str.get_text("program_name");
                main.기능ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_function");
                main.LoginTool_StripMenuItem.Text = common_data.basic_str.get_text("menu_function_login");
                main.Chat_ToolStripMenuItem1.Text = common_data.basic_str.get_text("menu_function_chat");
                main.Update_ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_function_update");
                main.ExitTool_StripMenuItem.Text = common_data.basic_str.get_text("menu_function_exit");
                main.보기ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_account");
                main.CreateAccount_ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_account_create");
                main.EditAccount_ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_account_update");
                main.DeleteAccount_ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_account_delete");
                main.AccountInfo_ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_account_info");
                main.설정ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_config");
                main.Config_ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_config_config");
                main.ViewToolStripMenuItem.Text = common_data.basic_str.get_text("menu_view");
                main.Version_ToolStripMenuItem.Text = common_data.basic_str.get_text("menu_view_version");
                main.Help_ToolStripMenuItem1.Text = common_data.basic_str.get_text("menu_view_help");

                Thread.Sleep(sleep_time);
                loading_screen.update_status_text_with_status(status_string + "OK", Status.Success);
                Thread.Sleep(sleep_time);
            }
            catch (Exception e)
            {
                loading_screen.update_status_text_with_status(status_string + "Fail", Status.Error);
                Thread.Sleep(sleep_time);
                Console.Write(e.Message);
                Environment.Exit(0);
            }
            #endregion

            #region Loading Resources
            status_string = common_data.basic_str.get_text("system_loading_loading_resources");
            Thread.Sleep(sleep_time);
            loading_screen.update_status_text(status_string);

            try
            {
                Thread.Sleep(sleep_time);
                loading_screen.update_status_text_with_status(status_string + "OK", Status.Success);
                Thread.Sleep(sleep_time);
            }
            catch (Exception e)
            {
                loading_screen.update_status_text_with_status(status_string + "Fail", Status.Error);
                Thread.Sleep(sleep_time);
                Console.Write(e.Message);
                Environment.Exit(0);
            }
            #endregion

            #region Connecting to Server
            status_string = common_data.basic_str.get_text("system_loading_connecting_server");
            Thread.Sleep(sleep_time);
            loading_screen.update_status_text(common_data.basic_str.get_text("system_loading_connecting_server"));

            try
            {
                Thread.Sleep(sleep_time);
                loading_screen.update_status_text_with_status(status_string + "OK", Status.Success);
                Thread.Sleep(sleep_time);
            }
            catch (Exception e)
            {
                loading_screen.update_status_text_with_status(status_string + "Fail", Status.Error);
                Thread.Sleep(sleep_time);
                Console.Write(e.Message);
                Environment.Exit(0);
            }
            #endregion

            loading_screen.close_form();
        }
    }
}
