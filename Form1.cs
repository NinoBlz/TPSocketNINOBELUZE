using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace TPSocket.Properties
{
    public partial class Communication : Form
    {
        public Communication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Cree_Click(object sender, EventArgs e)
        {

            try
            {

                SSocketUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                SSocketUDP.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);
                Destination = new IPEndPoint(IPAddress.Parse(this.IPDestination.Text), int.Parse(this.PortRCP.Text));
                Reception = new IPEndPoint(IPAddress.Parse(this.IPReception.Text), int.Parse(this.PortDestinataire.Text));

                SSocketUDP.Bind(Reception);
            }

            catch(SocketException SE)

            {
                this.MessageR.Text = SE.ToString();
            }


        }





        private void Fermer_Click(object sender, EventArgs e)
        {
            try
            {
                SSocketUDP.Close();
            }
            catch (SocketException SE)
            {
                this.MessageR.Text = SE.ToString();
            }
        }





        private void Envoye_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = Encoding.ASCII.GetBytes(this.MessageSaisit.Text);
                SSocketUDP.SendTo(msg, Destination);
            }
            catch (SocketException SE)
            {
                this.MessageR.Text = SE.ToString();
            }
        }






        private void Reception_Click(object sender, EventArgs e)
        {
            Task.Run(() => CheckUp());

        }




        private bool ReceptionT()
        {
            try
            {
                var buffer = new byte[1024];
                SSocketUDP.ReceiveFrom(buffer, ref Reception);
                this.MessageR.Text = Encoding.ASCII.GetString(buffer);

                return SSocketUDP.Available == 0;
            }
            catch (SocketException SE)
            {
                this.MessageR.Text = SE.ToString();
            }
            return false;


        }

        private async void CheckUp()
        {
            Timer.Start();

            while (Timer.ElapsedMilliseconds < 1500) ;

            Timer.Stop();



            if (!ReceptionT())
            {
                CheckUp();
            }
        }
    }


}


