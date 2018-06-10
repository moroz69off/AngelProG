using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANGELvsD
{
    delegate int PowerDelegate(int AP);

    public partial class AngelForm : Form
    {
        public int APower;

        public AngelForm()
        {
            InitializeComponent();
            PowerDelegate Pow = new PowerDelegate(GetPow);
            APower = Pow((int)numericUpDownALeave.Value);
        }

        static int GetPow(int ap)
        {
            return ap;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DiaForm diaForm = new DiaForm();
            diaForm.Owner = ActiveForm;
            diaForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDownALeave_ValueChanged(object sender, EventArgs e)
        {
            PowerDelegate Pow = new PowerDelegate(GetPow);
            APower = Pow((int)numericUpDownALeave.Value);
            //APower = (int)numericUpDownALeave.Value;
        }
    }
}
