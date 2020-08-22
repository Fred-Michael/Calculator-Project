using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalculatorUI
{
    public class NextMove
    {
        private Button Button { get; set; }
        private TextBox Txt { get; set; }
        public NextMove(TextBox screenresult, Button button)
        {
            Txt = screenresult;
            Button = button;
        }
        public void ContainsDotOrNot()
        {
            if (Txt.Text.Contains(".") && Button.Text == ".") Txt.Text += "";

            else Txt.Text = Txt.Text + Button.Text;
        }
        public string NegateOrNot()
        {
            if (!(Txt.Text.Contains("-")))
            {
                Txt.Text = "-" + Txt.Text;
            }
            else Txt.Text = Txt.Text.Replace("-", string.Empty);

            return Txt.Text;
        }
    }
}