using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsApp2
{
    struct informatii
    {
        public string nume;
        public string descriere;
        public string data;
        public string nivel;
    }
    struct data
    {
        public int an;
        public int luna;
        public int zi;
    }
    public partial class Form1 : Form
    {
        private object listaBox;

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form_Load);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form clonedForm = (Form)this.MemberwiseClone();
            clonedForm.Text = this.Text + " Nou";

            clonedForm.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salvare_Click(object sender, EventArgs e)
        {

            List<informatii> informati = new List<informatii>();
            string a = "";
            if (radioButton1.Checked == true)
            {
                a = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                a = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                a = radioButton3.Text;
            }
            informati.Add(new informatii { nume = textBox1.Text, descriere = textBox2.Text, data = dateTimePicker1.Text, nivel = a });
            string date = @"C:\Users\gabri\source\repos\WinFormsApp2\date.txt";

            List<string> lines = new List<string>();
            foreach (informatii info in informati)
            {
                string line = $"{info.nume},{info.descriere},{info.data},{info.nivel}";
                lines.Add(line);
            }
            File.WriteAllLines(date, lines);
            string[] liness = File.ReadAllLines(date);

            foreach (string line in lines)
            {
                string[] comp = line.Split(',');
                string nume = comp[0];
                string descriere = comp[1];
                string data = comp[2];
                string nivel = comp[3];

                listBox1.Items.Add($"{nume}, {descriere}, {data}, {nivel}");
            }






        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aplicatie");

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            string filePath = @"C:\Users\gabri\source\repos\WinFormsApp2\date.txt";
            StreamWriter writer = new StreamWriter(filePath);

            string text = "";

            foreach (object item in listBox1.Items)
            {
                text += item.ToString() + "\n";
            }

            writer.Write(text);
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string select = listBox1.SelectedItem.ToString();

                string[] comp = select.Split(',');
                comp[0] = textBox1.Text;
                comp[1] = textBox2.Text;
                comp[2] = dateTimePicker1.Text;
                string a = "";
                if (radioButton1.Checked == true)
                {
                    a = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    a = radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    a = radioButton3.Text;
                }
                comp[3] = a;
                string newSelect = string.Join(",", comp);
                listBox1.Items[listBox1.SelectedIndex] = newSelect;
                listBox1.Refresh();
                string filePath = @"C:\Users\gabri\source\repos\WinFormsApp2\date.txt";
                StreamWriter writer = new StreamWriter(filePath);

                string text = "";

                foreach (object item in listBox1.Items)
                {
                    text += item.ToString() + "\n";
                }

                writer.Write(text);
                writer.Close();



            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\gabri\source\repos\WinFormsApp2\date.txt";
            StreamReader reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                listBox1.Items.Add(line);
            }


            reader.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* List<informatii> sort = new List<informatii>();
            
            List<string> lista = new List<string>();
            List<data> date=new List<data>();

            foreach (var item in listBox1.Items)
            {
                lista.Add(item.ToString());
            }
            for (int i= 0; i<lista.Capacity; i++)
            {
                string a =listBox1.Items[i].ToString();
                lista.Add(a);
                
            }
            for (int i = 0; i < lista.Capacity; i++)

            {
                string[] parti = lista.
                if (int.TryParse(parts[i], out int number))
                {
                    numbers[i] = number; 
                }
                else
                {

                }*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void salveazaCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(filePath);
                foreach (object item in listBox1.Items)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Close();
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("data.txt");
            foreach (object item in listBox1.Items)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
        }

        private void adaugaSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            Salvare.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            dateTimePicker1.Visible = true;
            groupBox1.Visible = true;
        }

        private void editeazaSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            Salvare.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            dateTimePicker1.Visible = true;
            groupBox1.Visible = true;
        }

        private void eliminaSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            Salvare.Visible = false;
        }
    }
}