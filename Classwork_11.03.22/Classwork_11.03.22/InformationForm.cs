using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork_11._03._22
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        public new string Name
        {
            get { return NameInfoTextBox.Text; }
            set { NameInfoTextBox.Text = value; }
        }
        public string Surname
        {
            get { return SurnameInfoTextBox.Text; }
            set { SurnameInfoTextBox.Text = value; }
        }
        public string Diagnosis
        {
            get { return DiagnosisRichTextBox.Text; }
            set { DiagnosisRichTextBox.Text = value; }
        }
        public string Gender
        {
            get { return GenderInfoTextBox.Text; }
            set { GenderInfoTextBox.Text = value; }
        }
        public DateTime Date
        {
            get { return DateInfoTimePicker.Value; }
            set { DateInfoTimePicker.Value = value; }
        }
        public string History
        {
            get { return HistoryRichTextBox.Text; }
            set { HistoryRichTextBox.Text = value; }
        }
        public Image Photo
        {
            get { return InfoPictureBox.Image; }
            set { InfoPictureBox.Image = value; }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.DialogResult = DialogResult.OK;
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                InfoPictureBox.Image = Image.FromFile(fileDialog.FileName);
            }
        }
    }
}
