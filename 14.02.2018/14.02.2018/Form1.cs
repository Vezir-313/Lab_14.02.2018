using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._02._2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> btns = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    Button btn = new Button();
                    btn.Top = i * 40 + 42;
                    btn.Left = (j-1) * 40 + 42;
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.BackColor = Color.White;

                    btn.Text = i * 8 + j+"";


                    // buttona click eventi elave edilir
                    btn.Click += new EventHandler(btn_Click);


                    btns.Add(btn);
                    this.Controls.Add(btn);
                }

                Label lbl = new Label();

                lbl.Text = i * 5 +5+" azn";
                lbl.Left = 380;
                lbl.Top = i * 40 + 52;
                this.Controls.Add(lbl);

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if(btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Yellow;
            }
            detect_places();
        }

        string s = "";
        int n = 0;
        public void detect_places()
        {

            s = "";
            n = 0;
            foreach (var b in btns)
            {
                if (b.BackColor == Color.Yellow)
                {
                    s += b.Text + ",";
                    n += (int.Parse(b.Text) / 9 + 1) * 5;
                }

            }


            secilmiwLbl.Text = "Umumi qiyet : " + n + "\n" + "Secdiyiniz yerler : " + s;
        }

        private void tesdiqbtn_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("Once yer secin");
            }
            else
            {
                foreach (var item in btns)
                {
                    if (item.BackColor == Color.Yellow)
                    {
                        item.BackColor = Color.Green;
                        item.Enabled = false;
                    }
                }
                listBox1.Items.Add("Qiyemt: "+n+ "azn     Alinan yerler : "+s);
                s = "";
                n = 0;
                secilmiwLbl.Text = "Umumi qiyet : " + n + "\n" + "Secdiyiniz yerler : " + s;

            }

        }
    }
}
