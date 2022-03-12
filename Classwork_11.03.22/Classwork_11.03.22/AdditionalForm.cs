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
    public partial class AdditionalForm : Form
    {
        public AdditionalForm()
        {
            InitializeComponent();
        }

        //Свойства для получения данных о пациенте (вся логика идёт через основную форму)
        public new string Name
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }
        public string Surname => SurnameTextBox.Text;
        public string Diagnosis => DiagnosisTextBox.Text;
        public bool MaleGender => MaleRB.Checked;
        public bool FemaleGender => FemaleRB.Checked;
        public Image Image => PatientPictureBox.Image;
        public DateTime Date => PatientTimePicker.Value;
        private void PictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                PatientPictureBox.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Чтобы можно было призвать ShowDialog без логики в другой форме
        private void OkButton_Click(object sender, EventArgs e)
        {
            OkButton.DialogResult = DialogResult.OK;
        }
    }
}
