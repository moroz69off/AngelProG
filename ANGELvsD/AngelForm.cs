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
    public partial class AngelForm : Form
    {
        ulong APower = ulong.MaxValue;
        public AngelForm()
        {
            InitializeComponent();
        }

        private void AngelForm_Load(object sender, EventArgs e)
        {
            APower = (ulong)numericUpDownALeave.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DiaForm diaForm = new DiaForm();
            diaForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
