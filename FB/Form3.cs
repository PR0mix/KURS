using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FB
{
    public partial class Form3 : Form
    {
        Form1 f;
        public Form3(Form1 f1)
        {
            f = f1;
            InitializeComponent();
            for (int i = 0; i < f.n; i++)
            {
                comboBox1.Items.Add(f.Company[i].cn());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number= comboBox1.SelectedIndex;
            
         
            for (int i = number; i < f.n; i++)
            {
                f.Company[i] = f.Company[i + 1];

            }
            f.dataGridView1.Rows.Clear();
            for (int i = 0; i < f.n-1; i++)
            {
                f.dataGridView1.Rows.Add(i+1, f.Company[i].cn(), f.Company[i].sp(), f.Company[i].ns(), f.Company[i].ys(), f.Company[i].vc());
            }
            f.n--;
            Form3 newform = new Form3(f);
            newform.Show();
            this.Close();
        }

    }
}
