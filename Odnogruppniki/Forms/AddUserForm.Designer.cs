
namespace Odnogruppniki.Forms
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_UserList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Write = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти пользователя";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(70, 80);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(184, 23);
            this.textBox_Login.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ник";
            // 
            // dataGridView_UserList
            // 
            this.dataGridView_UserList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_UserList.Location = new System.Drawing.Point(94, 155);
            this.dataGridView_UserList.MultiSelect = false;
            this.dataGridView_UserList.Name = "dataGridView_UserList";
            this.dataGridView_UserList.ReadOnly = true;
            this.dataGridView_UserList.RowHeadersVisible = false;
            this.dataGridView_UserList.RowHeadersWidth = 51;
            this.dataGridView_UserList.Size = new System.Drawing.Size(126, 252);
            this.dataGridView_UserList.TabIndex = 3;
            this.dataGridView_UserList.SelectionChanged += new System.EventHandler(this.dataGridView_UserList_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Write
            // 
            this.button_Write.Location = new System.Drawing.Point(122, 423);
            this.button_Write.Name = "button_Write";
            this.button_Write.Size = new System.Drawing.Size(75, 23);
            this.button_Write.TabIndex = 5;
            this.button_Write.Text = "Написать";
            this.button_Write.UseVisualStyleBackColor = true;
            this.button_Write.Click += new System.EventHandler(this.button_Write_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(330, 458);
            this.Controls.Add(this.button_Write);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_UserList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_UserList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Write;
    }
}
