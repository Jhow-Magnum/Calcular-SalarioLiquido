using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calcular_Salario_Liquido
{
    public partial class Form1 : Form
    {
        List<ClassListaCalculos> lista = new List<ClassListaCalculos> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
           
            string nome = txt_nome.Text;
            double slb = double.Parse(txt_slb.Text);
            double outros_desc = double.Parse(txt_desc.Text);
            double dep = int.Parse(txt_dep.Text) * 189.59;

            double inss = ClassSalarios.CalcularINSS(slb);

            double saldoSL = slb - inss - dep;
            double irrf = ClassSalarios.CalcularIRRF(saldoSL);

            double sll = slb - inss - irrf - outros_desc;

            txt_inss.Text = inss.ToString("c");
            txt_irrf.Text = irrf.ToString("c");
            txt_sliq.Text = sll.ToString("c");


            lista.Add(new ClassListaCalculos(nome, slb, outros_desc, dep, inss, irrf, sll));


        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ClassListaCalculos item in lista)
            {
                MessageBox.Show($"{item.nome} Salário Liquido: {item.sll.ToString("c")}");

            }
        }
    }
}
