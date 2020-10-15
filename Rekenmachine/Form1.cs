using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Rekenmachine : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;


        public Rekenmachine()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Knop_click(object sender, EventArgs e)
        {

            if ((Textbox.Text == "0") || (isOperationPerformed))
                Textbox.Clear();

            /*if (labelEuro.Text == "€");
            {
                if (Textbox.Text.Contains(","))
                    Textbox.Text = Textbox.Text.Substring(0, 2);
                    //Hierzo moet nog de max twee decimalen in geval van € functie komen
            
            }
            De functie werkt al doordat ie wordt afgerond
            Ik ben hier nu al een tijdje mee bezig en kan nergens op komen.
            Hij werkt gewoon goed alleen ziet het er appart uit
            Dit is een vraagstuk waar iemand met kennis mij bij kan helpen aangezien ik wel benieuwd ben naar de oplossing
            */

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!Textbox.Text.Contains(","))
                    Textbox.Text += button.Text;
            } else
                Textbox.Text += button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                Knop_is.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                Textbox.Text = "0";

            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(Textbox.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                Textbox.Text = "0";
            }
        }

        private void C_click(object sender, EventArgs e)
        {
            Textbox.Text = "0";
            labelEuro.Text = "";
        }

        private void CE_click(object sender, EventArgs e)
        {
            Textbox.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = "";
            labelEuro.Text = "";
        }

        private void Is_click(object sender, EventArgs e)
        {

            if (Textbox.Text.Contains("%"))
            {
                if (!Textbox.Text.Contains("%"))
                    Textbox.Text = (1 / Double.Parse(Textbox.Text) * Double.Parse(Textbox.Text)).ToString();
            }

            if (labelCurrentOperation.Text.Length != 0)
                switch (operationPerformed)
                {
                    case "+":
                        Textbox.Text = (resultValue + Double.Parse(Textbox.Text)).ToString();
                        break;
                    case "-":
                        Textbox.Text = (resultValue - Double.Parse(Textbox.Text)).ToString();
                        break;
                    case "*":
                        Textbox.Text = (resultValue * Double.Parse(Textbox.Text)).ToString();
                        break;
                    case "/":
                        Textbox.Text = (resultValue / Double.Parse(Textbox.Text)).ToString();
                        break;

                }
            if (labelEuro.Text == "€") ;
            Textbox.Text = (Math.Round(Double.Parse(Textbox.Text), 2).ToString());

            resultValue = Double.Parse(Textbox.Text);
            labelCurrentOperation.Text = "";
        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Knop_euro_Click(object sender, EventArgs e)
        {
            labelEuro.Text = "€";
        }

        private void Knop_backspace_Click(object sender, EventArgs e)
        {
            if (Textbox.Text.Length != 1)
                Textbox.Text = Textbox.Text.Substring(0, Textbox.Text.Length - 1);

            else
                Textbox.Text = "0";
        }

        private void Percentage_knop(object sender, EventArgs e)
        {
            if (labelCurrentOperation.Text.Contains("+") || (labelCurrentOperation.Text.Contains("*") || (labelCurrentOperation.Text.Contains("-") || labelCurrentOperation.Text.Contains("/")
                if (Textbox.Text.Contains("%"))
                {
                    if (!Textbox.Text.Contains("%"))
                        Textbox.Text += "%";
                } else
                    Textbox.Text += "%";
        }
    }
}
