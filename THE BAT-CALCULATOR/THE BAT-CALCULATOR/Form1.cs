using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace THE_BAT_CALCULATOR
{

    public partial class Form1 : Form
    {
        public double Op = 0;
        public double Op2 = 0;
        bool Primera = true;
        int Operador = 0;
        bool igual = false;
        bool punto = false; 




        public Form1()
        {
            InitializeComponent();
            Size = new Size(425, 543);
            panel1.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0);
            panel6.Location = new Point(0, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            punto = false;
            if (Operador == 1) { Op = Op + Convert.ToDouble(textBox38.Text); textBox38.Text = "1"; }
            if (Operador == 2) { Op = Op - Convert.ToDouble(textBox38.Text); textBox38.Text = "1"; }
            if (Operador == 3) { Op = Op * Convert.ToDouble(textBox38.Text); textBox38.Text = "1"; }

            if (Primera == true) { Op = 0; Op = Math.Pow(Convert.ToDouble(textBox38.Text),2); Primera = false; }
            Op = Op / Convert.ToDouble(textBox38.Text);
            textBox40.Text = Op + " /";
            textBox38.Text = "0";
            Operador = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "7"; }
            else textBox38.Text = textBox38.Text + "7";
            igual = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {   
            bool X = false;
            if (Operador == 1) { Op = Op + Convert.ToDouble(textBox38.Text); X = true; }
            if (Operador == 2) { Op = Op - Convert.ToDouble(textBox38.Text); X = true; }
            if (Operador == 3) { Op = Op * Convert.ToDouble(textBox38.Text); X = true; }
            if (Operador == 4) { Op = Op / Convert.ToDouble(textBox38.Text); X = true; }
            textBox40.Text = " ";
            if (X == true) { textBox38.Text = Convert.ToString(Op); Operador = 0; }
            Primera = true;
            igual = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "4"; }
            else textBox38.Text = textBox38.Text + "4";
            igual = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "0"; }
            else textBox38.Text = textBox38.Text + "0";
            igual = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "2"; }
            else textBox38.Text = textBox38.Text + "2";
            igual = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (punto == false)
            {
                if (igual == true) { textBox38.Text = "0"; }
                textBox38.Text = textBox38.Text + ".";
                igual = false;
                punto = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           if (igual == true) {textBox38.Text = "0"; }
           if (textBox38.Text== "0") { textBox38.Text = "1"; }
           else textBox38.Text = textBox38.Text + "1";
            igual = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox38.Text = "0";
            textBox40.Text = " ";
            Op = 0;
            Operador = 0;
            Primera = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox38.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "8"; }
            else textBox38.Text = textBox38.Text + "8";
            igual = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "9"; }
            else textBox38.Text = textBox38.Text + "9";
            igual = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "6"; }
            else textBox38.Text = textBox38.Text + "6";
            igual = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            punto = false;
            if (Operador == 1) { Op = Op + Convert.ToDouble(textBox38.Text); textBox38.Text = "0"; }
            if (Operador == 3) { Op = Op * Convert.ToDouble(textBox38.Text); textBox38.Text = "0"; }
            if (Operador == 4) { Op = Op / Convert.ToDouble(textBox38.Text); textBox38.Text = "0"; }

            Operador = 2;

            if (Primera == true) { Op = 0; Op = Convert.ToDouble(textBox38.Text) * 2; Primera = false; }

            Op = Op - Convert.ToDouble(textBox38.Text);

            textBox40.Text = Op + " -";
            textBox38.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            punto = false;
            if (Operador == 1) { Op = Op + Convert.ToDouble(textBox38.Text); textBox38.Text = "1"; }
            if (Operador == 2) { Op = Op - Convert.ToDouble(textBox38.Text); textBox38.Text = "1"; }
            if (Operador == 4) { Op = Op / Convert.ToDouble(textBox38.Text); textBox38.Text = "1"; }

            if (Primera == true) { Op = 0; Op = 1; Primera = false; }
            Op = Op * Convert.ToDouble(textBox38.Text);
            textBox40.Text = Op + " *";
            textBox38.Text = "0";
            Operador = 3;

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (Primera == true) { Op = 0; Primera = false; }
            punto = false;
            if (Operador == 2) { Op = Op - Convert.ToDouble(textBox38.Text); textBox38.Text = "0"; } 
            if (Operador == 3) { Op = Op * Convert.ToDouble(textBox38.Text); textBox38.Text = "0"; }
            if (Operador == 4) { Op = Op / Convert.ToDouble(textBox38.Text); textBox38.Text = "0"; }
            Operador = 1;
            Op = Op + Convert.ToDouble(textBox38.Text);
            textBox40.Text = Op + " +";
            textBox38.Text = "0";


        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            Size = new Size(425, 543);

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
            panel6.Visible = false;
            Size = new Size(811, 543);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button69_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "3"; }
            else textBox38.Text = textBox38.Text + "3";
            igual = false;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            button126.Visible = true;
            button127.Visible = true;
            button128.Visible = true;
            button129.Visible = true;
            button130.Visible = true;
            button131.Visible = true;
            button132.Visible = true;
            button133.Visible = true;
            button134.Visible = true;
            button135.Visible = true;
            button136.Visible = true;

            button83.Visible = false;
            button81.Visible = false;
            button76.Visible = false;
            button74.Visible = false;
            button72.Visible = false;
            button75.Visible = false;
            button73.Visible = false;
            button67.Visible = false;
            button66.Visible = false;
            button64.Visible = false;
            button58.Visible = false;

        }

        private void button81_Click(object sender, EventArgs e)
        {

        }

        private void button79_Click(object sender, EventArgs e)
        {

        }

        private void button77_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button119_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            Size = new Size(425, 543);
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
            panel6.Visible = false;
            Size = new Size(811, 543);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            Size = new Size(425, 543);

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
            panel6.Visible = false;
            Size = new Size(811, 543);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            Size = new Size(425, 543);
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel6.Visible = true;
            Size = new Size(772, 684);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel6.Visible = true;
            Size = new Size(772, 684);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel6.Visible = true;



            Size = new Size(772, 684);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button128_Click(object sender, EventArgs e)
        {

        }

        private void button136_Click(object sender, EventArgs e)
        {
            button126.Visible = false;
            button127.Visible = false;
            button128.Visible = false;
            button129.Visible = false;
            button130.Visible = false;
            button131.Visible = false;
            button132.Visible = false;
            button133.Visible = false;
            button134.Visible = false;
            button135.Visible = false;
            button136.Visible = false;

            button83.Visible = true;
            button81.Visible = true;
            button76.Visible = true;
            button74.Visible = true;
            button72.Visible = true;
            button75.Visible = true;
            button73.Visible = true;
            button67.Visible = true;
            button66.Visible = true;
            button64.Visible = true;
            button58.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button111.Visible = false;
            button113.Visible = false;
            button109.Visible = false;
            button110.Visible = false;
            button118.Visible = false;
            button123.Visible = false;
            button106.Visible = true;
            button101.Visible = false;
            button96.Visible = false;
            button105.Visible = true;
            button100.Visible = true;
            button95.Visible = true;
            button94.Visible = true;
            button99.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button111.Visible = true;
            button113.Visible = true;
            button109.Visible = true;
            button110.Visible = true;
            button118.Visible = true;
            button123.Visible = true;
            button106.Visible = true;
            button101.Visible = true;
            button96.Visible = true;
            button105.Visible = true;
            button100.Visible = true;
            button95.Visible = true;
            button94.Visible = true;
            button99.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button111.Visible = false;
            button113.Visible = false;
            button109.Visible = false;
            button110.Visible = false;
            button118.Visible = false;
            button123.Visible = false;
            button106.Visible = false;
            button101.Visible = false;
            button96.Visible = false;
            button105.Visible = false;
            button100.Visible = false;
            button95.Visible = false;
            button94.Visible = false;
            button99.Visible = false;

        }

        private void button99_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button111.Visible = false;
            button113.Visible = false;
            button109.Visible = false;
            button110.Visible = false;
            button118.Visible = false;
            button123.Visible = false;
            button106.Visible = true;
            button101.Visible = true;
            button96.Visible = true;
            button105.Visible = true;
            button100.Visible = true;
            button95.Visible = true;
            button94.Visible = true;
            button99.Visible = true;
           
        }

        private void button111_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void unitrToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void activadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(743, 543);
            panel11.Location = new Point(396, -1);
            panel11.Visible = true;
        }

        private void desactivadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(425, 543);
            panel11.Visible = false;
        }

        private void activadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Size = new Size(1087, 684);
            panel11.Location = new Point(738, 0);
            panel11.Visible = true;
        }

        private void desactivadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Size = new Size(772, 684);
            panel11.Visible = false;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void unitConvertionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void activadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Size = new Size(1129, 543);
            panel11.Location = new Point(781, 0);
            panel11.Visible = true;
        }

        private void desactivadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Size = new Size(811, 543);
            panel11.Visible = false;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (igual == true) { textBox38.Text = "0"; }
            if (textBox38.Text == "0") { textBox38.Text = "5"; }
            else textBox38.Text = textBox38.Text + "5";
            igual = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button78_Click(object sender, EventArgs e)
        {
            punto = false;
            if (Primera == true) { Op = 0; Primera = false; }
            if (Operador == 1) { textBox38.Text = Convert.ToString(Op + Convert.ToDouble(textBox38.Text));}
            if (Operador == 2) { textBox38.Text = Convert.ToString(Op - Convert.ToDouble(textBox38.Text)); }
            if (Operador == 3) { textBox38.Text = Convert.ToString(Op * Convert.ToDouble(textBox38.Text)); }
            if (Operador == 4) { textBox38.Text = Convert.ToString(Op / Convert.ToDouble(textBox38.Text)); }


            Op = Math.Sqrt(Convert.ToDouble(textBox38.Text));
            textBox40.Text = " ";
            textBox38.Text = Convert.ToString(Op);
            Operador = 5;
            Op = 0;
            igual = true;  
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
        }

        private void button100_Click(object sender, EventArgs e)
        {

        }

        private void button101_Click(object sender, EventArgs e)
        {

        }

        private void button146_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
