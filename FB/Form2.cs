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
    public partial class Form2 : Form
    {
        Form1 f;
        public Form2(Form1 f1)
        {
            this.f = f1;
            InitializeComponent();
        }

   

    private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != " ") && (textBox3.Text != " ") && (textBox4.Text != " "))
            {
                string cn = textBox1.Text;
                float sp = float.Parse(textBox2.Text);
                int ns = int.Parse(textBox3.Text);
                int ys = int.Parse(textBox4.Text);
                bool flag = true;
                for (int i=0;i<f.n;i++)
                {
                    if (f.Company[i].cn() == cn) flag = false;
                }
                if (flag)
                {
                    f.Company[f.n] = new AnyCompany(cn, sp, ns, ys);
                    f.n++;
                    f.dataGridView1.Rows.Add(f.n, cn, sp, ns, ys, f.Company[f.n - 1].vc());
                    label5.Text = "Компанію добавлено";
                }
                else label5.Text = "Компанія з даним ім'ям вже є в базі";
            }
            else label5.Text = "Перевірте правильність введення даних";
        }

       
    }
}
