using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPSocket.Properties;

namespace TPSocket
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Créez une nouvelle instance de votre formulaire Form1
            Communication mainForm = new Communication();

            // Appelez Application.Run pour démarrer l'application Windows Forms
            Application.Run(mainForm);
        }
    }
}

