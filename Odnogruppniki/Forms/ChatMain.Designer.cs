
namespace Odnogruppniki
{
    partial class ChatMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatMain));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._903a1_chatDataSet = new Odnogruppniki._903a1_chatDataSet();
            this.chatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chatTableAdapter = new Odnogruppniki._903a1_chatDataSetTableAdapters.ChatTableAdapter();
            this.dataGridView_ChatList = new System.Windows.Forms.DataGridView();
            this.textBox_ChatWindow = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Nickname = new System.Windows.Forms.Label();
            this.label_ConpanionStatus = new System.Windows.Forms.Label();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_AddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._903a1_chatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChatList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(910, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Одногруппники";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1142, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // _903a1_chatDataSet
            // 
            this._903a1_chatDataSet.DataSetName = "_903a1_chatDataSet";
            this._903a1_chatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chatBindingSource
            // 
            this.chatBindingSource.DataMember = "Chat";
            this.chatBindingSource.DataSource = this._903a1_chatDataSet;
            // 
            // chatTableAdapter
            // 
            this.chatTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_ChatList
            // 
            this.dataGridView_ChatList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_ChatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChatList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_ChatList.Location = new System.Drawing.Point(39, 178);
            this.dataGridView_ChatList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_ChatList.MultiSelect = false;
            this.dataGridView_ChatList.Name = "dataGridView_ChatList";
            this.dataGridView_ChatList.ReadOnly = true;
            this.dataGridView_ChatList.RowHeadersVisible = false;
            this.dataGridView_ChatList.RowHeadersWidth = 51;
            this.dataGridView_ChatList.Size = new System.Drawing.Size(186, 555);
            this.dataGridView_ChatList.TabIndex = 2;
            this.dataGridView_ChatList.SelectionChanged += new System.EventHandler(this.dataGridView_ChatList_SelectionChanged);
            // 
            // textBox_ChatWindow
            // 
            this.textBox_ChatWindow.Location = new System.Drawing.Point(323, 178);
            this.textBox_ChatWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ChatWindow.Multiline = true;
            this.textBox_ChatWindow.Name = "textBox_ChatWindow";
            this.textBox_ChatWindow.ReadOnly = true;
            this.textBox_ChatWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ChatWindow.Size = new System.Drawing.Size(730, 450);
            this.textBox_ChatWindow.TabIndex = 3;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(323, 648);
            this.button_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(102, 84);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "Отправить";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(453, 648);
            this.textBox_Message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(601, 84);
            this.textBox_Message.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Nickname
            // 
            this.label_Nickname.AutoSize = true;
            this.label_Nickname.Location = new System.Drawing.Point(603, 99);
            this.label_Nickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nickname.Name = "label_Nickname";
            this.label_Nickname.Size = new System.Drawing.Size(54, 21);
            this.label_Nickname.TabIndex = 8;
            this.label_Nickname.Text = "label4";
            this.label_Nickname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_ConpanionStatus
            // 
            this.label_ConpanionStatus.AutoSize = true;
            this.label_ConpanionStatus.Location = new System.Drawing.Point(521, 135);
            this.label_ConpanionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ConpanionStatus.Name = "label_ConpanionStatus";
            this.label_ConpanionStatus.Size = new System.Drawing.Size(54, 21);
            this.label_ConpanionStatus.TabIndex = 9;
            this.label_ConpanionStatus.Text = "label4";
            this.label_ConpanionStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_LogOut
            // 
            this.button_LogOut.Location = new System.Drawing.Point(1099, 743);
            this.button_LogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(96, 27);
            this.button_LogOut.TabIndex = 10;
            this.button_LogOut.Text = "Выход";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_AddUser
            // 
            this.button_AddUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddUser.Location = new System.Drawing.Point(1086, 233);
            this.button_AddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(122, 48);
            this.button_AddUser.TabIndex = 11;
            this.button_AddUser.Text = "Добавить пользователя";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // ChatMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(1224, 785);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.button_LogOut);
            this.Controls.Add(this.label_ConpanionStatus);
            this.Controls.Add(this.label_Nickname);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.dataGridView_ChatList);
            this.Controls.Add(this.textBox_ChatWindow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatMain";
            this.Text = "ChatMain";
            this.Load += new System.EventHandler(this.ChatMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._903a1_chatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChatList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _903a1_chatDataSet _903a1_chatDataSet;
        private System.Windows.Forms.BindingSource chatBindingSource;
        private _903a1_chatDataSetTableAdapters.ChatTableAdapter chatTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_ChatList;
        private System.Windows.Forms.TextBox textBox_ChatWindow;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Nickname;
        private System.Windows.Forms.Label label_ConpanionStatus;
        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Button button_AddUser;
    }
}
