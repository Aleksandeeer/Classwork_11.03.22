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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int buffer;
        int number;
        List<Patient> patients = new List<Patient>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            AdditionalForm addForm = new AdditionalForm();

            try
            {
                if (addForm.ShowDialog().Equals(DialogResult.OK))
                {
                    buffer = MainDataGridView.Rows.Count;
                    patients.Add(new Patient
                    {
                        Name = addForm.Name,
                        Surname = addForm.Surname,
                        Diagnosis = addForm.Diagnosis,
                        Date = addForm.Date,
                        Photo = addForm.Image
                    });

                    if (addForm.MaleGender && !addForm.FemaleGender)
                    {
                        patients[buffer - 1].Gender = "М";
                    }
                    else if (!addForm.MaleGender && addForm.FemaleGender)
                    {
                        patients[buffer - 1].Gender = "Ж";
                    }
                    else
                    {
                        patients[buffer - 1].Gender = "-";
                    }

                    MainDataGridView.Rows.Add(buffer, addForm.Name, addForm.Surname, patients[buffer - 1].Gender, addForm.Diagnosis);
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля.", "Ошибка");
            }
        }

        //Нажатие на человека в DataGridView
        private void MainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Уточнение: надо нажимать именно на текст (если нажать на заполненую ячейка по её пустой области, то ничего не произойдёт)
            number = MainDataGridView.CurrentCell.RowIndex;

            NameLabel.Text = "Имя: " + patients[number].Name;
            SurnameLabel.Text = "Фамилия: " + patients[number].Surname;
            GenderLabel.Text = "Пол: " + patients[number].Gender;
            DiagnosisLabel.Text = "Диагноз: " + patients[number].Diagnosis;
            DateLabel.Text = "Дата: " + patients[number].Date.ToShortDateString();
            MainPictureBox.Image = patients[number].Photo;
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Если не выбран пациент, то number = null => выйдет ошибка
                InformationForm infoForm = new InformationForm
                {
                    Name = patients[number].Name,
                    Surname = patients[number].Surname,
                    Gender = patients[number].Gender,
                    Diagnosis = patients[number].Diagnosis,
                    Date = patients[number].Date,
                    History = patients[number].History,
                    Photo = patients[number].Photo
                };

                if (infoForm.ShowDialog() == DialogResult.OK)
                {
                    patients[number].Name = infoForm.Name;
                    patients[number].Surname = infoForm.Surname;
                    patients[number].Gender = infoForm.Gender;
                    patients[number].Diagnosis = infoForm.Diagnosis;
                    patients[number].Date = infoForm.Date;
                    patients[number].History = infoForm.History;
                    patients[number].Photo = infoForm.Photo;

                    MainDataGridView.Rows[number].SetValues(patients[number].Id, patients[number].Name, patients[number].Surname,
                        patients[number].Gender, patients[number].Diagnosis);

                    NameLabel.Text = "Имя: " + patients[number].Name;
                    SurnameLabel.Text = "Фамилия: " + patients[number].Surname;
                    GenderLabel.Text = "Пол: " + patients[number].Gender;
                    DiagnosisLabel.Text = "Диагноз: " + patients[number].Diagnosis;
                    DateLabel.Text = "Дата: " + patients[number].Date.ToShortDateString();
                    MainPictureBox.Image = patients[number].Photo;
                }
            }
            catch
            {
                MessageBox.Show("Выберите пациента или добавьте нового", "Ошибка");
            }
        }
    }
}
