﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            if (Longitud.Checked)
            {
                // Quiere saber la longitud
                string mensaje = "1/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                //Parteixo i agafo la primera part, la segona es bassura
                MessageBox.Show("La longitud de tu nombre es: " + mensaje);
            }
            if (Bonito.Checked)
            {
                // Quiere saber si el nombre es bonito
                string mensaje = "2/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                if (mensaje == "SI")
                    MessageBox.Show("Tu nombre ES bonito.");
                else
                    MessageBox.Show("Tu nombre NO bonito. Lo siento.");
            }
            if (Altura.Checked)
            {
                //Quiere saber si es alta
                string mensaje = "3/" + nombre.Text + "/"+alturaTextBox.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] response = new byte[80];
                server.Receive(response);
                mensaje = Encoding.ASCII.GetString(response).Split('\0')[0];

                MessageBox.Show(mensaje);

            }
            if (palindromeBtn.Checked)
            {
                string mensaje = "4/" + nombre.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] response = new byte[80];
                server.Receive(response);
                mensaje = Encoding.ASCII.GetString(response).Split('\0')[0];

                MessageBox.Show(mensaje);

            }
            if (mayBtn.Checked)
            {
                string mensaje = "5/" + nombre.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                byte[] response = new byte[80];
                server.Receive(response);
                mensaje = Encoding.ASCII.GetString(response).Split('\0')[0];

                MessageBox.Show(mensaje);
            }
             

          

    
          
          

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {

            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9060);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Connect(ipep);//Intentamos conectar el socket
            this.BackColor = Color.Green;

        }

        private void desConBtn_Click(object sender, EventArgs e)
        {
            // Se terminó el servicio. 
            // Nos desconectamos
            this.BackColor = Color.Gray;
            //server.Shutdown(SocketShutdown.Both);
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            //server.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
