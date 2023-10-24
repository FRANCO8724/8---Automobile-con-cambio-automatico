using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8___Automobile_con_cambio_automatico
{
    public partial class Form1 : Form
    {

        public int cont = 0;
        public int velocità = 0;
        public int marcia = 0;
        public Form1()
        {
            InitializeComponent();
        }
        Automobile a;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                listView1.Items.Clear();
                listView1.Items.Add("Macchina accesa");
                cont = 1;
            }
            else
            {
                listView1.Items.Clear();
                listView1.Items.Add("Macchina spenta");
                cont = 0;
            }

            if (cont == 1)
            {
                a = new Automobile(velocità, marcia);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int acc = a.Accellerazione();
            listView1.Items.Clear();
            listView1.Items.Add("Velocità: " + acc + " Km/h");


            if (2 > acc && acc < 4)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "1");
            }
            else if (4 > acc && acc < 6)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "2");
            }
            else if (6 > acc && acc < 8)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "3");
            }
            else if (8 > acc && acc < 10)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "4");
            }
            else if (10 > acc && acc < 12)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "5");
            }
            else if (12 > acc)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "6");
            }

        }

        public class Automobile
        {
            protected int velocità;
            protected int marcia;
            protected int acc;
            public int num = 0;
            public bool cont2 = false;
            public bool cont3 = false;


            public Automobile(int velocità, int marcia)
            {
                this.velocità = velocità;
                this.marcia = marcia;
            }

            public virtual int Accellerazione()
            {

                velocità++;
                    if (velocità > 280)
                    {
                        velocità = 280;
                    }

                return this.velocità;

            }

            public virtual int Decellerazione()
            {
                velocità--;

                    if (velocità < -49)
                    {
                        velocità = -50;
                    }

                return this.velocità;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int acc = a.Decellerazione();
            listView1.Items.Clear();
            listView1.Items.Add("Velocità: " + acc + " Km/h");

            if (acc < 2)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "R");
            }
            else if (2 > acc && acc < 4)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "1");
            }
            else if (4 > acc && acc < 6)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "2");
            }
            else if (6 > acc && acc < 8)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "3");
            }
            else if (8 > acc && acc < 10)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "4");
            }
            else if (10 > acc && acc < 12)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "5");
            }
            else if (12 > acc)
            {
                listView2.Items.Clear();
                listView2.Items.Add("Marcia: " + "6");
            }
        }
    }
}
