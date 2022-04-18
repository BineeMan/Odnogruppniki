
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
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._903a1_chatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChatList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "одногруппники";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 67);
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
            this.dataGridView_ChatList.Location = new System.Drawing.Point(30, 150);
            this.dataGridView_ChatList.MultiSelect = false;
            this.dataGridView_ChatList.Name = "dataGridView_ChatList";
            this.dataGridView_ChatList.ReadOnly = true;
            this.dataGridView_ChatList.RowHeadersVisible = false;
            this.dataGridView_ChatList.RowHeadersWidth = 51;
            this.dataGridView_ChatList.Size = new System.Drawing.Size(145, 467);
            this.dataGridView_ChatList.TabIndex = 2;
            this.dataGridView_ChatList.SelectionChanged += new System.EventHandler(this.dataGridView_ChatList_SelectionChanged);
            // 
            // textBox_ChatWindow
            // 
            this.textBox_ChatWindow.Location = new System.Drawing.Point(251, 150);
            this.textBox_ChatWindow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_ChatWindow.Multiline = true;
            this.textBox_ChatWindow.Name = "textBox_ChatWindow";
            this.textBox_ChatWindow.ReadOnly = true;
            this.textBox_ChatWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ChatWindow.Size = new System.Drawing.Size(569, 380);
            this.textBox_ChatWindow.TabIndex = 3;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(251, 546);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(79, 71);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "Отправить";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(352, 546);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(468, 71);
            this.textBox_Message.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // ChatMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(909, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.dataGridView_ChatList);
            this.Controls.Add(this.textBox_ChatWindow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}
