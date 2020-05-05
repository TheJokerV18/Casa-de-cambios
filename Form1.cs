using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDeCambio

  
{
    public partial class Form1 : Form
    {
        double dolar = 0, libra = 0, euro = 0, peso = 0, fondosDolar = 0, fondosLibra = 0, fondosEuro = 0;

        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

            euro = double.Parse(textBox2.Text);

            peso = euro * 4.354;

            textBox4.Text = (peso + " Pesos").ToString();

            textBox5.Text = (peso + " Pesos").ToString();


            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }


        }
        private void button6_Click(object sender, EventArgs e)
        {
                try
                {
                 euro = double.Parse(textBox2.Text);

                 dolar = euro * 1.10;

                   textBox4.Text = (dolar + " Dolares").ToString();

                  textBox5.Text = (euro * 4.354 + " Pesos").ToString();
            }
            catch (Exception ex)
            {
                 textBox4.Text = ex.Message;

            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
        try
         {
            euro = double.Parse(textBox2.Text);

            libra = euro * 0.88;

            textBox4.Text = (libra + " Libras").ToString();

            textBox5.Text = (euro * 4.354 + " Pesos").ToString();
            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
          try
            {

            dolar = double.Parse(textBox1.Text);

            peso = dolar * 3.957 ;

            textBox4.Text = (peso+" Pesos").ToString();

           textBox5.Text = (dolar * 3.957 + " Pesos").ToString();

            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }


        }

       

        private void button4_Click(object sender, EventArgs e)
        {
        try
         {
            dolar = double.Parse(textBox1.Text);

            euro = dolar * 0.91;

            textBox4.Text = (euro + " Euros").ToString();
           textBox5.Text = (dolar * 3.957 + " Pesos").ToString();

            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }



        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dolar = double.Parse(textBox1.Text);

            libra = dolar * 0.80;

                textBox4.Text = (libra + " Libras").ToString();
                textBox5.Text = (dolar * 3.957 + " Pesos").ToString();
            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
          try
             {
                    libra = double.Parse(textBox3.Text);

            peso = libra * 4.966;

            textBox4.Text = (peso + " Pesos").ToString();
           textBox5.Text = (libra * 4.966 + " Pesos").ToString();

            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }

        }

        

        private void button8_Click(object sender, EventArgs e)
        {
          try
            {
             libra = double.Parse(textBox3.Text);

            dolar = libra * 1.25;

            textBox4.Text = (dolar + " Dolares").ToString();
             textBox5.Text = (libra * 4.966 + " Pesos").ToString();
            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }


        }

      

        private void button9_Click(object sender, EventArgs e)
        {
         try
          {
            libra = double.Parse(textBox3.Text);

            euro = libra * 1.14;

            textBox4.Text = (euro + " Euros").ToString();
            textBox5.Text = (libra * 4.966 + " Pesos").ToString();
            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
           
            try
            {
                fondosDolar = double.Parse(textBox6.Text);
                dolar = double.Parse(textBox9.Text);

                if (dolar <= fondosDolar)
                {
                    peso = dolar * 3.957;

                    textBox12.Text = (peso +" Pesos").ToString();

                    textBox13.Text = (dolar * 3.957 + " Pesos").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
              {
                textBox4.Text = ex.Message;

               }

        }

      

        private void button13_Click(object sender, EventArgs e)
        {

            try
            {
                fondosDolar = double.Parse(textBox6.Text);
                dolar = double.Parse(textBox9.Text);

                if (dolar <= fondosDolar)
                {
                    euro = dolar * 0.91;

                    textBox12.Text = (euro + " Euros").ToString();
                    textBox13.Text = (dolar * 3.957 + " Pesos").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }

        }

       

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                fondosDolar = double.Parse(textBox6.Text);
                dolar = double.Parse(textBox9.Text);

                if (dolar <= fondosDolar)
                {
                    libra = dolar * 0.80;

                    textBox12.Text = (libra + " Libras").ToString();

                    textBox13.Text = (dolar * 3.957 + " Pesos").ToString();
                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }




        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                fondosEuro = double.Parse(textBox7.Text);
                euro = double.Parse(textBox10.Text);

                if (euro <= fondosEuro)
                {
                    peso = euro * 4.354;

                    textBox12.Text = (peso + " Pesos").ToString();
                    textBox13.Text = (euro * 4.354 + " Euros").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }

        
    }


        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                fondosEuro = double.Parse(textBox7.Text);
                euro = double.Parse(textBox10.Text);

                if (euro <= fondosEuro)
                {
                    dolar = euro * 1.10;

                    textBox12.Text = (dolar + " Dolares").ToString();
                    textBox13.Text = (euro * 4.354 + " Euros").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                fondosEuro = double.Parse(textBox7.Text);
                euro = double.Parse(textBox10.Text);

                if (euro <= fondosEuro)
                {
                    libra = euro * 0.88;

                    textBox12.Text = (libra + " Libras").ToString();
                    textBox13.Text = (euro * 4.354 + " Euros").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }


        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                fondosLibra = double.Parse(textBox8.Text);
                libra = double.Parse(textBox11.Text);

                if (libra <= fondosLibra)
                {
                    peso = libra * 4.966;

                    textBox12.Text = (peso + " Pesos").ToString();
                    textBox13.Text = (libra * 4.966 + " Pesos").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                fondosLibra = double.Parse(textBox8.Text);
                libra = double.Parse(textBox11.Text);

                if (libra <= fondosLibra)
                {
                   euro = libra * 1.14;

                    textBox12.Text = (euro + " Euros").ToString();
                    textBox13.Text = (libra * 4.966 + " Pesos").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }

        }
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                fondosLibra = double.Parse(textBox8.Text);
                libra = double.Parse(textBox11.Text);

                if (libra <= fondosLibra)
                {
                    dolar = libra * 1.25;

                    textBox12.Text = (dolar + " Dolares").ToString();
                    textBox13.Text = (libra * 4.966 + " Pesos").ToString();

                }
                else
                {

                    textBox12.Text = " Fondos insuficientes   ";
                }
            }


            catch (Exception ex)
            {
                textBox4.Text = ex.Message;

            }



        }






    }


}
