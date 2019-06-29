namespace Hotel_Manager
{
    partial class Kitchen
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TodoTabPage = new MetroFramework.Controls.MetroTabPage();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.floorNLabel = new MetroFramework.Controls.MetroLabel();
            this.roomTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.floorNTextBox = new MetroFramework.Controls.MetroTextBox();
            this.roomTypeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.phoneNTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.phoneNLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.overviewTabPage = new MetroFramework.Controls.MetroTabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTabControl1.SuspendLayout();
            this.TodoTabPage.SuspendLayout();
            this.overviewTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TodoTabPage);
            this.metroTabControl1.Controls.Add(this.overviewTabPage);
            this.metroTabControl1.Location = new System.Drawing.Point(22, 121);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1966, 923);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // TodoTabPage
            // 
            this.TodoTabPage.Controls.Add(this.updateButton);
            this.TodoTabPage.Controls.Add(this.floorNLabel);
            this.TodoTabPage.Controls.Add(this.roomTypeLabel);
            this.TodoTabPage.Controls.Add(this.floorNTextBox);
            this.TodoTabPage.Controls.Add(this.roomTypeTextBox);
            this.TodoTabPage.Controls.Add(this.phoneNTextBox);
            this.TodoTabPage.Controls.Add(this.nameLabel);
            this.TodoTabPage.Controls.Add(this.phoneNLabel);
            this.TodoTabPage.Controls.Add(this.firstNameTextBox);
            this.TodoTabPage.Controls.Add(this.lastNameTextBox);
            this.TodoTabPage.HorizontalScrollbarBarColor = true;
            this.TodoTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TodoTabPage.HorizontalScrollbarSize = 19;
            this.TodoTabPage.Location = new System.Drawing.Point(8, 41);
            this.TodoTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.TodoTabPage.Name = "TodoTabPage";
            this.TodoTabPage.Size = new System.Drawing.Size(1950, 874);
            this.TodoTabPage.Style = MetroFramework.MetroColorStyle.Lime;
            this.TodoTabPage.TabIndex = 1;
            this.TodoTabPage.Text = "Rejestracja";
            this.TodoTabPage.VerticalScrollbarBarColor = true;
            this.TodoTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.TodoTabPage.VerticalScrollbarSize = 20;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(58, 518);
            this.updateButton.Margin = new System.Windows.Forms.Padding(6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(636, 60);
            this.updateButton.Style = MetroFramework.MetroColorStyle.Green;
            this.updateButton.TabIndex = 60;
            this.updateButton.Text = "Zarejestruj";
            this.updateButton.UseSelectable = true;
            this.updateButton.UseStyleColors = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // floorNLabel
            // 
            this.floorNLabel.AutoSize = true;
            this.floorNLabel.BackColor = System.Drawing.Color.Transparent;
            this.floorNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.floorNLabel.Location = new System.Drawing.Point(382, 371);
            this.floorNLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.floorNLabel.Name = "floorNLabel";
            this.floorNLabel.Size = new System.Drawing.Size(30, 19);
            this.floorNLabel.TabIndex = 57;
            this.floorNLabel.Text = "DO";
            this.floorNLabel.UseCustomBackColor = true;
            this.floorNLabel.UseCustomForeColor = true;
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomTypeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.roomTypeLabel.Location = new System.Drawing.Point(58, 371);
            this.roomTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(30, 19);
            this.roomTypeLabel.TabIndex = 56;
            this.roomTypeLabel.Text = "OD";
            this.roomTypeLabel.UseCustomBackColor = true;
            this.roomTypeLabel.UseCustomForeColor = true;
            // 
            // floorNTextBox
            // 
            this.floorNTextBox.BackColor = System.Drawing.Color.White;
            this.floorNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.floorNTextBox.Lines = new string[0];
            this.floorNTextBox.Location = new System.Drawing.Point(380, 413);
            this.floorNTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.floorNTextBox.MaxLength = 32767;
            this.floorNTextBox.Name = "floorNTextBox";
            this.floorNTextBox.PasswordChar = '\0';
            this.floorNTextBox.PromptText = "do";
            this.floorNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.floorNTextBox.SelectedText = "";
            this.floorNTextBox.Size = new System.Drawing.Size(310, 56);
            this.floorNTextBox.TabIndex = 46;
            this.floorNTextBox.UseCustomBackColor = true;
            this.floorNTextBox.UseSelectable = true;
            // 
            // roomTypeTextBox
            // 
            this.roomTypeTextBox.BackColor = System.Drawing.Color.White;
            this.roomTypeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.roomTypeTextBox.Lines = new string[0];
            this.roomTypeTextBox.Location = new System.Drawing.Point(58, 413);
            this.roomTypeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomTypeTextBox.MaxLength = 32767;
            this.roomTypeTextBox.Name = "roomTypeTextBox";
            this.roomTypeTextBox.PasswordChar = '\0';
            this.roomTypeTextBox.PromptText = "od";
            this.roomTypeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roomTypeTextBox.SelectedText = "";
            this.roomTypeTextBox.Size = new System.Drawing.Size(310, 56);
            this.roomTypeTextBox.TabIndex = 44;
            this.roomTypeTextBox.UseCustomBackColor = true;
            this.roomTypeTextBox.UseSelectable = true;
            // 
            // phoneNTextBox
            // 
            this.phoneNTextBox.BackColor = System.Drawing.Color.White;
            this.phoneNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNTextBox.Lines = new string[0];
            this.phoneNTextBox.Location = new System.Drawing.Point(58, 296);
            this.phoneNTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneNTextBox.MaxLength = 32767;
            this.phoneNTextBox.Name = "phoneNTextBox";
            this.phoneNTextBox.PasswordChar = '\0';
            this.phoneNTextBox.PromptText = "123456789";
            this.phoneNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNTextBox.SelectedText = "";
            this.phoneNTextBox.Size = new System.Drawing.Size(632, 56);
            this.phoneNTextBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.phoneNTextBox.TabIndex = 43;
            this.phoneNTextBox.UseCustomBackColor = true;
            this.phoneNTextBox.UseSelectable = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nameLabel.Location = new System.Drawing.Point(58, 133);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 19);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "Dane osobowe";
            this.nameLabel.UseCustomBackColor = true;
            this.nameLabel.UseCustomForeColor = true;
            // 
            // phoneNLabel
            // 
            this.phoneNLabel.AutoSize = true;
            this.phoneNLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.phoneNLabel.Location = new System.Drawing.Point(58, 254);
            this.phoneNLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneNLabel.Name = "phoneNLabel";
            this.phoneNLabel.Size = new System.Drawing.Size(105, 19);
            this.phoneNLabel.TabIndex = 30;
            this.phoneNLabel.Text = "Numer telefonu";
            this.phoneNLabel.UseCustomBackColor = true;
            this.phoneNLabel.UseCustomForeColor = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.firstNameTextBox.Lines = new string[0];
            this.firstNameTextBox.Location = new System.Drawing.Point(58, 175);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTextBox.MaxLength = 32767;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PromptText = "Imie";
            this.firstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(310, 56);
            this.firstNameTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.firstNameTextBox.TabIndex = 21;
            this.firstNameTextBox.UseCustomBackColor = true;
            this.firstNameTextBox.UseSelectable = true;
            this.firstNameTextBox.Click += new System.EventHandler(this.firstNameTextBox_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lastNameTextBox.Lines = new string[0];
            this.lastNameTextBox.Location = new System.Drawing.Point(384, 175);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PromptText = "Nazwisko";
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(310, 56);
            this.lastNameTextBox.TabIndex = 22;
            this.lastNameTextBox.UseCustomBackColor = true;
            this.lastNameTextBox.UseSelectable = true;
            // 
            // overviewTabPage
            // 
            this.overviewTabPage.Controls.Add(this.textBox1);
            this.overviewTabPage.HorizontalScrollbarBarColor = true;
            this.overviewTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.overviewTabPage.HorizontalScrollbarSize = 19;
            this.overviewTabPage.Location = new System.Drawing.Point(8, 41);
            this.overviewTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.overviewTabPage.Name = "overviewTabPage";
            this.overviewTabPage.Size = new System.Drawing.Size(1950, 874);
            this.overviewTabPage.TabIndex = 0;
            this.overviewTabPage.Text = "Regulamin";
            this.overviewTabPage.VerticalScrollbarBarColor = true;
            this.overviewTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.overviewTabPage.VerticalScrollbarSize = 20;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(781, 481);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Regulamin hotelu";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1058);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Kitchen";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Zarejestruj sie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kitchen_FormClosing);
            this.Load += new System.EventHandler(this.kitchen_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TodoTabPage.ResumeLayout(false);
            this.TodoTabPage.PerformLayout();
            this.overviewTabPage.ResumeLayout(false);
            this.overviewTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TodoTabPage;
        private MetroFramework.Controls.MetroTabPage overviewTabPage;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel phoneNLabel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroTextBox phoneNTextBox;
        private MetroFramework.Controls.MetroTextBox floorNTextBox;
        private MetroFramework.Controls.MetroTextBox roomTypeTextBox;
        private MetroFramework.Controls.MetroLabel floorNLabel;
        private MetroFramework.Controls.MetroLabel roomTypeLabel;
        private MetroFramework.Controls.MetroButton updateButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}