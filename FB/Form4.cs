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
    public partial class Form4 : Form
    {
        Form1 f;
        public Form4(Form1 f1)
        {
            InitializeComponent();
            this.f = f1;
            label4.Text = "Ваш баланс: " + f.balance.ToString();
            for (int i = 0; i < f.n; i++)
            {
                comboBox1.Items.Add(f.Company[i].cn());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int op = comboBox2.SelectedIndex;
            int company = comboBox1.SelectedIndex+1;

            int klshares = Int32.Parse(textBox1.Text);

            if (op == 0)
            {
                if (klshares <= f.Company[company - 1].ns() - f.Company[company - 1].ys())
                {
                    double var = klshares * f.Company[company - 1].sp();
                    if (f.balance >= var)
                    {
                        f.balance = f.balance - var;
                        f.Company[company - 1].YouShares = f.Company[company - 1].YouShares + klshares;
                        label3.Text = "Виконано";
                        label4.Text = "Ваш баланс: " + f.balance.ToString();
                    }
                    else label3.Text = "Недостатньо коштів на рахунку";
                }
                else label3.Text = "Перевищено кількість акцій для купівлі";
            }
            if (op == 1)
            {
                if (klshares <= f.Company[company - 1].ys())
                {
                    f.Company[company - 1].YouShares = f.Company[company - 1].YouShares - klshares;
                    f.balance = f.balance + klshares * f.Company[company - 1].sp(); ;
                    label3.Text = "Виконано";
                    label4.Text = "Ваш баланс: " + f.balance.ToString();

                }
                else label3.Text = "Недостатньо кількість акцій цієї компанії";

            }

            f.dataGridView1.Rows.Clear();
            for (int i = 0; i < f.n ; i++)
            {
                f.dataGridView1.Rows.Add(i + 1, f.Company[i].cn(), f.Company[i].sp(), f.Company[i].ns(), f.Company[i].ys(), f.Company[i].vc());
            }
        }
    }
}
