using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // entweder Random oder nächsten Index anklicken und die Textboxinhalt ändern
            //TextBox.text = "Wunsch";
            // String mit Geburtstagstexten

            //private string Geburtstagswunsch;
            //public string string1 = "Geburtstagswunsch";
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string string1 = "Geburtstagswunsch1";
            //Geburtstagswunsch = "Geburtstagswunsch1";
            textBox1.Text = string1;
        }

        
    }
}
