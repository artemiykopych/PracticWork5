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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArraysAB a = new ArraysAB(100);
            FileWrite f = new FileWrite();
            FileRead f2 = new FileRead();
            ShowArray show = new ShowArray();
            string patch = @"1.txt";
            string patch1 = @"2.txt";
            f2.read(patch, a);
            a.calculate();
            f.write(patch1, a);
            Masiv.Text = show.writeArray(a.a);
            Result.Text = show.writeArray(a.b);
        }
    }
}
