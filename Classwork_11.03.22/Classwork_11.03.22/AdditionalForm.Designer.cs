
namespace Classwork_11._03._22
{
    partial class AdditionalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.PatientTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PatientPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.DiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.GenderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(12, 49);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(88, 20);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(106, 10);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(177, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(106, 50);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(177, 22);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRB);
            this.GenderGroupBox.Controls.Add(this.MaleRB);
            this.GenderGroupBox.Location = new System.Drawing.Point(16, 122);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(267, 81);
            this.GenderGroupBox.TabIndex = 4;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Пол";
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Location = new System.Drawing.Point(140, 33);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(88, 21);
            this.FemaleRB.TabIndex = 1;
            this.FemaleRB.TabStop = true;
            this.FemaleRB.Text = "Женский";
            this.FemaleRB.UseVisualStyleBackColor = true;
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Location = new System.Drawing.Point(39, 33);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(86, 21);
            this.MaleRB.TabIndex = 0;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Мужской";
            this.MaleRB.UseVisualStyleBackColor = true;
            // 
            // PatientTimePicker
            // 
            this.PatientTimePicker.Location = new System.Drawing.Point(16, 214);
            this.PatientTimePicker.Name = "PatientTimePicker";
            this.PatientTimePicker.Size = new System.Drawing.Size(267, 22);
            this.PatientTimePicker.TabIndex = 5;
            // 
            // PatientPictureBox
            // 
            this.PatientPictureBox.Location = new System.Drawing.Point(304, 10);
            this.PatientPictureBox.Name = "PatientPictureBox";
            this.PatientPictureBox.Size = new System.Drawing.Size(184, 193);
            this.PatientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatientPictureBox.TabIndex = 6;
            this.PatientPictureBox.TabStop = false;
            // 
            // PictureButton
            // 
            this.PictureButton.Location = new System.Drawing.Point(304, 210);
            this.PictureButton.Name = "PictureButton";
            this.PictureButton.Size = new System.Drawing.Size(184, 26);
            this.PictureButton.TabIndex = 7;
            this.PictureButton.Text = "Добавить фото";
            this.PictureButton.UseVisualStyleBackColor = true;
            this.PictureButton.Click += new System.EventHandler(this.PictureButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(304, 289);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(184, 40);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(304, 242);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(184, 40);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Сохранить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiagnosisLabel.Location = new System.Drawing.Point(12, 89);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(80, 20);
            this.DiagnosisLabel.TabIndex = 10;
            this.DiagnosisLabel.Text = "Диагноз";
            // 
            // DiagnosisTextBox
            // 
            this.DiagnosisTextBox.Location = new System.Drawing.Point(106, 89);
            this.DiagnosisTextBox.Name = "DiagnosisTextBox";
            this.DiagnosisTextBox.Size = new System.Drawing.Size(177, 22);
            this.DiagnosisTextBox.TabIndex = 11;
            // 
            // AdditionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 337);
            this.Controls.Add(this.DiagnosisTextBox);
            this.Controls.Add(this.DiagnosisLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PictureButton);
            this.Controls.Add(this.PatientPictureBox);
            this.Controls.Add(this.PatientTimePicker);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalForm";
            this.Text = "Добавление пациента";
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton FemaleRB;
        private System.Windows.Forms.RadioButton MaleRB;
        private System.Windows.Forms.DateTimePicker PatientTimePicker;
        private System.Windows.Forms.PictureBox PatientPictureBox;
        private System.Windows.Forms.Button PictureButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox DiagnosisTextBox;
    }
}