using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Työkirja
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string asiakas = "";
        public string tehtava = "";
        public string aika = "";
        public string tunnit = "";
        public string kuvaus = "";
        public string rivi = "";

        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> kirjaukset = new List<string>();

            asiakas = textBox2.Text;
            tehtava = textBox1.Text;
            aika = dateTimePicker1.Text;
            tunnit = textBox4.Text;
            kuvaus = textBox3.Text;

            kirjaukset.Add(asiakas);
            kirjaukset.Add(tehtava);
            kirjaukset.Add(aika);
            kirjaukset.Add(tunnit);
            kirjaukset.Add(kuvaus);

            StringBuilder builder = new StringBuilder();
            foreach (string tieto in kirjaukset)
            {
                builder.Append(tieto).Append(", "); 
            }
            string result = builder.ToString(); 
            MessageBox.Show(result);
        }
    }
}
