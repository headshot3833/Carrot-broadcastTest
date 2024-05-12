
namespace Carrot_broadcastTest
{
    partial class UpdateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cancel = new Button();
            FirstUpdate = new TextBox();
            LastUpdate = new TextBox();
            StateUpdate = new TextBox();
            CityUpdate = new TextBox();
            MailUpdate = new TextBox();
            CountryUpdate = new TextBox();
            UpdateUserButton = new Button();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.Location = new Point(67, 360);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(148, 42);
            Cancel.TabIndex = 1;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += this.Cancel_Click;
            // 
            // FirstUpdate
            // 
            FirstUpdate.Location = new Point(69, 30);
            FirstUpdate.Name = "FirstUpdate";
            FirstUpdate.Size = new Size(146, 27);
            FirstUpdate.TabIndex = 2;
            // 
            // LastUpdate
            // 
            LastUpdate.Location = new Point(69, 78);
            LastUpdate.Name = "LastUpdate";
            LastUpdate.Size = new Size(146, 27);
            LastUpdate.TabIndex = 3;
            // 
            // StateUpdate
            // 
            StateUpdate.Location = new Point(67, 124);
            StateUpdate.Name = "StateUpdate";
            StateUpdate.Size = new Size(148, 27);
            StateUpdate.TabIndex = 4;
            // 
            // CityUpdate
            // 
            CityUpdate.Location = new Point(67, 172);
            CityUpdate.Name = "CityUpdate";
            CityUpdate.Size = new Size(148, 27);
            CityUpdate.TabIndex = 5;
            // 
            // MailUpdate
            // 
            MailUpdate.Location = new Point(67, 220);
            MailUpdate.Name = "MailUpdate";
            MailUpdate.Size = new Size(148, 27);
            MailUpdate.TabIndex = 6;
            // 
            // CountryUpdate
            // 
            CountryUpdate.Location = new Point(69, 272);
            CountryUpdate.Name = "CountryUpdate";
            CountryUpdate.Size = new Size(146, 27);
            CountryUpdate.TabIndex = 7;
            // 
            // UpdateUserButton
            // 
            UpdateUserButton.Location = new Point(69, 305);
            UpdateUserButton.Name = "UpdateUserButton";
            UpdateUserButton.Size = new Size(146, 49);
            UpdateUserButton.TabIndex = 8;
            UpdateUserButton.Text = "Обновить пользователя";
            UpdateUserButton.UseVisualStyleBackColor = true;
            UpdateUserButton.Click += this.UpdateUserButton_Click;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 435);
            Controls.Add(UpdateUserButton);
            Controls.Add(CountryUpdate);
            Controls.Add(MailUpdate);
            Controls.Add(CityUpdate);
            Controls.Add(StateUpdate);
            Controls.Add(LastUpdate);
            Controls.Add(FirstUpdate);
            Controls.Add(Cancel);
            Name = "UpdateUserForm";
            Text = "UpdateUser";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Button Cancel;
        private TextBox FirstUpdate;
        private TextBox LastUpdate;
        private TextBox StateUpdate;
        private TextBox CityUpdate;
        private TextBox MailUpdate;
        private TextBox CountryUpdate;
        private Button UpdateUserButton;
    }
}