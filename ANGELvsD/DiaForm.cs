﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ANGELvsD
{
    public partial class DiaForm : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point point);
        private TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        private CheckBox[] chBoxes = new CheckBox[441];
        private bool isAngel;
        private CheckBox lastChBox, chb;
        private static int Apower;
        private bool isPower;


        static AngelForm AF = new AngelForm();
        private PowerDelegate powerDelegate = new PowerDelegate(GetPow);
        private bool isBlocked;

        public DiaForm()
        {
            InitializeComponent();
            lastChBox = new CheckBox();
            isAngel = true;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            //tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            //tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel.TabIndex = 0;
            panel.Controls.Add(tableLayoutPanel);

        }

        private static int GetPow(int AP)
        {
            Apower = AP;
            return Apower;
        }

        public static Control GetControlAt(int x, int y)
        {
            IntPtr hwnd = WindowFromPoint(new Point(x, y));
            Control c = FromHandle(hwnd);
            return c;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DataReset();
            ANGELvsD.AngelForm.ActiveForm.Activate();
            this.Close();
        }
        
        private void DataReset()
        {
            
        }

        private void DiaForm_Load(object sender, EventArgs e)
        {
            label.Text = "Ход\nАнгела";

            tableLayoutPanel.ColumnCount = 21;//кол-во колонок
            tableLayoutPanel.RowCount = 21;//кол-во строк

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            }

            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            }

            int a = 0;
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    chBoxes[a] = new CheckBox();
                    chBoxes[a].Name = "chBox_" + i.ToString("00") + "." + j.ToString("00");
                    chBoxes[a].Tag = "tag_" + i.ToString("00") + "." + j.ToString("00");
                    chBoxes[a].Dock = DockStyle.Fill;
                    chBoxes[a].AutoSize = true;
                    chBoxes[a].CheckAlign = ContentAlignment.MiddleCenter;
                    chBoxes[a].Size = new Size(32, 32);
                    chBoxes[a].ThreeState = true;
                    chBoxes[a].CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    chBoxes[a].Click += new EventHandler(checkBox_Click);
                    if (chBoxes[a].Name== "chBox_10.10")
                    {
                        chBoxes[a].CheckState = CheckState.Checked;
                        lastChBox = chBoxes[a];
                    }
                    a++;
                }
            }
        }

        private void DiaForm_Shown(object sender, EventArgs e)
        {
            tableLayoutPanel.Controls.AddRange(chBoxes);
        }

        internal int Power (int p)
        {
            Apower = p;
            return Apower;
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            // перемена хода:
            if (label.Text == "Ход\nАнгела")
            {
                label.Text = "Ход\nДьявола";
                isAngel = true;
            }
            else
            {
                label.Text = "Ход\nАнгела";
                isAngel = false;
            }

            chb = (CheckBox)GetControlAt(MousePosition.X, MousePosition.Y);

            if (isAngel)
            {
                isBlock();
                IsPower();

                if (isPower)
                {
                    AngelTookСell();
                }
                else { }
            }
            else
            {
                chb.CheckState = CheckState.Indeterminate;
                chb.Enabled = false;
                chb.BackColor = Color.DarkGray;
            }
            //tableLayoutPanel.GetCellPosition();
        }

        private bool isBlock()
        {
            if (chb.CheckState == CheckState.Indeterminate)
            {
                isBlocked = true;
            }
            else
            {
                isBlocked = false;
            }
            return isBlocked;
        }

        private void AngelTookСell()
        {
            lastChBox.CheckState = CheckState.Unchecked;
            chb.CheckState = CheckState.Checked;
            lastChBox = chb;
        }

        //private void GetChBoxName(Control control)
        //{
        //    MessageBox.Show(control.Name);
        //}

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // сделать запись в массив состояний
        }

        private bool IsPower()
        {
            int coordNext_X,
                coordNext_Y,
                coordCurr_X,
                coordCurr_Y;
            string currXstr = (lastChBox.Name.Substring(6)).Remove(2);
            string currYstr = (lastChBox.Name.Substring(9));
            string nextXstr = (chb.Name.Substring(6)).Remove(2);
            string nextYstr = (chb.Name.Substring(9));
            coordCurr_X = Int32.Parse(currXstr);
            coordCurr_Y = Int32.Parse(currYstr);
            coordNext_X = Int32.Parse(nextXstr);
            coordNext_Y = Int32.Parse(nextYstr);
            int deliverX = Math.Abs(coordNext_X - coordCurr_X);
            int deliverY = Math.Abs(coordNext_Y - coordCurr_Y);
            if (Math.Abs(deliverX) > Apower || Math.Abs(deliverY) > Apower)
            {
                MessageBox.Show("Недостаточно сил.");

                //переход хода Ангела:
                label.Text = "Ход\nАнгела";
                chb.CheckState = CheckState.Unchecked;
                isAngel = true;
                isPower = false;
                return isPower;
            }
            else
            { 
                isPower = true;
                return isPower;
            }
        }
    }
}
