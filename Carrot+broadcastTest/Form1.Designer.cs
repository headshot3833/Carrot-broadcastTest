namespace Carrot_broadcastTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DeleteFromDb = new Button();
            UpdateDbData = new Button();
            SaveDb = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            FilterButton = new Button();
            MailBox = new TextBox();
            GetDataApi = new Button();
            LastNameBox = new TextBox();
            FirstNameBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CityBox = new TextBox();
            label8 = new Label();
            CountryBox = new TextBox();
            label9 = new Label();
            StateBox = new TextBox();
            FilterBox = new TextBox();
            updateUser = new Button();
            CheckFilterDate = new CheckBox();
            CheckFilterName = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteFromDb
            // 
            DeleteFromDb.Location = new Point(659, 395);
            DeleteFromDb.Name = "DeleteFromDb";
            DeleteFromDb.Size = new Size(156, 29);
            DeleteFromDb.TabIndex = 0;
            DeleteFromDb.Text = "Удаление";
            DeleteFromDb.UseVisualStyleBackColor = true;
            DeleteFromDb.Click += DeleteFromDb_Click;
            // 
            // UpdateDbData
            // 
            UpdateDbData.Location = new Point(870, 306);
            UpdateDbData.Name = "UpdateDbData";
            UpdateDbData.Size = new Size(156, 29);
            UpdateDbData.TabIndex = 1;
            UpdateDbData.Text = "Обновление";
            UpdateDbData.UseVisualStyleBackColor = true;
            UpdateDbData.Click += UpdateDbData_Click;
            // 
            // SaveDb
            // 
            SaveDb.Location = new Point(296, 148);
            SaveDb.Name = "SaveDb";
            SaveDb.Size = new Size(156, 29);
            SaveDb.TabIndex = 2;
            SaveDb.Text = "сохранить данные";
            SaveDb.UseVisualStyleBackColor = true;
            SaveDb.Click += SaveDb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(763, 360);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 3;
            label1.Text = "Функции для изменения";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(680, 39);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(597, 256);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(536, 187);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(133, 29);
            FilterButton.TabIndex = 6;
            FilterButton.Text = "Отфильтровать";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // MailBox
            // 
            MailBox.Location = new Point(189, 36);
            MailBox.Name = "MailBox";
            MailBox.Size = new Size(125, 27);
            MailBox.TabIndex = 7;
            // 
            // GetDataApi
            // 
            GetDataApi.Location = new Point(98, 148);
            GetDataApi.Name = "GetDataApi";
            GetDataApi.Size = new Size(156, 29);
            GetDataApi.TabIndex = 8;
            GetDataApi.Text = "Получить данные";
            GetDataApi.UseVisualStyleBackColor = true;
            GetDataApi.Click += GetDataApi_Click;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(40, 92);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(125, 27);
            LastNameBox.TabIndex = 9;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(39, 35);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(126, 27);
            FirstNameBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 69);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 11;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 12);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 12;
            label4.Text = "FirstName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 39);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 12);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 14;
            label6.Text = "Mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 72);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 15;
            label7.Text = "City";
            // 
            // CityBox
            // 
            CityBox.Location = new Point(189, 92);
            CityBox.Name = "CityBox";
            CityBox.Size = new Size(125, 27);
            CityBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 12);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 17;
            label8.Text = "Country";
            // 
            // CountryBox
            // 
            CountryBox.Location = new Point(338, 36);
            CountryBox.Name = "CountryBox";
            CountryBox.Size = new Size(114, 27);
            CountryBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(366, 69);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 19;
            label9.Text = "State";
            // 
            // StateBox
            // 
            StateBox.Location = new Point(338, 92);
            StateBox.Name = "StateBox";
            StateBox.Size = new Size(114, 27);
            StateBox.TabIndex = 20;
            // 
            // FilterBox
            // 
            FilterBox.Location = new Point(544, 119);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(125, 27);
            FilterBox.TabIndex = 21;
            FilterBox.TextChanged += FilterBox_TextChanged;
            // 
            // updateUser
            // 
            updateUser.Location = new Point(844, 394);
            updateUser.Name = "updateUser";
            updateUser.Size = new Size(229, 31);
            updateUser.TabIndex = 22;
            updateUser.Text = "Обновить пользователя";
            updateUser.UseVisualStyleBackColor = true;
            updateUser.Click += UpdateUser_Click;
            // 
            // CheckFilterDate
            // 
            CheckFilterDate.AutoSize = true;
            CheckFilterDate.Location = new Point(565, 72);
            CheckFilterDate.Name = "CheckFilterDate";
            CheckFilterDate.Size = new Size(85, 24);
            CheckFilterDate.TabIndex = 23;
            CheckFilterDate.Text = "По дате";
            CheckFilterDate.UseVisualStyleBackColor = true;
            // 
            // CheckFilterName
            // 
            CheckFilterName.AutoSize = true;
            CheckFilterName.Location = new Point(549, 39);
            CheckFilterName.Name = "CheckFilterName";
            CheckFilterName.Size = new Size(101, 24);
            CheckFilterName.TabIndex = 24;
            CheckFilterName.Text = "По имени";
            CheckFilterName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 490);
            Controls.Add(CheckFilterName);
            Controls.Add(CheckFilterDate);
            Controls.Add(updateUser);
            Controls.Add(FilterBox);
            Controls.Add(StateBox);
            Controls.Add(label9);
            Controls.Add(CountryBox);
            Controls.Add(label8);
            Controls.Add(CityBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FirstNameBox);
            Controls.Add(LastNameBox);
            Controls.Add(GetDataApi);
            Controls.Add(MailBox);
            Controls.Add(FilterButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(SaveDb);
            Controls.Add(UpdateDbData);
            Controls.Add(DeleteFromDb);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteFromDb;
        private Button UpdateDbData;
        private Button SaveDb;
        private Label label1;
        private DataGridView dataGridView1;
        private Button FilterButton;
        private TextBox MailBox;
        private Button GetDataApi;
        private TextBox LastNameBox;
        private TextBox FirstNameBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox CityBox;
        private Label label8;
        private TextBox CountryBox;
        private Label label9;
        private TextBox StateBox;
        private TextBox FilterBox;
        private Button updateUser;
        private CheckBox CheckFilterDate;
        private CheckBox CheckFilterName;
    }
}
