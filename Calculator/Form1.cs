namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptoan;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            hienthi1.Clear();
            hienthi2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hienthi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "9";
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(pheptoan == "cong")
            {
                data2 = data1 + float.Parse(hienthi1.Text);
                hienthi2.Text = " = " + float.Parse(hienthi1.Text)  + " + " + data1.ToString();
                hienthi1.Text = data2.ToString();
            }
            if (pheptoan == "tru")
            {
                data2 = data1 - float.Parse(hienthi1.Text);
                hienthi2.Text = " = " + float.Parse(hienthi1.Text) + " - " + data1.ToString();
                hienthi1.Text = data2.ToString();
            }
            if (pheptoan == "nhan")
            {
                data2 = data1 * float.Parse(hienthi1.Text);
                hienthi2.Text = " = " + float.Parse(hienthi1.Text) + " * " + data1.ToString();
                hienthi1.Text = data2.ToString();
            }
            if (pheptoan == "chia")
            {
                if (float.Parse(hienthi1.Text) == 0)
                {
                    hienthi2.Text = " = " + float.Parse(hienthi1.Text) + " / " + data1.ToString();
                    hienthi1.Text = "chia rat nguu ,oke";
                }
                else
                {
                    hienthi2.Text = " = " + float.Parse(hienthi1.Text) + " / " + data1.ToString();
                    data2 = data1 / float.Parse(hienthi1.Text);
                    hienthi1.Text = data2.ToString();
                }
                
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pheptoan = "cong";
            hienthi2.Text = " + " + float.Parse(hienthi1.Text) ;
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            pheptoan = "tru";
            hienthi2.Text = " - " + float.Parse(hienthi1.Text);
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptoan = "nhan";
            hienthi2.Text = " * " + float.Parse(hienthi1.Text);
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                
            pheptoan = "chia";
            hienthi2.Text = " / " + float.Parse(hienthi1.Text);
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + ".";
        }
    }
}