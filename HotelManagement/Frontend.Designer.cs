namespace Hotel_Manager
{
    partial class Frontend
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
            this.resPanel = new MetroFramework.Controls.MetroTabControl();
            this.reservationPage = new MetroFramework.Controls.MetroTabPage();
            this.rightMPanel = new MetroFramework.Controls.MetroPanel();
            this.resEditButton = new MetroFramework.Controls.MetroComboBox();
            this.newButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.middlePanel = new MetroFramework.Controls.MetroPanel();
            this.checkinCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.foodMenuButton = new MetroFramework.Controls.MetroButton();
            this.qtGuestComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.depDatePicker = new System.Windows.Forms.DateTimePicker();
            this.roomNComboBox = new MetroFramework.Controls.MetroComboBox();
            this.floorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.entryLabel = new MetroFramework.Controls.MetroLabel();
            this.roomTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.choiceLabel = new MetroFramework.Controls.MetroLabel();
            this.leftMPanel = new MetroFramework.Controls.MetroPanel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.yearTextBox = new MetroFramework.Controls.MetroTextBox();
            this.monthComboBox = new MetroFramework.Controls.MetroComboBox();
            this.genderComboBox = new MetroFramework.Controls.MetroComboBox();
            this.birthdayLabel = new MetroFramework.Controls.MetroLabel();
            this.dayComboBox = new MetroFramework.Controls.MetroComboBox();
            this.phoneNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.zipComboBox = new MetroFramework.Controls.MetroTextBox();
            this.phoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.stateComboBox = new MetroFramework.Controls.MetroComboBox();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.addLabel = new MetroFramework.Controls.MetroTextBox();
            this.searchPage = new MetroFramework.Controls.MetroTabPage();
            this.SearchError = new MetroFramework.Controls.MetroLabel();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.resTotalDataGridView = new System.Windows.Forms.DataGridView();
            this.roomPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.reservedLabel = new MetroFramework.Controls.MetroLabel();
            this.roomReservedListBox = new System.Windows.Forms.ListBox();
            this.roomOccupiedListBox = new System.Windows.Forms.ListBox();
            this.occupiedLabel = new MetroFramework.Controls.MetroLabel();
            this.resPanel.SuspendLayout();
            this.reservationPage.SuspendLayout();
            this.rightMPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.leftMPanel.SuspendLayout();
            this.searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).BeginInit();
            this.roomPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // resPanel
            // 
            this.resPanel.Controls.Add(this.reservationPage);
            this.resPanel.Controls.Add(this.searchPage);
            this.resPanel.Controls.Add(this.metroTabPage2);
            this.resPanel.Controls.Add(this.roomPage);
            this.resPanel.Location = new System.Drawing.Point(16, 121);
            this.resPanel.Margin = new System.Windows.Forms.Padding(6);
            this.resPanel.Name = "resPanel";
            this.resPanel.SelectedIndex = 0;
            this.resPanel.Size = new System.Drawing.Size(1968, 927);
            this.resPanel.Style = MetroFramework.MetroColorStyle.Green;
            this.resPanel.TabIndex = 0;
            this.resPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resPanel.UseSelectable = true;
            // 
            // reservationPage
            // 
            this.reservationPage.Controls.Add(this.rightMPanel);
            this.reservationPage.Controls.Add(this.middlePanel);
            this.reservationPage.Controls.Add(this.leftMPanel);
            this.reservationPage.HorizontalScrollbarBarColor = true;
            this.reservationPage.HorizontalScrollbarHighlightOnWheel = false;
            this.reservationPage.HorizontalScrollbarSize = 19;
            this.reservationPage.Location = new System.Drawing.Point(8, 41);
            this.reservationPage.Margin = new System.Windows.Forms.Padding(6);
            this.reservationPage.Name = "reservationPage";
            this.reservationPage.Size = new System.Drawing.Size(1952, 878);
            this.reservationPage.Style = MetroFramework.MetroColorStyle.Green;
            this.reservationPage.TabIndex = 0;
            this.reservationPage.Text = "Rezerwacja";
            this.reservationPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reservationPage.VerticalScrollbarBarColor = true;
            this.reservationPage.VerticalScrollbarHighlightOnWheel = false;
            this.reservationPage.VerticalScrollbarSize = 20;
            // 
            // rightMPanel
            // 
            this.rightMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rightMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightMPanel.Controls.Add(this.resEditButton);
            this.rightMPanel.Controls.Add(this.newButton);
            this.rightMPanel.Controls.Add(this.deleteButton);
            this.rightMPanel.Controls.Add(this.editButton);
            this.rightMPanel.Controls.Add(this.updateButton);
            this.rightMPanel.HorizontalScrollbarBarColor = true;
            this.rightMPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.rightMPanel.HorizontalScrollbarSize = 19;
            this.rightMPanel.Location = new System.Drawing.Point(1416, 27);
            this.rightMPanel.Margin = new System.Windows.Forms.Padding(6);
            this.rightMPanel.Name = "rightMPanel";
            this.rightMPanel.Size = new System.Drawing.Size(530, 810);
            this.rightMPanel.TabIndex = 34;
            this.rightMPanel.UseCustomBackColor = true;
            this.rightMPanel.UseCustomForeColor = true;
            this.rightMPanel.UseStyleColors = true;
            this.rightMPanel.VerticalScrollbarBarColor = true;
            this.rightMPanel.VerticalScrollbarHighlightOnWheel = false;
            this.rightMPanel.VerticalScrollbarSize = 20;
            // 
            // resEditButton
            // 
            this.resEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resEditButton.ForeColor = System.Drawing.Color.Green;
            this.resEditButton.FormattingEnabled = true;
            this.resEditButton.ItemHeight = 23;
            this.resEditButton.Items.AddRange(new object[] {
            "[ID]    [NAME]    [PHONE NUMBER]"});
            this.resEditButton.Location = new System.Drawing.Point(20, 58);
            this.resEditButton.Margin = new System.Windows.Forms.Padding(6);
            this.resEditButton.Name = "resEditButton";
            this.resEditButton.PromptText = "Wybierz rezerwację do edycji";
            this.resEditButton.Size = new System.Drawing.Size(500, 29);
            this.resEditButton.TabIndex = 20;
            this.resEditButton.UseCustomForeColor = true;
            this.resEditButton.UseSelectable = true;
            this.resEditButton.UseStyleColors = true;
            this.resEditButton.Visible = false;
            this.resEditButton.SelectedIndexChanged += new System.EventHandler(this.resEditButton_SelectedIndexChanged);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(20, 721);
            this.newButton.Margin = new System.Windows.Forms.Padding(6);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(490, 62);
            this.newButton.Style = MetroFramework.MetroColorStyle.Green;
            this.newButton.TabIndex = 22;
            this.newButton.Text = "Nowa rezerwacja";
            this.newButton.UseSelectable = true;
            this.newButton.UseStyleColors = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Highlight = true;
            this.deleteButton.Location = new System.Drawing.Point(20, 554);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(490, 65);
            this.deleteButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteButton.UseSelectable = true;
            this.deleteButton.UseStyleColors = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(20, 644);
            this.editButton.Margin = new System.Windows.Forms.Padding(6);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(490, 62);
            this.editButton.Style = MetroFramework.MetroColorStyle.Green;
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edytuj obecną rezerwację";
            this.editButton.UseSelectable = true;
            this.editButton.UseStyleColors = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Highlight = true;
            this.updateButton.Location = new System.Drawing.Point(20, 471);
            this.updateButton.Margin = new System.Windows.Forms.Padding(6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(490, 65);
            this.updateButton.Style = MetroFramework.MetroColorStyle.Green;
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Aktualizuj";
            this.updateButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateButton.UseSelectable = true;
            this.updateButton.UseStyleColors = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.middlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.middlePanel.Controls.Add(this.checkinCheckBox);
            this.middlePanel.Controls.Add(this.foodMenuButton);
            this.middlePanel.Controls.Add(this.qtGuestComboBox);
            this.middlePanel.Controls.Add(this.metroLabel12);
            this.middlePanel.Controls.Add(this.submitButton);
            this.middlePanel.Controls.Add(this.depDatePicker);
            this.middlePanel.Controls.Add(this.roomNComboBox);
            this.middlePanel.Controls.Add(this.floorComboBox);
            this.middlePanel.Controls.Add(this.entryDatePicker);
            this.middlePanel.Controls.Add(this.entryLabel);
            this.middlePanel.Controls.Add(this.roomTypeComboBox);
            this.middlePanel.Controls.Add(this.choiceLabel);
            this.middlePanel.HorizontalScrollbarBarColor = true;
            this.middlePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.middlePanel.HorizontalScrollbarSize = 19;
            this.middlePanel.Location = new System.Drawing.Point(710, 27);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(6);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(690, 810);
            this.middlePanel.TabIndex = 16;
            this.middlePanel.UseCustomBackColor = true;
            this.middlePanel.UseCustomForeColor = true;
            this.middlePanel.UseStyleColors = true;
            this.middlePanel.VerticalScrollbarBarColor = true;
            this.middlePanel.VerticalScrollbarHighlightOnWheel = false;
            this.middlePanel.VerticalScrollbarSize = 20;
            // 
            // checkinCheckBox
            // 
            this.checkinCheckBox.AutoSize = true;
            this.checkinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.checkinCheckBox.Location = new System.Drawing.Point(32, 668);
            this.checkinCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.checkinCheckBox.Name = "checkinCheckBox";
            this.checkinCheckBox.Size = new System.Drawing.Size(73, 15);
            this.checkinCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.checkinCheckBox.TabIndex = 33;
            this.checkinCheckBox.Text = "Zamelduj";
            this.checkinCheckBox.UseCustomBackColor = true;
            this.checkinCheckBox.UseSelectable = true;
            this.checkinCheckBox.CheckedChanged += new System.EventHandler(this.checkinCheckBox_CheckedChanged);
            // 
            // foodMenuButton
            // 
            this.foodMenuButton.Location = new System.Drawing.Point(32, 467);
            this.foodMenuButton.Margin = new System.Windows.Forms.Padding(6);
            this.foodMenuButton.Name = "foodMenuButton";
            this.foodMenuButton.Size = new System.Drawing.Size(628, 65);
            this.foodMenuButton.Style = MetroFramework.MetroColorStyle.Green;
            this.foodMenuButton.TabIndex = 23;
            this.foodMenuButton.Text = "Opcje dodatkowe";
            this.foodMenuButton.UseSelectable = true;
            this.foodMenuButton.UseStyleColors = true;
            this.foodMenuButton.Click += new System.EventHandler(this.foodMenuButton_Click);
            // 
            // qtGuestComboBox
            // 
            this.qtGuestComboBox.FormattingEnabled = true;
            this.qtGuestComboBox.ItemHeight = 23;
            this.qtGuestComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.qtGuestComboBox.Location = new System.Drawing.Point(32, 58);
            this.qtGuestComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.qtGuestComboBox.Name = "qtGuestComboBox";
            this.qtGuestComboBox.PromptText = "Ilość gości";
            this.qtGuestComboBox.Size = new System.Drawing.Size(298, 29);
            this.qtGuestComboBox.TabIndex = 25;
            this.qtGuestComboBox.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(32, 325);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(30, 19);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "DO";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Highlight = true;
            this.submitButton.Location = new System.Drawing.Point(32, 715);
            this.submitButton.Margin = new System.Windows.Forms.Padding(6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(628, 69);
            this.submitButton.Style = MetroFramework.MetroColorStyle.Green;
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Wyślij";
            this.submitButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.submitButton.UseSelectable = true;
            this.submitButton.UseStyleColors = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // depDatePicker
            // 
            this.depDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDatePicker.CustomFormat = "dd-MM-yyyy";
            this.depDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depDatePicker.Location = new System.Drawing.Point(32, 367);
            this.depDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.depDatePicker.Name = "depDatePicker";
            this.depDatePicker.Size = new System.Drawing.Size(628, 44);
            this.depDatePicker.TabIndex = 31;
            this.depDatePicker.Value = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // roomNComboBox
            // 
            this.roomNComboBox.FormattingEnabled = true;
            this.roomNComboBox.ItemHeight = 23;
            this.roomNComboBox.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510"});
            this.roomNComboBox.Location = new System.Drawing.Point(346, 160);
            this.roomNComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomNComboBox.Name = "roomNComboBox";
            this.roomNComboBox.PromptText = "Pokój";
            this.roomNComboBox.Size = new System.Drawing.Size(314, 29);
            this.roomNComboBox.TabIndex = 24;
            this.roomNComboBox.UseSelectable = true;
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.ItemHeight = 23;
            this.floorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.floorComboBox.Location = new System.Drawing.Point(32, 160);
            this.floorComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.PromptText = "Piętro";
            this.floorComboBox.Size = new System.Drawing.Size(298, 29);
            this.floorComboBox.TabIndex = 23;
            this.floorComboBox.UseSelectable = true;
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDatePicker.CustomFormat = "MM-dd-yyyy";
            this.entryDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDatePicker.Location = new System.Drawing.Point(32, 269);
            this.entryDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(624, 44);
            this.entryDatePicker.TabIndex = 26;
            this.entryDatePicker.Value = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            this.entryDatePicker.ValueChanged += new System.EventHandler(this.entryDatePicker_ValueChanged);
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.BackColor = System.Drawing.Color.Transparent;
            this.entryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.entryLabel.Location = new System.Drawing.Point(32, 227);
            this.entryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(30, 19);
            this.entryLabel.TabIndex = 30;
            this.entryLabel.Text = "OD";
            this.entryLabel.UseCustomBackColor = true;
            this.entryLabel.UseCustomForeColor = true;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.ItemHeight = 23;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Pojedyncze",
            "Podwójne",
            "Potrójne",
            "Małżeńskie",
            "Inne"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(346, 56);
            this.roomTypeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.PromptText = "Rodzaj łóżek";
            this.roomTypeComboBox.Size = new System.Drawing.Size(314, 29);
            this.roomTypeComboBox.TabIndex = 22;
            this.roomTypeComboBox.UseSelectable = true;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.choiceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.choiceLabel.Location = new System.Drawing.Point(32, 15);
            this.choiceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(76, 19);
            this.choiceLabel.TabIndex = 21;
            this.choiceLabel.Text = "Preferencje";
            this.choiceLabel.UseCustomBackColor = true;
            this.choiceLabel.UseCustomForeColor = true;
            // 
            // leftMPanel
            // 
            this.leftMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.leftMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftMPanel.Controls.Add(this.emailLabel);
            this.leftMPanel.Controls.Add(this.nameLabel);
            this.leftMPanel.Controls.Add(this.emailTextBox);
            this.leftMPanel.Controls.Add(this.yearTextBox);
            this.leftMPanel.Controls.Add(this.monthComboBox);
            this.leftMPanel.Controls.Add(this.genderComboBox);
            this.leftMPanel.Controls.Add(this.birthdayLabel);
            this.leftMPanel.Controls.Add(this.dayComboBox);
            this.leftMPanel.Controls.Add(this.phoneNumberLabel);
            this.leftMPanel.Controls.Add(this.firstNameTextBox);
            this.leftMPanel.Controls.Add(this.genderLabel);
            this.leftMPanel.Controls.Add(this.zipComboBox);
            this.leftMPanel.Controls.Add(this.phoneNumberTextBox);
            this.leftMPanel.Controls.Add(this.stateComboBox);
            this.leftMPanel.Controls.Add(this.lastNameTextBox);
            this.leftMPanel.Controls.Add(this.cityTextBox);
            this.leftMPanel.Controls.Add(this.metroLabel6);
            this.leftMPanel.Controls.Add(this.addLabel);
            this.leftMPanel.HorizontalScrollbarBarColor = true;
            this.leftMPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leftMPanel.HorizontalScrollbarSize = 19;
            this.leftMPanel.Location = new System.Drawing.Point(6, 29);
            this.leftMPanel.Margin = new System.Windows.Forms.Padding(6);
            this.leftMPanel.Name = "leftMPanel";
            this.leftMPanel.Size = new System.Drawing.Size(690, 810);
            this.leftMPanel.TabIndex = 4;
            this.leftMPanel.UseCustomBackColor = true;
            this.leftMPanel.UseCustomForeColor = true;
            this.leftMPanel.UseStyleColors = true;
            this.leftMPanel.VerticalScrollbarBarColor = true;
            this.leftMPanel.VerticalScrollbarHighlightOnWheel = false;
            this.leftMPanel.VerticalScrollbarSize = 20;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.emailLabel.Location = new System.Drawing.Point(28, 450);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(86, 19);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Adres e-mail";
            this.emailLabel.UseCustomBackColor = true;
            this.emailLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nameLabel.Location = new System.Drawing.Point(28, 13);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Dane personalne";
            this.nameLabel.UseCustomBackColor = true;
            this.nameLabel.UseCustomForeColor = true;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(30, 500);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "W12345@wsiz.rzeszow.student.pl";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(632, 56);
            this.emailTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.emailTextBox.TabIndex = 14;
            this.emailTextBox.UseCustomBackColor = true;
            this.emailTextBox.UseSelectable = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.White;
            this.yearTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.yearTextBox.Lines = new string[0];
            this.yearTextBox.Location = new System.Drawing.Point(460, 162);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.yearTextBox.MaxLength = 32767;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.PasswordChar = '\0';
            this.yearTextBox.PromptText = "Rok";
            this.yearTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.yearTextBox.SelectedText = "";
            this.yearTextBox.Size = new System.Drawing.Size(202, 56);
            this.yearTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.yearTextBox.TabIndex = 9;
            this.yearTextBox.UseCustomBackColor = true;
            this.yearTextBox.UseSelectable = true;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.ItemHeight = 23;
            this.monthComboBox.Items.AddRange(new object[] {
            "Styczeń ",
            "Luty ",
            "Marzec ",
            "Kwiecień ",
            "Maj ",
            "Czerwiec ",
            "Lipiec ",
            "Sierpień ",
            "Wrzesień ",
            "Październik ",
            "Listopad ",
            "Grudzień"});
            this.monthComboBox.Location = new System.Drawing.Point(204, 162);
            this.monthComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.PromptText = "Miesiąc";
            this.monthComboBox.Size = new System.Drawing.Size(244, 29);
            this.monthComboBox.TabIndex = 6;
            this.monthComboBox.UseSelectable = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.ItemHeight = 23;
            this.genderComboBox.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.genderComboBox.Location = new System.Drawing.Point(30, 267);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.PromptText = "Wybierz";
            this.genderComboBox.Size = new System.Drawing.Size(626, 29);
            this.genderComboBox.TabIndex = 11;
            this.genderComboBox.UseSelectable = true;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.birthdayLabel.Location = new System.Drawing.Point(30, 125);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(102, 19);
            this.birthdayLabel.TabIndex = 5;
            this.birthdayLabel.Text = "Data urodzenia";
            this.birthdayLabel.UseCustomBackColor = true;
            this.birthdayLabel.UseCustomForeColor = true;
            this.birthdayLabel.Click += new System.EventHandler(this.birthdayLabel_Click);
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.ItemHeight = 23;
            this.dayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(30, 162);
            this.dayComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.PromptText = "Dzień";
            this.dayComboBox.Size = new System.Drawing.Size(162, 29);
            this.dayComboBox.TabIndex = 8;
            this.dayComboBox.UseSelectable = true;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.phoneNumberLabel.Location = new System.Drawing.Point(28, 329);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(105, 19);
            this.phoneNumberLabel.TabIndex = 12;
            this.phoneNumberLabel.Text = "Numer telefonu";
            this.phoneNumberLabel.UseCustomBackColor = true;
            this.phoneNumberLabel.UseCustomForeColor = true;
            this.phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.firstNameTextBox.Lines = new string[0];
            this.firstNameTextBox.Location = new System.Drawing.Point(30, 52);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTextBox.MaxLength = 32767;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PromptText = "Imię";
            this.firstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(310, 56);
            this.firstNameTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.UseCustomBackColor = true;
            this.firstNameTextBox.UseSelectable = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.genderLabel.Location = new System.Drawing.Point(30, 225);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(34, 19);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Płeć";
            this.genderLabel.UseCustomBackColor = true;
            this.genderLabel.UseCustomForeColor = true;
            // 
            // zipComboBox
            // 
            this.zipComboBox.BackColor = System.Drawing.Color.White;
            this.zipComboBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.zipComboBox.Lines = new string[0];
            this.zipComboBox.Location = new System.Drawing.Point(352, 726);
            this.zipComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.zipComboBox.MaxLength = 32767;
            this.zipComboBox.Name = "zipComboBox";
            this.zipComboBox.PasswordChar = '\0';
            this.zipComboBox.PromptText = "Kod pocztowy";
            this.zipComboBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.zipComboBox.SelectedText = "";
            this.zipComboBox.Size = new System.Drawing.Size(310, 56);
            this.zipComboBox.Style = MetroFramework.MetroColorStyle.White;
            this.zipComboBox.TabIndex = 20;
            this.zipComboBox.UseCustomBackColor = true;
            this.zipComboBox.UseSelectable = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNumberTextBox.Lines = new string[0];
            this.phoneNumberTextBox.Location = new System.Drawing.Point(28, 371);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneNumberTextBox.MaxLength = 32767;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.PromptText = "123456789";
            this.phoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNumberTextBox.SelectedText = "";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(634, 56);
            this.phoneNumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.phoneNumberTextBox.TabIndex = 13;
            this.phoneNumberTextBox.UseCustomBackColor = true;
            this.phoneNumberTextBox.UseSelectable = true;
            this.phoneNumberTextBox.Leave += new System.EventHandler(this.phoneNumberTextBox_Leave);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.ItemHeight = 23;
            this.stateComboBox.Items.AddRange(new object[] {
            "dolnośląskie",
            "kujawsko-pomorskie",
            "lubelskie",
            "lubuskie",
            "łódzkie",
            "małopolskie",
            "mazowieckie",
            "opolskie",
            "podkarpackie",
            "podlaskie",
            "pomorskie",
            "śląskie",
            "świętokrzyskie",
            "warmińsko-mazurskie",
            "wielkopolskie",
            "zachodniopomorskie"});
            this.stateComboBox.Location = new System.Drawing.Point(352, 642);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.PromptText = "Województwo";
            this.stateComboBox.Size = new System.Drawing.Size(296, 29);
            this.stateComboBox.TabIndex = 19;
            this.stateComboBox.UseSelectable = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lastNameTextBox.Lines = new string[0];
            this.lastNameTextBox.Location = new System.Drawing.Point(352, 52);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PromptText = "Nazwisko";
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(310, 56);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.UseCustomBackColor = true;
            this.lastNameTextBox.UseSelectable = true;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.Color.White;
            this.cityTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cityTextBox.Lines = new string[0];
            this.cityTextBox.Location = new System.Drawing.Point(30, 725);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.cityTextBox.MaxLength = 32767;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.PasswordChar = '\0';
            this.cityTextBox.PromptText = "Miasto";
            this.cityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cityTextBox.SelectedText = "";
            this.cityTextBox.Size = new System.Drawing.Size(310, 56);
            this.cityTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.cityTextBox.TabIndex = 18;
            this.cityTextBox.UseCustomBackColor = true;
            this.cityTextBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(30, 598);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Adres";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // addLabel
            // 
            this.addLabel.BackColor = System.Drawing.Color.White;
            this.addLabel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.addLabel.Lines = new string[0];
            this.addLabel.Location = new System.Drawing.Point(30, 642);
            this.addLabel.Margin = new System.Windows.Forms.Padding(6);
            this.addLabel.MaxLength = 32767;
            this.addLabel.Name = "addLabel";
            this.addLabel.PasswordChar = '\0';
            this.addLabel.PromptText = "Adres";
            this.addLabel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addLabel.SelectedText = "";
            this.addLabel.Size = new System.Drawing.Size(310, 56);
            this.addLabel.Style = MetroFramework.MetroColorStyle.White;
            this.addLabel.TabIndex = 15;
            this.addLabel.UseCustomBackColor = true;
            this.addLabel.UseSelectable = true;
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.SearchError);
            this.searchPage.Controls.Add(this.searchDataGridView);
            this.searchPage.Controls.Add(this.searchButton);
            this.searchPage.Controls.Add(this.searchTextBox);
            this.searchPage.HorizontalScrollbarBarColor = true;
            this.searchPage.HorizontalScrollbarHighlightOnWheel = false;
            this.searchPage.HorizontalScrollbarSize = 19;
            this.searchPage.Location = new System.Drawing.Point(8, 41);
            this.searchPage.Margin = new System.Windows.Forms.Padding(6);
            this.searchPage.Name = "searchPage";
            this.searchPage.Size = new System.Drawing.Size(1952, 878);
            this.searchPage.TabIndex = 4;
            this.searchPage.Text = "Wyszukaj";
            this.searchPage.VerticalScrollbarBarColor = true;
            this.searchPage.VerticalScrollbarHighlightOnWheel = false;
            this.searchPage.VerticalScrollbarSize = 20;
            // 
            // SearchError
            // 
            this.SearchError.AutoSize = true;
            this.SearchError.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SearchError.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SearchError.Location = new System.Drawing.Point(540, 71);
            this.SearchError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SearchError.Name = "SearchError";
            this.SearchError.Size = new System.Drawing.Size(209, 25);
            this.SearchError.Style = MetroFramework.MetroColorStyle.Green;
            this.SearchError.TabIndex = 19;
            this.SearchError.Text = "Ups, coś poszło nie tak :(";
            this.SearchError.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(136, 79);
            this.searchDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.Size = new System.Drawing.Size(1460, 454);
            this.searchDataGridView.TabIndex = 18;
            this.searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(1518, 379);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 56);
            this.searchButton.TabIndex = 17;
            this.searchButton.UseCustomBackColor = true;
            this.searchButton.UseSelectable = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchTextBox.IconRight = true;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(150, 379);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Wyszukaj";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(1426, 56);
            this.searchTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.UseCustomBackColor = true;
            this.searchTextBox.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.Controls.Add(this.resTotalDataGridView);
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 19;
            this.metroTabPage2.Location = new System.Drawing.Point(8, 41);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1952, 878);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "Widok rezerwacji";
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 20;
            // 
            // resTotalDataGridView
            // 
            this.resTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resTotalDataGridView.Location = new System.Drawing.Point(0, 6);
            this.resTotalDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.resTotalDataGridView.Name = "resTotalDataGridView";
            this.resTotalDataGridView.Size = new System.Drawing.Size(1952, 835);
            this.resTotalDataGridView.TabIndex = 2;
            // 
            // roomPage
            // 
            this.roomPage.Controls.Add(this.metroLabel13);
            this.roomPage.Controls.Add(this.metroLabel11);
            this.roomPage.Controls.Add(this.reservedLabel);
            this.roomPage.Controls.Add(this.roomReservedListBox);
            this.roomPage.Controls.Add(this.roomOccupiedListBox);
            this.roomPage.Controls.Add(this.occupiedLabel);
            this.roomPage.HorizontalScrollbarBarColor = true;
            this.roomPage.HorizontalScrollbarHighlightOnWheel = false;
            this.roomPage.HorizontalScrollbarSize = 19;
            this.roomPage.Location = new System.Drawing.Point(8, 41);
            this.roomPage.Margin = new System.Windows.Forms.Padding(6);
            this.roomPage.Name = "roomPage";
            this.roomPage.Size = new System.Drawing.Size(1952, 878);
            this.roomPage.TabIndex = 2;
            this.roomPage.Text = "Dostępne pokoje";
            this.roomPage.VerticalScrollbarBarColor = true;
            this.roomPage.VerticalScrollbarHighlightOnWheel = false;
            this.roomPage.VerticalScrollbarSize = 20;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(918, 54);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(500, 19);
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "Pokój#| Rodzaj  |  ID#   |       Imię      |      Telefon  #      |     Wejście  " +
    "     |    Wyjście";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(-6, 54);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(316, 19);
            this.metroLabel11.TabIndex = 9;
            this.metroLabel11.Text = "Room#| Rodzaj  |  ID#   |       Imię      |      Telefon #";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // reservedLabel
            // 
            this.reservedLabel.AutoSize = true;
            this.reservedLabel.BackColor = System.Drawing.Color.Transparent;
            this.reservedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.reservedLabel.Location = new System.Drawing.Point(918, 8);
            this.reservedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.reservedLabel.Name = "reservedLabel";
            this.reservedLabel.Size = new System.Drawing.Size(104, 19);
            this.reservedLabel.TabIndex = 8;
            this.reservedLabel.Text = "Zarezerwowane";
            this.reservedLabel.UseCustomBackColor = true;
            this.reservedLabel.UseCustomForeColor = true;
            // 
            // roomReservedListBox
            // 
            this.roomReservedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomReservedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomReservedListBox.FormattingEnabled = true;
            this.roomReservedListBox.HorizontalScrollbar = true;
            this.roomReservedListBox.IntegralHeight = false;
            this.roomReservedListBox.ItemHeight = 25;
            this.roomReservedListBox.Location = new System.Drawing.Point(920, 96);
            this.roomReservedListBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomReservedListBox.Name = "roomReservedListBox";
            this.roomReservedListBox.Size = new System.Drawing.Size(1032, 744);
            this.roomReservedListBox.TabIndex = 7;
            // 
            // roomOccupiedListBox
            // 
            this.roomOccupiedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomOccupiedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomOccupiedListBox.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomOccupiedListBox.FormattingEnabled = true;
            this.roomOccupiedListBox.HorizontalScrollbar = true;
            this.roomOccupiedListBox.IntegralHeight = false;
            this.roomOccupiedListBox.ItemHeight = 30;
            this.roomOccupiedListBox.Location = new System.Drawing.Point(0, 96);
            this.roomOccupiedListBox.Margin = new System.Windows.Forms.Padding(6);
            this.roomOccupiedListBox.Name = "roomOccupiedListBox";
            this.roomOccupiedListBox.Size = new System.Drawing.Size(908, 744);
            this.roomOccupiedListBox.TabIndex = 6;
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.AutoSize = true;
            this.occupiedLabel.BackColor = System.Drawing.Color.Transparent;
            this.occupiedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.occupiedLabel.Location = new System.Drawing.Point(-6, 8);
            this.occupiedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(66, 19);
            this.occupiedLabel.TabIndex = 5;
            this.occupiedLabel.Text = "Odebrano";
            this.occupiedLabel.UseCustomBackColor = true;
            this.occupiedLabel.UseCustomForeColor = true;
            // 
            // Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1996, 1048);
            this.Controls.Add(this.resPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frontend";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Witaj w aplikacji hotelowej";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frontend_FormClosing);
            this.Load += new System.EventHandler(this.MainTab_Load);
            this.resPanel.ResumeLayout(false);
            this.reservationPage.ResumeLayout(false);
            this.rightMPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.leftMPanel.ResumeLayout(false);
            this.leftMPanel.PerformLayout();
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).EndInit();
            this.roomPage.ResumeLayout(false);
            this.roomPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



        private MetroFramework.Controls.MetroTabControl resPanel;
        private MetroFramework.Controls.MetroTabPage reservationPage;
        private MetroFramework.Controls.MetroPanel leftMPanel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroLabel birthdayLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroComboBox monthComboBox;
        private MetroFramework.Controls.MetroTextBox yearTextBox;
        private MetroFramework.Controls.MetroComboBox dayComboBox;
        private MetroFramework.Controls.MetroTextBox phoneNumberTextBox;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel phoneNumberLabel;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroPanel middlePanel;
        private MetroFramework.Controls.MetroTextBox zipComboBox;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
        private MetroFramework.Controls.MetroTextBox cityTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox addLabel;
        private MetroFramework.Controls.MetroComboBox roomTypeComboBox;
        private MetroFramework.Controls.MetroLabel choiceLabel;
        private MetroFramework.Controls.MetroComboBox roomNComboBox;
        private MetroFramework.Controls.MetroComboBox floorComboBox;
        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton newButton;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private MetroFramework.Controls.MetroLabel entryLabel;
        private MetroFramework.Controls.MetroButton foodMenuButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroCheckBox checkinCheckBox;
        private MetroFramework.Controls.MetroComboBox resEditButton;
        private MetroFramework.Controls.MetroPanel rightMPanel;

        private MetroFramework.Controls.MetroTabPage roomPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;

        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
        private MetroFramework.Controls.MetroLabel occupiedLabel;
        private MetroFramework.Controls.MetroLabel reservedLabel;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private MetroFramework.Controls.MetroTabPage searchPage;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroComboBox qtGuestComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel SearchError;
    }
}