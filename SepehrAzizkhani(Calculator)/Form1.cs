namespace SepehrAzizkhani_Calculator_
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double res;
        string oper;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) 
        {
            textBox1.Select();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.'))
                button11.Enabled = false;
            else
                button11.Enabled = true;

        }
        private void NumBtns_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSkyBlue;
            if (btn.Text == "." && textBox1.Text != "")
                textBox1.Text = textBox1.Text + ".";
            else if(btn.Text != ".") {
                textBox1.Focus();
                textBox1.Text = textBox1.Text + btn.Text;
                
            }
        }

        private void button12_Click(object sender, EventArgs e) 
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Select();
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label3.Text = "";
                oper = "+";
                label1.Visible = true;
                label1.Text = num1.ToString();
                label2.Visible = true;
                label2.Text = "+";
            }
        }
    

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Select();
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label3.Text = "";
                oper = "-";
                label1.Visible = true;
                label1.Text = num1.ToString();
                label2.Visible = true;
                label2.Text = "-";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Select();
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    label3.Text = "";
                    oper = "*";
                    label1.Visible = true;
                    label1.Text = num1.ToString();
                    label2.Visible = true;
                    label2.Text = "×";
                }
        }

        private void button16_Click(object sender, EventArgs e)
        {
                    if (textBox1.Text.Length != 0)
                    {
                        textBox1.Select();
                        num1 = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        label3.Text = "";
                        oper = "/";
                        label1.Visible = true;
                        label1.Text = num1.ToString();
                        label2.Visible = true;
                        label2.Text = "÷";
                    }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Select();
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            label3.Visible = true;
            label3.Text = num2.ToString();
            Operators obj = new Operators();
            obj.a = num1;
            obj.b = num2;
            switch (oper)
            {
                case "+":
                    res = obj.plus();
                    break;
                case "-":
                    res = obj.minus();
                    break;
                case "*":
                    res = obj.multi();
                    break;
                case "/":
                    res = obj.div();
                    break;
            }
            label4.Visible = true;
            label4.Text = "Result";
            textBox1.Text = res.ToString();
        }

        private void Keyboard_btn(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 && (!(e.KeyCode == Keys.Enter)) && (!(e.KeyCode == Keys.C)) && (!(e.KeyCode == Keys.Back))))
            {
                if(e.KeyCode == Keys.Enter && textBox1.Text != "")
              { 
                    button18_Click(null, null); 
                }
                if (e.KeyCode == Keys.C)
                {
                    button17_Click(null, null);
                }
                if (e.KeyCode == Keys.Back)
                {
                    button12_Click(null, null);
                }
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Add) 
                button13_Click(null, null);
            if (e.KeyCode == Keys.OemMinus)
                button14_Click(null, null);
            if (e.KeyCode == Keys.Multiply)
                button15_Click(null, null);
            if (e.KeyCode == Keys.Divide)
               button16_Click(null, null);
        }

        private void Hover_btns(object sender, EventArgs e)
        { 
            Button btn=(Button)sender;
            btn.BackColor = Color.White;
        }

        private void Leave_btns(object sender, EventArgs e)
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSkyBlue;
            button13.BackColor = Color.DodgerBlue;
            button14.BackColor = Color.DodgerBlue;
            button15.BackColor = Color.DodgerBlue;
            button16.BackColor = Color.DodgerBlue;
            button18.BackColor = Color.DodgerBlue;
        }

        private void Move_btns(object sender, MouseEventArgs e) 
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
        }

        private void button18_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
        }

        private void KeuUp_btns(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                button10.BackColor = Color.White;
            else
                button10.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                button1.BackColor = Color.White;
            else
                button1.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                button2.BackColor = Color.White;
            else
                button2.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                button3.BackColor = Color.White;
            else
                button3.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                button4.BackColor = Color.White;
            else
                button4.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                button5.BackColor = Color.White;
            else
                button5.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                button6.BackColor = Color.White;
            else
                button6.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                button7.BackColor = Color.White;
            else
                button7.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                button8.BackColor = Color.White;
            else
                button8.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                button9.BackColor = Color.White;
            else
                button9.BackColor = Color.LightSkyBlue;

            if (e.KeyCode == Keys.Enter)
                button18.BackColor = Color.White;
            else
                button18.BackColor = Color.DodgerBlue; ;

            if (e.KeyCode == Keys.OemMinus)
                button14.BackColor = Color.White;
            else
                button14.BackColor = Color.DodgerBlue;

            if (e.KeyCode == Keys.Add)
                button13.BackColor = Color.White;
            else
                button13.BackColor = Color.DodgerBlue;

            if (e.KeyCode == Keys.Multiply)
                button15.BackColor = Color.White;
            else
                button15.BackColor = Color.DodgerBlue;

            if (e.KeyCode == Keys.Divide)
                button16.BackColor = Color.White;
            else
                button16.BackColor = Color.DodgerBlue;

            if (e.KeyCode == Keys.C)
                button17.BackColor = Color.White;
            else
                button17.BackColor = Color.LightSkyBlue;
            if (e.KeyCode == Keys.Back)
                button12.BackColor = Color.White;
            else
                button12.BackColor = Color.LightSkyBlue;
        }
    }
}
