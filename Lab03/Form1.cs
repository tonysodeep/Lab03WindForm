using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        Student model = new Student();
        List<Student> listStudent;
        StudentContextDB context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                context = new StudentContextDB();
                List<Faculty> listFaculty = context.Faculties.ToList();
                listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFaculty);
                BindGrid(listStudent);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cb_nganh.DataSource = listFalcultys;
            this.cb_nganh.DisplayMember = "FacultyName";
            this.cb_nganh.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgMain.Rows.Clear();
            foreach(var item in listStudent)
            {
                int index = dgMain.Rows.Add();
                dgMain.Rows[index].Cells[0].Value = item.StudentID;
                dgMain.Rows[index].Cells[1].Value = item.FullName;
                dgMain.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgMain.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            model.StudentID = tb_ms.Text.Trim();
            model.FullName = tb_ms.Text.Trim();
            if (cb_nganh.SelectedValue.ToString() == "1")
            {
                model.FacultyID = 1;
            }
            if (cb_nganh.SelectedValue.ToString() == "2")
            {
                model.FacultyID = 2;
            }
            if (cb_nganh.SelectedValue.ToString() == "3")
            {
                model.FacultyID = 3;
            }

            model.AverageScore = Convert.ToDouble(tb_diem.Text);

            context.Students.Add(model);
            context.SaveChanges();
            listStudent.Add(model);
            BindGrid(listStudent);
            MessageBox.Show("Add Success");

        }

        private void bt_fix_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_nganh.SelectedValue.ToString());
        }
    }
}
