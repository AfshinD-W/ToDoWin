using System;
using System.Windows.Forms;

namespace ToDoWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("لطفاً یک تسک وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("لطفاً یک تسک برای حذف انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
