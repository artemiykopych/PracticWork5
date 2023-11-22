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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 3, m = 3;
            Arrays2D twoDimArray = new Arrays2D(n, m);

            try {
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = twoDimArray.X_length;
                dataGridView1.ColumnCount = twoDimArray.Y_length;

                for (int i = 0; i < twoDimArray.X_length; i++)
                {
                    for (int j = 0; j < twoDimArray.Y_length; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = twoDimArray[i, j].ToString();
                    }
                }

                var result = twoDimArray.Sum;
                label3.Text = result.Item1.ToString();
                label1.Text = result.Item2.ToString();
                label2.Text = result.Item3.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
