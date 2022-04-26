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
    public partial class FormVerificar : Form
    {
        List<Codigo> codigos = new List<Codigo>();
        List<Verificador> verificadores = new List<Verificador>();
       
        private void LeerCódigo()
        {
            FileStream stream = new FileStream("Nuevo Carné.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            
            while (reader.Peek() > -1)
           
            {
                Codigo codigo = new Codigo();
                codigo.valor1 = Convert.ToInt32(reader.ReadLine());
                codigo.valor2 = Convert.ToInt32(reader.ReadLine());
                codigo.valor3 = Convert.ToInt32(reader.ReadLine());
                codigo.valor4 = Convert.ToInt32(reader.ReadLine());
                codigo.valor5 = Convert.ToInt32(reader.ReadLine());
                codigo.valor6 = Convert.ToInt32(reader.ReadLine());
                codigo.valor7 = Convert.ToInt32(reader.ReadLine());
                codigo.valor8 = Convert.ToInt32(reader.ReadLine());
                codigo.valor9 = Convert.ToInt32(reader.ReadLine());
                codigo.valor10 = Convert.ToInt32(reader.ReadLine());
                codigo.salto = reader.ReadLine();
                codigos.Add(codigo);

            }
            
            reader.Close();
        }
       
        public FormVerificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerCódigo();
            
            /////////////////////////////////////// Carné
            int uno, dos, tres, cuatro, cinco, seis, siete, ocho, nueve,verificador;
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
            verificador = Convert.ToInt16(textBox10.Text);


            Boolean valor = true;
            for(int i = 0; i < codigos.Count; i++)
            {
                if(codigos[i].valor1 == uno && codigos[i].valor2 == dos && codigos[i].valor3 == tres && codigos[i].valor4 == cuatro && codigos[i].valor5 == cinco && codigos[i].valor6 == seis && codigos[i].valor7 == siete && codigos[i].valor8 == ocho && codigos[i].valor9 == nueve && codigos[i].valor10 == verificador)
                {
                    valor = true;
                    

                }
                else
                {
                    valor = false;
                   
                }

                


            }
            if (valor == true)
            {
                BackColor = Color.Green;
                MessageBox.Show("Codigo Correcto");
                BackColor = Color.White;
                Limpiar();

            }
            if (valor == false)
                {
                    BackColor = Color.Red;
                    MessageBox.Show("Codigo Incorrecto");
                    Limpiar();
                    BackColor = Color.White;
                }

        }
        private void Limpiar()
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
            textBox10.Text = "";
        }

        private void FormVerificar_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
