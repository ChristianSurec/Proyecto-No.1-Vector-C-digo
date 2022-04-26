using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_No._1_Vector_Código
{
    public partial class FormGenerar : Form
    {
        List<Codigo> codigos = new List<Codigo>(); 
        List<Verificador> verificadores = new List<Verificador>();
        public FormGenerar()
        {
            InitializeComponent();
        }
        public void GuardarCodigo()
        {
            FileStream stream = new FileStream("Nuevo Carné.txt", FileMode.OpenOrCreate, FileAccess.Write);         
            StreamWriter writer = new StreamWriter(stream);


            foreach (Codigo codigo in codigos)
            {
                writer.WriteLine(codigo.valor1);
                writer.WriteLine(codigo.valor2);
                writer.WriteLine(codigo.valor3);
                writer.WriteLine(codigo.valor4);
                writer.WriteLine(codigo.valor5);
                writer.WriteLine(codigo.valor6);
                writer.WriteLine(codigo.valor7);
                writer.WriteLine(codigo.valor8);
                writer.WriteLine(codigo.valor9);
                writer.WriteLine(codigo.valor10);
                writer.WriteLine(codigo.salto);
                
            }
            writer.Close();
        }
        private void GuardarVerificador()
        {
            FileStream stream = new FileStream("Código Verificador.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);


            foreach (Verificador verificar in verificadores)
            {
                writer.WriteLine(verificar.val1);
                writer.WriteLine(verificar.val2);
                writer.WriteLine(verificar.val3);
                writer.WriteLine(verificar.val4);
                writer.WriteLine(verificar.val5);
                writer.WriteLine(verificar.val6);
                writer.WriteLine(verificar.val7);
                writer.WriteLine(verificar.val8);
                writer.WriteLine(verificar.val9);
                writer.WriteLine(verificar.val10);

            }
            writer.Close();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////// Carné
            int uno, dos, tres, cuatro, cinco, seis, siete, ocho, nueve;
            Codigo codigo = new Codigo();
            Verificador verificar = new Verificador();
            uno = Convert.ToInt16(textBox1.Text);
            dos = Convert.ToInt16(textBox2.Text);
            tres = Convert.ToInt16(textBox3.Text);
            cuatro = Convert.ToInt16(textBox4.Text);    
            cinco = Convert.ToInt16(textBox5.Text);
            seis = Convert.ToInt16(textBox6.Text);  
            siete = Convert.ToInt16(textBox7.Text);
            ocho = Convert.ToInt16(textBox8.Text);  
            nueve = Convert.ToInt16(textBox9.Text);
            
            codigo.valor1 = uno;
            codigo.valor2 = dos;
            codigo.valor3 = tres;   
            codigo.valor4 = cuatro;
            codigo.valor5 = cinco;
            codigo.valor6 = seis;
            codigo.valor7 = siete;
            codigo.valor8 = ocho;
            codigo.valor9 = nueve;
           
            //////////////////////////////////////Vector de control
            int a, b, c, d, ei, f, g, h, i, j;
            a = Convert.ToInt16(textBox18.Text);
            b = Convert.ToInt16(textBox17.Text);
            c = Convert.ToInt16(textBox16.Text);
            d = Convert.ToInt16(textBox15.Text);
            ei = Convert.ToInt16(textBox14.Text);
            f = Convert.ToInt16(textBox13.Text);
            g = Convert.ToInt16(textBox12.Text);
            h = Convert.ToInt16(textBox11.Text);
            i = Convert.ToInt16(textBox10.Text);
            j = Convert.ToInt16(textBox19.Text);
            verificar.val1 = a;
            verificar.val2 = b; 
            verificar.val3 = c;
            verificar.val4 = d;
            verificar.val5 = ei;
            verificar.val6 = f;
            verificar.val7 = g;
            verificar.val8 = h;
            verificar.val9 = i;
            verificar.val10 = j;
            verificadores.Add(verificar);
            GuardarVerificador();

            ///////////////////////////////////////Calcular
            ///
            int calcular = (uno * a) + (dos * b) + (tres * c) + (cuatro * d) + (cinco * ei) + (seis * f) + (siete * g) + (ocho * h) + (nueve * i);
            int digito = 0, resultado = 0;
            string salto = "--------------";
            if(calcular <= 10)
            {
                digito = 10;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: "+resultado);
                MessageBox.Show("Nuevo Carné: "+uno+dos+tres+cuatro+cinco+seis+siete+ocho+nueve+resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 11 && calcular <= 20)
            {
                digito = 20;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 21 && calcular <= 30)
            {
                digito = 30;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 31 && calcular <= 40)
            {
                digito = 40;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 41 && calcular <= 50)
            {
                digito = 50;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 51 && calcular <= 60)
            {
                digito = 60;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 61 && calcular <= 70)
            {
                digito = 70;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 71 && calcular <= 80)
            {
                digito = 80;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 81 && calcular <= 90)
            {
                digito = 90;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            if (calcular >= 91 && calcular <= 100)
            {
                digito = 100;
                resultado = digito - calcular;
                MessageBox.Show("Dígito verificador es: " + resultado);
                MessageBox.Show("Nuevo Carné: " + uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + resultado);
                codigo.valor1 = uno;
                codigo.valor2 = dos;
                codigo.valor3 = tres;
                codigo.valor4 = cuatro;
                codigo.valor5 = cinco;
                codigo.valor6 = seis;
                codigo.valor7 = siete;
                codigo.valor8 = ocho;
                codigo.valor9 = nueve;
                codigo.valor10 = resultado;
                codigo.salto = salto;
                codigos.Add(codigo);
                GuardarCodigo();

            }
            Reiniciar();
        }
        private void Reiniciar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            textBox18.Text = "2";
            textBox17.Text = "1";
            textBox16.Text = "2";
            textBox15.Text = "1";
            textBox14.Text = "2";
            textBox13.Text = "1";
            textBox12.Text = "2";
            textBox11.Text = "1";
            textBox10.Text = "2";
            checkBox1.Checked = false;
            

        }

        private void FormGenerar_Load(object sender, EventArgs e)
        {
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox16.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                
            }
            else if(checkBox1.Checked == true)
            {
                textBox10.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
                textBox15.Enabled = true;
                textBox16.Enabled = true;
                textBox17.Enabled = true;
                textBox18.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
