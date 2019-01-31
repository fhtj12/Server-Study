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
        public void InitializeComponent()
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
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Version_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기능ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.ViewToolStripMenuItem});
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
            this.기능ToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.기능ToolStripMenuItem.Text = "기능";
            // 
            // LoginTool_StripMenuItem
            // 
            this.LoginTool_StripMenuItem.Name = "LoginTool_StripMenuItem";
            this.LoginTool_StripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.LoginTool_StripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            this.LoginTool_StripMenuItem.Text = "로그인";
            // 
            // Chat_ToolStripMenuItem1
            // 
            this.Chat_ToolStripMenuItem1.Name = "Chat_ToolStripMenuItem1";
            this.Chat_ToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            this.Chat_ToolStripMenuItem1.Click += new System.EventHandler(this.ChatToolStripMenuItem1_Click);
            this.Chat_ToolStripMenuItem1.Text = "대화 시작";
            // 
            // Update_ToolStripMenuItem
            // 
            this.Update_ToolStripMenuItem.Name = "Update_ToolStripMenuItem";
            this.Update_ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.Update_ToolStripMenuItem.Click += new System.EventHandler(this.Update_ToolStripMenuItem_Click);
            this.Update_ToolStripMenuItem.Text = "업데이트";
            // 
            // ExitTool_StripMenuItem
            // 
            this.ExitTool_StripMenuItem.Name = "ExitTool_StripMenuItem";
            this.ExitTool_StripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.ExitTool_StripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            this.ExitTool_StripMenuItem.Text = "종료";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateAccount_ToolStripMenuItem,
            this.EditAccount_ToolStripMenuItem,
            this.DeleteAccount_ToolStripMenuItem,
            this.AccountInfo_ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.보기ToolStripMenuItem.Text = "계정";
            // 
            // CreateAccount_ToolStripMenuItem
            // 
            this.CreateAccount_ToolStripMenuItem.Name = "CreateAccount_ToolStripMenuItem";
            this.CreateAccount_ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.CreateAccount_ToolStripMenuItem.Click += new System.EventHandler(this.CreateAccount_ToolStripMenuItem_Click);
            this.CreateAccount_ToolStripMenuItem.Text = "회원 가입";
            // 
            // EditAccount_ToolStripMenuItem
            // 
            this.EditAccount_ToolStripMenuItem.Name = "EditAccount_ToolStripMenuItem";
            this.EditAccount_ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.EditAccount_ToolStripMenuItem.Click += new System.EventHandler(this.EditAccount_ToolStripMenuItem_Click);
            this.EditAccount_ToolStripMenuItem.Text = "회원 정보 수정";
            // 
            // DeleteAccount_ToolStripMenuItem
            // 
            this.DeleteAccount_ToolStripMenuItem.Name = "DeleteAccount_ToolStripMenuItem";
            this.DeleteAccount_ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.DeleteAccount_ToolStripMenuItem.Click += new System.EventHandler(this.DeleteAccount_ToolStripMenuItem_Click);
            this.DeleteAccount_ToolStripMenuItem.Text = "회원 탈퇴";
            // 
            // AccountInfo_ToolStripMenuItem
            // 
            this.AccountInfo_ToolStripMenuItem.Name = "AccountInfo_ToolStripMenuItem";
            this.AccountInfo_ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.AccountInfo_ToolStripMenuItem.Click += new System.EventHandler(this.AccountInfo_ToolStripMenuItem_Click);
            this.AccountInfo_ToolStripMenuItem.Text = "현재 회원 정보";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Config_ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // Config_ToolStripMenuItem
            // 
            this.Config_ToolStripMenuItem.Name = "Config_ToolStripMenuItem";
            this.Config_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Config_ToolStripMenuItem.Click += new System.EventHandler(this.Config_ToolStripMenuItem_Click);
            this.Config_ToolStripMenuItem.Text = "환경설정";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Version_ToolStripMenuItem,
            this.Help_ToolStripMenuItem1});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.ViewToolStripMenuItem.Text = "보기";
            // 
            // Version_ToolStripMenuItem
            // 
            this.Version_ToolStripMenuItem.Name = "Version_ToolStripMenuItem";
            this.Version_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Version_ToolStripMenuItem.Click += new System.EventHandler(this.Version_ToolStripMenuItem_Click);
            this.Version_ToolStripMenuItem.Text = "버전 정보";
            // 
            // Help_ToolStripMenuItem1
            // 
            this.Help_ToolStripMenuItem1.Name = "Help_ToolStripMenuItem1";
            this.Help_ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.Help_ToolStripMenuItem1.Click += new System.EventHandler(this.Help_ToolStripMenuItem1_Click);
            this.Help_ToolStripMenuItem1.Text = "도움말";
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
            this.Text = "오터 챗";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 기능ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem LoginTool_StripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Chat_ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem EditAccount_ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ExitTool_StripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem CreateAccount_ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem DeleteAccount_ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem AccountInfo_ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Config_ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Version_ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Help_ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem Update_ToolStripMenuItem;
    }
}

