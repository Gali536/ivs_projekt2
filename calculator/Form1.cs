using mathlib;

namespace calculator
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        int c = 0;
        double result = 0;
        bool add = false;
        bool subtract = false;
        bool multiply = false;
        bool divide = false;
        bool power = false;
        bool sqrroot = false;
        bool modulo = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void error()
        {
            // Konverze selhala, vypíšeme do TextBoxu chybovou hlášku
            textbox.Text = "ERROR";
            history.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textbox.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textbox.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textbox.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textbox.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textbox.Text += 8;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textbox.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textbox.Text += 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                // Konverze proběhla úspěšně, a proměnná 'hodnota' nyní obsahuje převedenou hodnotu
                divide = false;
                add = true;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "+";
                textbox.Text = "";
            }
            else
            {
                error();
            }

        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = true;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "-";
                textbox.Text = "";
            }
            else
            {
                error();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = true;
                power = true;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "×";
                textbox.Text = "";
            }
            else
            {
                error();
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = true;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "/";
                textbox.Text = "";
            }
            else
            {
                error();
            }
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textbox.Text, out c))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                history.Text = Convert.ToString(a) + "!";
                textbox.Text = Convert.ToString(math.Faktorial(c));
            }
            else
            {
                error();
            }
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = true;
                sqrroot = false;
                modulo = false;
                history.Text = Convert.ToString(a) + "^";
                textbox.Text = "";
            }
            else
            {
                error();
            }
        }

        private void button_sqrroot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = true;
                modulo = false;
                history.Text = Convert.ToString(a) + "√";
                textbox.Text = "";
            }
            else
            {
                error();
            }
        }

        private void button_modulo_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                divide = false;
                add = false;
                subtract = false;
                multiply = false;
                power = false;
                sqrroot = false;
                modulo = true;
                history.Text = Convert.ToString(a) + "%";
                textbox.Text = "";
            }
            else
            {
                error();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
            history.Text = "";
            a = 0;
            b = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (add == true && double.TryParse(textbox.Text, out b))
            {
                history.Text += b + "=";
                result = math.Scitani(a, b);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (subtract == true && double.TryParse(textbox.Text, out b))
            {
                history.Text += b + "=";
                result = math.Odecitani(a, b);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (multiply == true && double.TryParse(textbox.Text, out b))
            {
                history.Text += b + "=";
                result = math.Nasobeni(a, b);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (divide == true && double.TryParse(textbox.Text, out b) && b != 0)
            {
                history.Text += b + "=";
                result = math.Deleni(a, b);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (power == true && int.TryParse(textbox.Text, out c))
            {
                history.Text += c + "=";

                result = math.Umocneni(a, c);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (sqrroot == true && double.TryParse(textbox.Text, out b) && b >= 0)
            {
                history.Text += b + "=";

                result = math.Odmocnina(b, a);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else if (modulo == true && double.TryParse(textbox.Text, out b) && b != 0)
            {
                history.Text += b + "=";
                result = math.Modulo(a, b);
                textbox.Text = Convert.ToString(result);
                a = result;
            }

            else
            {
                error();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textbox.Text += ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textbox.Text, out a))
            {
                textbox.Text = Convert.ToString(math.ZmenaZnamenka(a));
            }
        }
    }
}
