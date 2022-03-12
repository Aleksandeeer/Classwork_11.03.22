
namespace Classwork_11._03._22
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.DiagnosisTabControl = new System.Windows.Forms.TabControl();
            this.DiagnosisTabPage = new System.Windows.Forms.TabPage();
            this.HistoryTabPage = new System.Windows.Forms.TabPage();
            this.InfoNameLabel = new System.Windows.Forms.Label();
            this.InfoSurnameLabel = new System.Windows.Forms.Label();
            this.InfoGenderLabel = new System.Windows.Forms.Label();
            this.InfoDateLabel = new System.Windows.Forms.Label();
            this.NameInfoTextBox = new System.Windows.Forms.TextBox();
            this.SurnameInfoTextBox = new System.Windows.Forms.TextBox();
            this.GenderInfoTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DateInfoTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DiagnosisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HistoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.ImageButton = new System.Windows.Forms.Button();
            this.DiagnosisTabControl.SuspendLayout();
            this.DiagnosisTabPage.SuspendLayout();
            this.HistoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DiagnosisTabControl
            // 
            this.DiagnosisTabControl.Controls.Add(this.DiagnosisTabPage);
            this.DiagnosisTabControl.Controls.Add(this.HistoryTabPage);
            this.DiagnosisTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DiagnosisTabControl.Location = new System.Drawing.Point(0, 181);
            this.DiagnosisTabControl.Name = "DiagnosisTabControl";
            this.DiagnosisTabControl.SelectedIndex = 0;
            this.DiagnosisTabControl.Size = new System.Drawing.Size(761, 204);
            this.DiagnosisTabControl.TabIndex = 0;
            // 
            // DiagnosisTabPage
            // 
            this.DiagnosisTabPage.Controls.Add(this.DiagnosisRichTextBox);
            this.DiagnosisTabPage.Location = new System.Drawing.Point(4, 25);
            this.DiagnosisTabPage.Name = "DiagnosisTabPage";
            this.DiagnosisTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiagnosisTabPage.Size = new System.Drawing.Size(753, 175);
            this.DiagnosisTabPage.TabIndex = 0;
            this.DiagnosisTabPage.Text = "Диагноз";
            this.DiagnosisTabPage.UseVisualStyleBackColor = true;
            // 
            // HistoryTabPage
            // 
            this.HistoryTabPage.Controls.Add(this.HistoryRichTextBox);
            this.HistoryTabPage.Location = new System.Drawing.Point(4, 25);
            this.HistoryTabPage.Name = "HistoryTabPage";
            this.HistoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTabPage.Size = new System.Drawing.Size(513, 175);
            this.HistoryTabPage.TabIndex = 1;
            this.HistoryTabPage.Text = "История";
            this.HistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // InfoNameLabel
            // 
            this.InfoNameLabel.AutoSize = true;
            this.InfoNameLabel.Location = new System.Drawing.Point(13, 13);
            this.InfoNameLabel.Name = "InfoNameLabel";
            this.InfoNameLabel.Size = new System.Drawing.Size(43, 17);
            this.InfoNameLabel.TabIndex = 1;
            this.InfoNameLabel.Text = "Имя: ";
            // 
            // InfoSurnameLabel
            // 
            this.InfoSurnameLabel.AutoSize = true;
            this.InfoSurnameLabel.Location = new System.Drawing.Point(13, 43);
            this.InfoSurnameLabel.Name = "InfoSurnameLabel";
            this.InfoSurnameLabel.Size = new System.Drawing.Size(78, 17);
            this.InfoSurnameLabel.TabIndex = 2;
            this.InfoSurnameLabel.Text = "Фамилия: ";
            // 
            // InfoGenderLabel
            // 
            this.InfoGenderLabel.AutoSize = true;
            this.InfoGenderLabel.Location = new System.Drawing.Point(13, 73);
            this.InfoGenderLabel.Name = "InfoGenderLabel";
            this.InfoGenderLabel.Size = new System.Drawing.Size(42, 17);
            this.InfoGenderLabel.TabIndex = 3;
            this.InfoGenderLabel.Text = "Пол: ";
            // 
            // InfoDateLabel
            // 
            this.InfoDateLabel.AutoSize = true;
            this.InfoDateLabel.Location = new System.Drawing.Point(13, 104);
            this.InfoDateLabel.Name = "InfoDateLabel";
            this.InfoDateLabel.Size = new System.Drawing.Size(50, 17);
            this.InfoDateLabel.TabIndex = 5;
            this.InfoDateLabel.Text = "Дата: ";
            // 
            // NameInfoTextBox
            // 
            this.NameInfoTextBox.Location = new System.Drawing.Point(107, 13);
            this.NameInfoTextBox.Name = "NameInfoTextBox";
            this.NameInfoTextBox.Size = new System.Drawing.Size(214, 22);
            this.NameInfoTextBox.TabIndex = 6;
            // 
            // SurnameInfoTextBox
            // 
            this.SurnameInfoTextBox.Location = new System.Drawing.Point(107, 43);
            this.SurnameInfoTextBox.Name = "SurnameInfoTextBox";
            this.SurnameInfoTextBox.Size = new System.Drawing.Size(214, 22);
            this.SurnameInfoTextBox.TabIndex = 7;
            // 
            // GenderInfoTextBox
            // 
            this.GenderInfoTextBox.Location = new System.Drawing.Point(107, 73);
            this.GenderInfoTextBox.Name = "GenderInfoTextBox";
            this.GenderInfoTextBox.Size = new System.Drawing.Size(214, 22);
            this.GenderInfoTextBox.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 132);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(309, 43);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateInfoTimePicker
            // 
            this.DateInfoTimePicker.Location = new System.Drawing.Point(107, 104);
            this.DateInfoTimePicker.Name = "DateInfoTimePicker";
            this.DateInfoTimePicker.Size = new System.Drawing.Size(214, 22);
            this.DateInfoTimePicker.TabIndex = 12;
            // 
            // DiagnosisRichTextBox
            // 
            this.DiagnosisRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiagnosisRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.DiagnosisRichTextBox.Name = "DiagnosisRichTextBox";
            this.DiagnosisRichTextBox.Size = new System.Drawing.Size(747, 169);
            this.DiagnosisRichTextBox.TabIndex = 0;
            this.DiagnosisRichTextBox.Text = "";
            // 
            // HistoryRichTextBox
            // 
            this.HistoryRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.HistoryRichTextBox.Name = "HistoryRichTextBox";
            this.HistoryRichTextBox.Size = new System.Drawing.Size(507, 169);
            this.HistoryRichTextBox.TabIndex = 0;
            this.HistoryRichTextBox.Text = "";
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Location = new System.Drawing.Point(327, 12);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(100, 114);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPictureBox.TabIndex = 13;
            this.InfoPictureBox.TabStop = false;
            // 
            // ImageButton
            // 
            this.ImageButton.Location = new System.Drawing.Point(327, 133);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(103, 42);
            this.ImageButton.TabIndex = 14;
            this.ImageButton.Text = "Обновить фото";
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 385);
            this.Controls.Add(this.ImageButton);
            this.Controls.Add(this.InfoPictureBox);
            this.Controls.Add(this.DateInfoTimePicker);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GenderInfoTextBox);
            this.Controls.Add(this.SurnameInfoTextBox);
            this.Controls.Add(this.NameInfoTextBox);
            this.Controls.Add(this.InfoDateLabel);
            this.Controls.Add(this.InfoGenderLabel);
            this.Controls.Add(this.InfoSurnameLabel);
            this.Controls.Add(this.InfoNameLabel);
            this.Controls.Add(this.DiagnosisTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformationForm";
            this.Text = "Информация о пациенте";
            this.DiagnosisTabControl.ResumeLayout(false);
            this.DiagnosisTabPage.ResumeLayout(false);
            this.HistoryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl DiagnosisTabControl;
        private System.Windows.Forms.TabPage DiagnosisTabPage;
        private System.Windows.Forms.TabPage HistoryTabPage;
        private System.Windows.Forms.Label InfoNameLabel;
        private System.Windows.Forms.Label InfoSurnameLabel;
        private System.Windows.Forms.Label InfoGenderLabel;
        private System.Windows.Forms.Label InfoDateLabel;
        private System.Windows.Forms.TextBox NameInfoTextBox;
        private System.Windows.Forms.TextBox SurnameInfoTextBox;
        private System.Windows.Forms.TextBox GenderInfoTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker DateInfoTimePicker;
        private System.Windows.Forms.RichTextBox DiagnosisRichTextBox;
        private System.Windows.Forms.RichTextBox HistoryRichTextBox;
        private System.Windows.Forms.PictureBox InfoPictureBox;
        private System.Windows.Forms.Button ImageButton;
    }
}