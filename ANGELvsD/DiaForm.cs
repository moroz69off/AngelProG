using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
        private CheckBox lastChBox, nextChBox, chb;
        private int power;
        private bool isPower;

        AngelForm AF = new AngelForm();

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
                    chBoxes[a].Size = new Size(24, 24);
                    chBoxes[a].TextAlign = ContentAlignment.MiddleCenter;
                    chBoxes[a].ThreeState = true;
                    chBoxes[a].CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    chBoxes[a].Click += new EventHandler(checkBox_Click);
                    chBoxes[a].MouseEnter += new EventHandler(checkBox_Enter);
                    if (chBoxes[a].Name== "chBox_11.11")
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
            power = AF.APower;
        }

        private void checkBox_Enter(object sender, EventArgs e)
        {
            Control cont = GetControlAt(MousePosition.X, MousePosition.Y);
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
                IsPower();//?
                if (isPower)
                {
                    AngelTookСell();
                }
                else { }
            }
            else
            {
                chb.CheckState = CheckState.Indeterminate;
            }
            //tableLayoutPanel.GetCellPosition();
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
            //MessageBox.Show(chb.Name + "\n\r" + lastChBox.Name);
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
            if (Math.Abs(deliverX)>power || Math.Abs(deliverY) > power)
            {
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
