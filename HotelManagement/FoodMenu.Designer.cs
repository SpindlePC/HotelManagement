namespace Hotel_Manager
{
    partial class FoodMenu
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
            this.foodPanel = new MetroFramework.Controls.MetroPanel();
            this.dinnerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.lunchCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.breakfastCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.surpriseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.towelsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.cleaningCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nextButton = new MetroFramework.Controls.MetroButton();
            this.foodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodPanel
            // 
            this.foodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.foodPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.foodPanel.Controls.Add(this.surpriseCheckBox);
            this.foodPanel.Controls.Add(this.metroLabel2);
            this.foodPanel.Controls.Add(this.towelsCheckBox);
            this.foodPanel.Controls.Add(this.dinnerCheckBox);
            this.foodPanel.Controls.Add(this.cleaningCheckBox);
            this.foodPanel.Controls.Add(this.lunchCheckBox);
            this.foodPanel.Controls.Add(this.breakfastCheckBox);
            this.foodPanel.Controls.Add(this.metroLabel1);
            this.foodPanel.HorizontalScrollbarBarColor = true;
            this.foodPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.foodPanel.HorizontalScrollbarSize = 19;
            this.foodPanel.Location = new System.Drawing.Point(28, 121);
            this.foodPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(664, 706);
            this.foodPanel.TabIndex = 5;
            this.foodPanel.UseCustomBackColor = true;
            this.foodPanel.UseCustomForeColor = true;
            this.foodPanel.UseStyleColors = true;
            this.foodPanel.VerticalScrollbarBarColor = true;
            this.foodPanel.VerticalScrollbarHighlightOnWheel = false;
            this.foodPanel.VerticalScrollbarSize = 20;
            // 
            // dinnerCheckBox
            // 
            this.dinnerCheckBox.AutoSize = true;
            this.dinnerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.dinnerCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dinnerCheckBox.Location = new System.Drawing.Point(28, 201);
            this.dinnerCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dinnerCheckBox.Name = "dinnerCheckBox";
            this.dinnerCheckBox.Size = new System.Drawing.Size(110, 19);
            this.dinnerCheckBox.TabIndex = 5;
            this.dinnerCheckBox.Text = "Kolacja";
            this.dinnerCheckBox.UseCustomBackColor = true;
            this.dinnerCheckBox.UseSelectable = true;
            this.dinnerCheckBox.CheckedChanged += new System.EventHandler(this.dinnerCheckBox_CheckedChanged);
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.lunchCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.lunchCheckBox.Location = new System.Drawing.Point(28, 138);
            this.lunchCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(106, 19);
            this.lunchCheckBox.TabIndex = 4;
            this.lunchCheckBox.Text = "Obiad";
            this.lunchCheckBox.UseCustomBackColor = true;
            this.lunchCheckBox.UseSelectable = true;
            this.lunchCheckBox.CheckedChanged += new System.EventHandler(this.lunchCheckBox_CheckedChanged);
            // 
            // breakfastCheckBox
            // 
            this.breakfastCheckBox.AutoSize = true;
            this.breakfastCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.breakfastCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.breakfastCheckBox.Location = new System.Drawing.Point(28, 79);
            this.breakfastCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.breakfastCheckBox.Name = "breakfastCheckBox";
            this.breakfastCheckBox.Size = new System.Drawing.Size(120, 19);
            this.breakfastCheckBox.TabIndex = 3;
            this.breakfastCheckBox.Text = "Sniadanie";
            this.breakfastCheckBox.UseCustomBackColor = true;
            this.breakfastCheckBox.UseSelectable = true;
            this.breakfastCheckBox.CheckedChanged += new System.EventHandler(this.breakfastCheckBox_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(6, 19);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(346, 54);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Opcje dodatkowe";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // surpriseCheckBox
            // 
            this.surpriseCheckBox.AutoSize = true;
            this.surpriseCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.surpriseCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.surpriseCheckBox.Location = new System.Drawing.Point(28, 472);
            this.surpriseCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.surpriseCheckBox.Name = "surpriseCheckBox";
            this.surpriseCheckBox.Size = new System.Drawing.Size(131, 19);
            this.surpriseCheckBox.TabIndex = 44;
            this.surpriseCheckBox.Text = "Inwalida";
            this.surpriseCheckBox.UseCustomBackColor = true;
            this.surpriseCheckBox.UseSelectable = true;
            // 
            // towelsCheckBox
            // 
            this.towelsCheckBox.AutoSize = true;
            this.towelsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.towelsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.towelsCheckBox.Location = new System.Drawing.Point(28, 408);
            this.towelsCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.towelsCheckBox.Name = "towelsCheckBox";
            this.towelsCheckBox.Size = new System.Drawing.Size(65, 19);
            this.towelsCheckBox.TabIndex = 42;
            this.towelsCheckBox.Text = "Wymiana recznikow";
            this.towelsCheckBox.UseCustomBackColor = true;
            this.towelsCheckBox.UseSelectable = true;
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.cleaningCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cleaningCheckBox.Location = new System.Drawing.Point(28, 343);
            this.cleaningCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(78, 19);
            this.cleaningCheckBox.TabIndex = 41;
            this.cleaningCheckBox.Text = "Sprzatanie";
            this.cleaningCheckBox.UseCustomBackColor = true;
            this.cleaningCheckBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 271);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(242, 54);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Special needs";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(710, 762);
            this.nextButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(328, 65);
            this.nextButton.TabIndex = 45;
            this.nextButton.Text = "DALEJ";
            this.nextButton.UseSelectable = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 850);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.foodPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FoodMenu";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Opcje dodatkowe";
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel foodPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroCheckBox dinnerCheckBox;
        public MetroFramework.Controls.MetroCheckBox lunchCheckBox;
        public MetroFramework.Controls.MetroCheckBox breakfastCheckBox;
        public MetroFramework.Controls.MetroCheckBox surpriseCheckBox;
        public MetroFramework.Controls.MetroCheckBox towelsCheckBox;
        public MetroFramework.Controls.MetroCheckBox cleaningCheckBox;
        public MetroFramework.Controls.MetroButton nextButton;
    }
}