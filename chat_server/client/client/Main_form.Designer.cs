using client.data;
namespace client
{
    partial class Main_form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginTool_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Chat_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Update_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTool_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateAccount_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAccount_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAccount_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountInfo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Config_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Version_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dictionary_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            //
            // 프로그램 시작 경로와 파일 경로 합치기
            //
            program_string set_str = new program_string(startup_path + @"\\Data\\string\\", config["language"].ToString());

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기능ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 기능ToolStripMenuItem
            // 
            this.기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginTool_StripMenuItem,
            this.Chat_ToolStripMenuItem1,
            this.Update_ToolStripMenuItem,
            this.ExitTool_StripMenuItem});
            this.기능ToolStripMenuItem.Name = "기능ToolStripMenuItem";
            this.기능ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.기능ToolStripMenuItem.Text = set_str.get_text("menu_function");
            // 
            // LoginTool_StripMenuItem
            // 
            this.LoginTool_StripMenuItem.Name = "LoginTool_StripMenuItem";
            this.LoginTool_StripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoginTool_StripMenuItem.Text = set_str.get_text("menu_function_login");
            this.LoginTool_StripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // Chat_ToolStripMenuItem1
            // 
            this.Chat_ToolStripMenuItem1.Name = "Chat_ToolStripMenuItem1";
            this.Chat_ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.Chat_ToolStripMenuItem1.Text = set_str.get_text("menu_function_chat");
            this.Chat_ToolStripMenuItem1.Click += new System.EventHandler(this.ChatToolStripMenuItem1_Click);
            // 
            // Update_ToolStripMenuItem
            // 
            this.Update_ToolStripMenuItem.Name = "Update_ToolStripMenuItem";
            this.Update_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Update_ToolStripMenuItem.Text = set_str.get_text("menu_function_update");
            this.Update_ToolStripMenuItem.Click += new System.EventHandler(this.Update_ToolStripMenuItem_Click);
            // 
            // ExitTool_StripMenuItem
            // 
            this.ExitTool_StripMenuItem.Name = "ExitTool_StripMenuItem";
            this.ExitTool_StripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitTool_StripMenuItem.Text = set_str.get_text("menu_function_exit");
            this.ExitTool_StripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateAccount_ToolStripMenuItem,
            this.EditAccount_ToolStripMenuItem,
            this.DeleteAccount_ToolStripMenuItem,
            this.AccountInfo_ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = set_str.get_text("menu_account");
            // 
            // CreateAccount_ToolStripMenuItem
            // 
            this.CreateAccount_ToolStripMenuItem.Name = "CreateAccount_ToolStripMenuItem";
            this.CreateAccount_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.CreateAccount_ToolStripMenuItem.Text = set_str.get_text("menu_account_create");
            this.CreateAccount_ToolStripMenuItem.Click += new System.EventHandler(this.CreateAccount_ToolStripMenuItem_Click);
            // 
            // EditAccount_ToolStripMenuItem
            // 
            this.EditAccount_ToolStripMenuItem.Name = "EditAccount_ToolStripMenuItem";
            this.EditAccount_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditAccount_ToolStripMenuItem.Text = set_str.get_text("menu_account_update");
            this.EditAccount_ToolStripMenuItem.Click += new System.EventHandler(this.EditAccount_ToolStripMenuItem_Click);
            // 
            // DeleteAccount_ToolStripMenuItem
            // 
            this.DeleteAccount_ToolStripMenuItem.Name = "DeleteAccount_ToolStripMenuItem";
            this.DeleteAccount_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DeleteAccount_ToolStripMenuItem.Text = set_str.get_text("menu_account_delete");
            this.DeleteAccount_ToolStripMenuItem.Click += new System.EventHandler(this.DeleteAccount_ToolStripMenuItem_Click);
            // 
            // AccountInfo_ToolStripMenuItem
            // 
            this.AccountInfo_ToolStripMenuItem.Name = "AccountInfo_ToolStripMenuItem";
            this.AccountInfo_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AccountInfo_ToolStripMenuItem.Text = set_str.get_text("menu_account_info");
            this.AccountInfo_ToolStripMenuItem.Click += new System.EventHandler(this.AccountInfo_ToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Config_ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = set_str.get_text("menu_config");
            // 
            // Config_ToolStripMenuItem
            // 
            this.Config_ToolStripMenuItem.Name = "Config_ToolStripMenuItem";
            this.Config_ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.Config_ToolStripMenuItem.Text = set_str.get_text("menu_config_config");
            this.Config_ToolStripMenuItem.Click += new System.EventHandler(this.Config_ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Version_ToolStripMenuItem,
            this.Dictionary_ToolStripMenuItem1});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도움말ToolStripMenuItem.Text = set_str.get_text("menu_view");
            // 
            // Version_ToolStripMenuItem
            // 
            this.Version_ToolStripMenuItem.Name = "Version_ToolStripMenuItem";
            this.Version_ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.Version_ToolStripMenuItem.Text = set_str.get_text("menu_view_version");
            this.Version_ToolStripMenuItem.Click += new System.EventHandler(this.Version_ToolStripMenuItem_Click);
            // 
            // Dictionary_ToolStripMenuItem1
            // 
            this.Dictionary_ToolStripMenuItem1.Name = "Dictionary_ToolStripMenuItem1";
            this.Dictionary_ToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.Dictionary_ToolStripMenuItem1.Text = set_str.get_text("menu_view_help");
            this.Dictionary_ToolStripMenuItem1.Click += new System.EventHandler(this.Dictionary_ToolStripMenuItem1_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = set_str.get_text("program_name");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginTool_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Chat_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditAccount_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitTool_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateAccount_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAccount_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountInfo_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Config_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Version_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dictionary_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Update_ToolStripMenuItem;
    }
}

