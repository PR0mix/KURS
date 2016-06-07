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
    
    public partial class Form1 : Form
    {
        public AnyCompany[] Company = new AnyCompany[100];
        public int n = 0;
        public double balance = 10000;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Ваш баланс: " + balance.ToString();
        }
       
        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

        }

        private void deleteCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for(int i=0;i< n;i++)
            {
                Company[i].nextday();
                dataGridView1.Rows.Add(i + 1, Company[i].cn(), Company[i].sp(), Company[i].ns(), Company[i].ys(),Company[i].vc());

            }
        }

        private void купівляПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.Show();

        }

       
    }
}
