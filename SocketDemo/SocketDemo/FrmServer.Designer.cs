namespace SocketServer
{
    partial class FrmServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_StopListen = new System.Windows.Forms.Button();
            this.cmb_Socket = new System.Windows.Forms.ComboBox();
            this.txt_Log = new System.Windows.Forms.RichTextBox();
            this.txt_Msg = new System.Windows.Forms.RichTextBox();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(29, 13);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(146, 21);
            this.txt_IP.TabIndex = 0;
            this.txt_IP.Text = "127.0.0.1";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(198, 13);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(83, 21);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "2000";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(306, 11);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "开始监听";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_StopListen
            // 
            this.btn_StopListen.Location = new System.Drawing.Point(387, 11);
            this.btn_StopListen.Name = "btn_StopListen";
            this.btn_StopListen.Size = new System.Drawing.Size(75, 23);
            this.btn_StopListen.TabIndex = 3;
            this.btn_StopListen.Text = "停止监听";
            this.btn_StopListen.UseVisualStyleBackColor = true;
            this.btn_StopListen.Click += new System.EventHandler(this.btn_StopListen_Click);
            // 
            // cmb_Socket
            // 
            this.cmb_Socket.FormattingEnabled = true;
            this.cmb_Socket.Location = new System.Drawing.Point(513, 13);
            this.cmb_Socket.Name = "cmb_Socket";
            this.cmb_Socket.Size = new System.Drawing.Size(184, 20);
            this.cmb_Socket.TabIndex = 4;
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(29, 40);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(563, 222);
            this.txt_Log.TabIndex = 5;
            this.txt_Log.Text = "";
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(29, 279);
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(563, 97);
            this.txt_Msg.TabIndex = 6;
            this.txt_Msg.Text = "";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(29, 383);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(433, 21);
            this.txt_FilePath.TabIndex = 7;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(468, 383);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(55, 23);
            this.btn_Select.TabIndex = 8;
            this.btn_Select.Text = "选择";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(529, 383);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(63, 23);
            this.btn_SendFile.TabIndex = 9;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(598, 279);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(78, 44);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.cmb_Socket);
            this.Controls.Add(this.btn_StopListen);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Name = "FrmServer";
            this.Text = "服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_StopListen;
        private System.Windows.Forms.ComboBox cmb_Socket;
        private System.Windows.Forms.RichTextBox txt_Log;
        private System.Windows.Forms.RichTextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_Send;
    }
}

