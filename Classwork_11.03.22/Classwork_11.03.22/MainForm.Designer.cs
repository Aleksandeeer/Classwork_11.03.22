
namespace Classwork_11._03._22
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.PatientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PatientGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.AddButton);
            this.splitContainer1.Size = new System.Drawing.Size(860, 498);
            this.splitContainer1.SplitterDistance = 438;
            this.splitContainer1.TabIndex = 0;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.SurnameColumn,
            this.GenderColumn,
            this.DiagnosisColumn});
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowHeadersVisible = false;
            this.MainDataGridView.RowHeadersWidth = 51;
            this.MainDataGridView.RowTemplate.Height = 24;
            this.MainDataGridView.Size = new System.Drawing.Size(438, 498);
            this.MainDataGridView.TabIndex = 0;
            this.MainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataGridView_CellContentClick);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Пол";
            this.GenderColumn.MinimumWidth = 6;
            this.GenderColumn.Name = "GenderColumn";
            // 
            // DiagnosisColumn
            // 
            this.DiagnosisColumn.HeaderText = "Диагноз";
            this.DiagnosisColumn.MinimumWidth = 6;
            this.DiagnosisColumn.Name = "DiagnosisColumn";
            // 
            // PatientGroupBox
            // 
            this.PatientGroupBox.Controls.Add(this.InfoButton);
            this.PatientGroupBox.Controls.Add(this.DateLabel);
            this.PatientGroupBox.Controls.Add(this.DiagnosisLabel);
            this.PatientGroupBox.Controls.Add(this.GenderLabel);
            this.PatientGroupBox.Controls.Add(this.SurnameLabel);
            this.PatientGroupBox.Controls.Add(this.NameLabel);
            this.PatientGroupBox.Controls.Add(this.MainPictureBox);
            this.PatientGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientGroupBox.Location = new System.Drawing.Point(0, 46);
            this.PatientGroupBox.Name = "PatientGroupBox";
            this.PatientGroupBox.Size = new System.Drawing.Size(418, 207);
            this.PatientGroupBox.TabIndex = 1;
            this.PatientGroupBox.TabStop = false;
            this.PatientGroupBox.Text = "Пациент";
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(188, 167);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(218, 33);
            this.InfoButton.TabIndex = 6;
            this.InfoButton.Text = "Информация";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(186, 100);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(50, 17);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Дата: ";
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.Location = new System.Drawing.Point(186, 80);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(71, 17);
            this.DiagnosisLabel.TabIndex = 4;
            this.DiagnosisLabel.Text = "Диагноз: ";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(185, 60);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 17);
            this.GenderLabel.TabIndex = 3;
            this.GenderLabel.Text = "Пол: ";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(185, 40);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(78, 17);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(185, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Имя:";
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(7, 21);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(161, 180);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(418, 46);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить нового";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 498);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Пациенты";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.PatientGroupBox.ResumeLayout(false);
            this.PatientGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisColumn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox PatientGroupBox;
        public System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button InfoButton;
    }
}

