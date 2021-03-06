﻿using System;
using System.Windows.Forms;

namespace ANGELvsD
{
    delegate int PowerDelegate(int AP);

    public partial class AngelForm : Form
    {
        private DiaForm DF = new DiaForm();
        public int APower;

        public AngelForm()
        {
            InitializeComponent();
            PowerDelegate Pow = new PowerDelegate(GetPow);
            APower = Pow((int)numericUpDownALeave.Value);
        }

        private static int GetPow(int ap) { return ap; }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            DiaForm diaForm = new DiaForm { Owner = ActiveForm };
            diaForm.Power((int)numericUpDownALeave.Value);
            diaForm.ShowDialog();
        }

        private void ButtonExit_Click(object sender, EventArgs e) { Close(); }

        private void NumericUpDownALeave_ValueChanged(object sender, EventArgs e)
        {
            
            DF.Power((int)numericUpDownALeave.Value);
        }
    }
}
