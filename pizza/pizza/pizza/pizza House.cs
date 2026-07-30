using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pizza
{
   
    public partial class pizza_Hosue : Form
    {
        public double total = 0.0, tax, subtotal, finaltotal;
        public pizza_Hosue()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.BorderStyle == BorderStyle.FixedSingle) {
                int thickness = 9;
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Firebrick, thickness)) {
                    e.Graphics.DrawRectangle(p,new Rectangle(halfThickness,
                                                             halfThickness,
                                                             panel1.ClientSize.Width-thickness,
                                                             panel1.ClientSize.Height-thickness));
               
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitter5_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int thickness = 9;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.Firebrick, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                         halfThickness,
                                                         panel2.ClientSize.Width - thickness,
                                                         panel2.ClientSize.Height - thickness));

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int thickness = 9;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.Firebrick, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                         halfThickness,
                                                         panel3.ClientSize.Width - thickness,
                                                         panel3.ClientSize.Height - thickness));

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            int thickness = 9;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(Color.Firebrick, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                         halfThickness,
                                                         panel4.ClientSize.Width - thickness,
                                                         panel4.ClientSize.Height - thickness));

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void pizza_Hosue_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double qun9, price9, total9;
            qun9 = double.Parse(textBox9.Text);
            price9 = 6;
            total9 = price9 * qun9;
            total += total9;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox8.Checked)
            {
                textBox8.Enabled = true;
               
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox10.Checked)
            {
                textBox10.Enabled = true;
               
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double qun10, price10, total10;
            qun10 = double.Parse(textBox10.Text);
            price10 = 5;
            total10 = price10 * qun10;
            total += total10;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double qun8, price8, total8;
            qun8 = double.Parse(textBox1.Text);
            price8 = 10;
            total8 = price8 * qun8;
            total += total8;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox9.Checked)
            {
                textBox9.Enabled = true;
               
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox13.Checked)
            {
                textBox13.Enabled = true;
               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked) {
                textBox1.Enabled= true;
                

            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
               
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
               
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox4.Checked)
            {
                textBox4.Enabled = true;
                
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox5.Checked)
            {
                textBox5.Enabled = true;
               
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox6.Checked)
            {
                textBox6.Enabled = true;
               
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox7.Checked)
            {
                textBox7.Enabled = true;
                
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBox12.Checked)
            {
                textBox12.Enabled = true;
              
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox11.Checked)
            {
                textBox11.Enabled = true;
               
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox14.Text = "€"+total.ToString() ;
            tax = total * 0.05;
            subtotal = total + 1.50;
            finaltotal = total + 1.50 + tax;
            textBox18.Text = "€"+subtotal.ToString();
            textBox16.Text = "€"+tax.ToString();
            textBox17.Text = "€"+finaltotal.ToString();
            

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double qun1, price1, total1;
            qun1 = Convert.ToDouble(textBox1.Text);
            price1 = 15.0;
            total1 = price1 * qun1;
            total += total1;
            
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double qun2, price2, total2;
            qun2 = double.Parse(textBox2.Text);
            price2 = 15;
            total2 = price2 * qun2;
            total += total2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double qun3, price3, total3;
            qun3 = double.Parse(textBox2.Text);
            price3 = 15;
            total3 = price3 * qun3;
            total += total3;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double qun4, price4, total4;
            qun4 = double.Parse(textBox4.Text);
            price4 = 15;
            total4 = price4 * qun4;
            total += total4;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double qun5, price5, total5;
            qun5 = double.Parse(textBox5.Text);
            price5 = 20;
            total5 = price5 * qun5;
            total += total5;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double qun6, price6, total6;
            qun6 = double.Parse(textBox6.Text);
            price6 = 25;
            total6 = price6 * qun6;
            total += total6;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double qun7, price7, total7;
            qun7 = double.Parse(textBox7.Text);
            price7 = 2;
            total7 = price7 * qun7;
            total += total7;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double qun13, price13, total13;
            qun13 = double.Parse(textBox13.Text);
            price13 = 5;
            total13 = price13 * qun13;
            total += total13;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            double qun12, price12, total12;
            qun12 = double.Parse(textBox12.Text);
            price12 = 3;
            total12 = price12 * qun12;
            total += total12;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                textBox1.Enabled = false;
                textBox1.Text = "0";

            }
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
            if (checkBox4.Checked == true)
            {
                checkBox4.Checked = false;
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
            if (checkBox5.Checked == true)
            {
                checkBox5.Checked = false;
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
            if (checkBox6.Checked == true)
            {
                checkBox6.Checked = false;
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
            if (checkBox10.Checked == true)
            {
                checkBox10.Checked = false;
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
            if (checkBox9.Checked == true)
            {
                checkBox9.Checked = false;
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
            if (checkBox8.Checked == true)
            {
                checkBox8.Checked = false;
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
            if (checkBox7.Checked == true)
            {
                checkBox7.Checked = false;
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
            if (checkBox13.Checked == true)
            {
                checkBox13.Checked = false;
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
            if (checkBox12.Checked == true)
            {
                checkBox12.Checked = false;
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
            if (checkBox11.Checked == true)
            {
                checkBox11.Checked = false;
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
            listBox1.Items.Clear();
            textBox14.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double qun11, price11, total11;
            qun11 = double.Parse(textBox1.Text);
            price11 = 15;
            total11 = price11 * qun11;
            total += total11;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("------------------------------------------");
            listBox1.Items.Add("                       Pizza House");
            listBox1.Items.Add("------------------------------------------");
            if (checkBox1.Checked==true) {
                string q1 = textBox1.Text;
                string name1 = "Margherita Pizza  \t\t" + q1;
                listBox1.Items.Add(name1);
            }
            if (checkBox2.Checked == true)
            {
                string q2 = textBox2.Text;
                string name2 = "Cheese Pizza      \t\t" + q2;
                listBox1.Items.Add(name2);
            }
            if (checkBox3.Checked == true)
            {
                string q3= textBox3.Text;
                string name3= "Pepperoni Pizza    \t\t" + q3;
                listBox1.Items.Add(name3);
            }
            if (checkBox4.Checked == true)
            {
                string q4 = textBox4.Text;
                string name4 = "Meat Pizza        \t\t" + q4;
                listBox1.Items.Add(name4);
            }
            if (checkBox5.Checked == true)
            {
                string q5 = textBox5.Text;
                string name5 = "BBQ Chicken Pizza \t\t" + q5;
                listBox1.Items.Add(name5);
            }
            if (checkBox6.Checked == true)
            {
                string q6 = textBox6.Text;
                string name6 = "Buffalo Pizza     \t\t" + q6;
                listBox1.Items.Add(name6);
            }
            if (checkBox10.Checked == true)
            {
                string q10 = textBox10.Text;
                string name10= "Potato Wedges     \t\t" + q10;
                listBox1.Items.Add(name10);
            }
            if (checkBox9.Checked == true)
            {
                string q9 = textBox9.Text;
                string name9 = "French fries      \t\t" + q9;
                listBox1.Items.Add(name9);
            }
            if (checkBox8.Checked == true)
            {
                string q8 = textBox8.Text;
                string name8 = "Chicken Wings     \t\t" + q8;
                listBox1.Items.Add(name8);
            }
            if (checkBox7.Checked == true)
            {
                string q7 = textBox7.Text;
                string name7 = "Garlic bread      \t\t" + q7;
                listBox1.Items.Add(name7);
            }
            if (checkBox13.Checked == true)
            {
                string q13 = textBox13.Text;
                string name13 = "Soft drinks      \t\t" + q13;
                listBox1.Items.Add(name13);
            }
            if (checkBox12.Checked == true)
            {
                string q12 = textBox12.Text;
                string name12= "Orange juice      \t\t" + q12;
                listBox1.Items.Add(name12);
            }
            if (checkBox11.Checked == true)
            {
                string q11 = textBox11.Text;
                string name11 = "Water            \t\t" + q11;
                listBox1.Items.Add(name11);
            }
            listBox1.Items.Add("------------------------------------------");
            listBox1.Items.Add("service charge       \t\t€1.50");
            listBox1.Items.Add("------------------------------------------");
            listBox1.Items.Add("Tax                  \t\t€" + Convert.ToString(tax));
            listBox1.Items.Add("Subtotal             \t\t€" + Convert.ToString(subtotal));
            listBox1.Items.Add("Total                \t\t€" + Convert.ToString(finaltotal));
        }
    }
}
