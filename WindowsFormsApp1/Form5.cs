using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        Toys people = new Toys();
        string path = "data.txt";

        public void show (DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Toy p in people.toys)
            {
                dg.Rows.Add(p.Name, p.Price, p.AgeR);
            }
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void Form5_Activated(object sender, EventArgs e)
        {
            Size = new Size(800, 550);
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var person = new Toy(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                people.add(person);
                dataGridView2.Rows.Add(people.toys[people.toys.Count - 1].Name, people.toys[people.toys.Count - 1].Price, people.toys[people.toys.Count - 1].AgeR);
            }
            catch { MessageBox.Show("помилка у вхідних даних"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            people.writeFile(path);
            MessageBox.Show("Дані записані");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            people.readFile(path);
            show(dataGridView2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var i = dataGridView2.CurrentRow.Index;
            people.remove(i);
            show(dataGridView2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            people.sort();
            show(dataGridView3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            people.toys.Sort();
            dataGridView1.Rows.Clear();

            foreach (Toy p in people.toys)
            {
                if (p.Price > Convert.ToInt32(textBox4.Text))
                {
                    dataGridView1.Rows.Add(p.Name, p.Price, p.AgeR);
                }
            }
        }
    }
}
