namespace remote_control_client
{
    partial class form_remote_control_client
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_list_servers = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_log = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tp_sent_message = new System.Windows.Forms.TabPage();
            this.b_sent_message = new System.Windows.Forms.Button();
            this.tb_text_message = new System.Windows.Forms.TextBox();
            this.l_text_message_sent_message = new System.Windows.Forms.Label();
            this.tb_caption_message = new System.Windows.Forms.TextBox();
            this.l_caption_sent_message = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.TabPage();
            this.b_screenshot = new System.Windows.Forms.Button();
            this.b_check = new System.Windows.Forms.Button();
            this.b_primary_internet = new System.Windows.Forms.Button();
            this.b_reserve_internet = new System.Windows.Forms.Button();
            this.b_update_server = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_operation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_open_log = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_sent_message.SuspendLayout();
            this.other.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_list_servers
            // 
            this.lb_list_servers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_list_servers.FormattingEnabled = true;
            this.lb_list_servers.Items.AddRange(new object[] {
            "Сиваторов (192.168.8.103)",
            "Кучеря (192.168.8.192)",
            "Бух. Окно (192.168.8.102)",
            "Лукьянцева (192.168.8.22)",
            "Шуникова ноут (192.168.8.180)",
            "Аненко (192.168.8.5)"});
            this.lb_list_servers.Location = new System.Drawing.Point(13, 39);
            this.lb_list_servers.Name = "lb_list_servers";
            this.lb_list_servers.Size = new System.Drawing.Size(182, 381);
            this.lb_list_servers.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lb_log
            // 
            this.lb_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_log.FormattingEnabled = true;
            this.lb_log.Location = new System.Drawing.Point(201, 325);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(379, 95);
            this.lb_log.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tp_sent_message);
            this.tabControl1.Controls.Add(this.other);
            this.tabControl1.Location = new System.Drawing.Point(201, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 292);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(371, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tp_sent_message
            // 
            this.tp_sent_message.Controls.Add(this.b_sent_message);
            this.tp_sent_message.Controls.Add(this.tb_text_message);
            this.tp_sent_message.Controls.Add(this.l_text_message_sent_message);
            this.tp_sent_message.Controls.Add(this.tb_caption_message);
            this.tp_sent_message.Controls.Add(this.l_caption_sent_message);
            this.tp_sent_message.Location = new System.Drawing.Point(4, 22);
            this.tp_sent_message.Name = "tp_sent_message";
            this.tp_sent_message.Padding = new System.Windows.Forms.Padding(3);
            this.tp_sent_message.Size = new System.Drawing.Size(371, 266);
            this.tp_sent_message.TabIndex = 1;
            this.tp_sent_message.Text = "Отправить сообщение";
            this.tp_sent_message.UseVisualStyleBackColor = true;
            // 
            // b_sent_message
            // 
            this.b_sent_message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_sent_message.Location = new System.Drawing.Point(290, 237);
            this.b_sent_message.Name = "b_sent_message";
            this.b_sent_message.Size = new System.Drawing.Size(75, 23);
            this.b_sent_message.TabIndex = 4;
            this.b_sent_message.Text = "Отправить";
            this.b_sent_message.UseVisualStyleBackColor = true;
            this.b_sent_message.Click += new System.EventHandler(this.b_sent_message_Click);
            // 
            // tb_text_message
            // 
            this.tb_text_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_text_message.Location = new System.Drawing.Point(10, 68);
            this.tb_text_message.Multiline = true;
            this.tb_text_message.Name = "tb_text_message";
            this.tb_text_message.Size = new System.Drawing.Size(355, 163);
            this.tb_text_message.TabIndex = 3;
            // 
            // l_text_message_sent_message
            // 
            this.l_text_message_sent_message.AutoSize = true;
            this.l_text_message_sent_message.Location = new System.Drawing.Point(10, 51);
            this.l_text_message_sent_message.Name = "l_text_message_sent_message";
            this.l_text_message_sent_message.Size = new System.Drawing.Size(68, 13);
            this.l_text_message_sent_message.TabIndex = 2;
            this.l_text_message_sent_message.Text = "Сообщение:";
            // 
            // tb_caption_message
            // 
            this.tb_caption_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_caption_message.Location = new System.Drawing.Point(10, 24);
            this.tb_caption_message.Name = "tb_caption_message";
            this.tb_caption_message.Size = new System.Drawing.Size(416, 20);
            this.tb_caption_message.TabIndex = 1;
            // 
            // l_caption_sent_message
            // 
            this.l_caption_sent_message.AutoSize = true;
            this.l_caption_sent_message.Location = new System.Drawing.Point(7, 7);
            this.l_caption_sent_message.Name = "l_caption_sent_message";
            this.l_caption_sent_message.Size = new System.Drawing.Size(64, 13);
            this.l_caption_sent_message.TabIndex = 0;
            this.l_caption_sent_message.Text = "Заголовок:";
            // 
            // other
            // 
            this.other.Controls.Add(this.b_screenshot);
            this.other.Controls.Add(this.b_check);
            this.other.Controls.Add(this.b_primary_internet);
            this.other.Controls.Add(this.b_reserve_internet);
            this.other.Controls.Add(this.b_update_server);
            this.other.Location = new System.Drawing.Point(4, 22);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(371, 266);
            this.other.TabIndex = 2;
            this.other.Text = "Разное";
            this.other.UseVisualStyleBackColor = true;
            // 
            // b_screenshot
            // 
            this.b_screenshot.Location = new System.Drawing.Point(85, 33);
            this.b_screenshot.Name = "b_screenshot";
            this.b_screenshot.Size = new System.Drawing.Size(75, 23);
            this.b_screenshot.TabIndex = 4;
            this.b_screenshot.Text = "Скриншот";
            this.b_screenshot.UseVisualStyleBackColor = true;
            this.b_screenshot.Click += new System.EventHandler(this.b_screenshot_Click);
            // 
            // b_check
            // 
            this.b_check.Location = new System.Drawing.Point(4, 33);
            this.b_check.Name = "b_check";
            this.b_check.Size = new System.Drawing.Size(75, 23);
            this.b_check.TabIndex = 3;
            this.b_check.Text = "Проверить";
            this.b_check.UseVisualStyleBackColor = true;
            this.b_check.Click += new System.EventHandler(this.b_check_Click);
            // 
            // b_primary_internet
            // 
            this.b_primary_internet.Location = new System.Drawing.Point(220, 4);
            this.b_primary_internet.Name = "b_primary_internet";
            this.b_primary_internet.Size = new System.Drawing.Size(127, 23);
            this.b_primary_internet.TabIndex = 2;
            this.b_primary_internet.Text = "Основной интернет";
            this.b_primary_internet.UseVisualStyleBackColor = true;
            this.b_primary_internet.Click += new System.EventHandler(this.b_primary_internet_Click);
            // 
            // b_reserve_internet
            // 
            this.b_reserve_internet.Location = new System.Drawing.Point(85, 4);
            this.b_reserve_internet.Name = "b_reserve_internet";
            this.b_reserve_internet.Size = new System.Drawing.Size(129, 23);
            this.b_reserve_internet.TabIndex = 1;
            this.b_reserve_internet.Text = "Резервный интернет";
            this.b_reserve_internet.UseVisualStyleBackColor = true;
            this.b_reserve_internet.Click += new System.EventHandler(this.b_reserve_internet_Click);
            // 
            // b_update_server
            // 
            this.b_update_server.Location = new System.Drawing.Point(4, 4);
            this.b_update_server.Name = "b_update_server";
            this.b_update_server.Size = new System.Drawing.Size(75, 23);
            this.b_update_server.TabIndex = 0;
            this.b_update_server.Text = "Обновить";
            this.b_update_server.UseVisualStyleBackColor = true;
            this.b_update_server.Click += new System.EventHandler(this.b_update_server_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_operation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_operation
            // 
            this.tsmi_operation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_open_log});
            this.tsmi_operation.Name = "tsmi_operation";
            this.tsmi_operation.Size = new System.Drawing.Size(69, 20);
            this.tsmi_operation.Text = "Операции";
            // 
            // tsmi_open_log
            // 
            this.tsmi_open_log.Name = "tsmi_open_log";
            this.tsmi_open_log.Size = new System.Drawing.Size(151, 22);
            this.tsmi_open_log.Text = "Открыть лог";
            this.tsmi_open_log.Click += new System.EventHandler(this.tsmi_open_log_Click);
            // 
            // form_remote_control_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lb_list_servers);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "form_remote_control_client";
            this.Text = "Remote Control Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_remote_control_client_FormClosing);
            this.Load += new System.EventHandler(this.form_remote_control_client_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_sent_message.ResumeLayout(false);
            this.tp_sent_message.PerformLayout();
            this.other.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_list_servers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox lb_log;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tp_sent_message;
        private System.Windows.Forms.Button b_sent_message;
        private System.Windows.Forms.TextBox tb_text_message;
        private System.Windows.Forms.Label l_text_message_sent_message;
        private System.Windows.Forms.TextBox tb_caption_message;
        private System.Windows.Forms.Label l_caption_sent_message;
        private System.Windows.Forms.TabPage other;
        private System.Windows.Forms.Button b_update_server;
        private System.Windows.Forms.Button b_primary_internet;
        private System.Windows.Forms.Button b_reserve_internet;
        private System.Windows.Forms.Button b_check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_operation;
        private System.Windows.Forms.ToolStripMenuItem tsmi_open_log;
        private System.Windows.Forms.Button b_screenshot;

    }
}

