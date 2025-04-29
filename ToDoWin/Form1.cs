using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ToDoWin
{
    public partial class Form1 : Form
    {
        string filePath = "tasks.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
                SaveTasks();
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
                SaveTasks();
            }
            else
            {
                MessageBox.Show("لطفاً یک تسک برای حذف انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string[] tasks = File.ReadAllLines(filePath);
                lstTasks.Items.AddRange(tasks);
            }
        }

        private void SaveTasks()
        {
            List<string> tasks = new List<string>();
            foreach (var item in lstTasks.Items)
            {
                tasks.Add(item.ToString());
            }
            File.WriteAllLines(filePath, tasks);
        }
    }
}
