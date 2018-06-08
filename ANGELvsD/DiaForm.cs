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
        private CheckBox[] chBoxes = new CheckBox[1881];
        private bool isAngel;
        private CheckBox lastChBox;
        private CheckBox chb;

        public DiaForm()
        {
            InitializeComponent();
            lastChBox = new CheckBox();
            isAngel = true;
            tableLayoutPanel.MouseClick += new MouseEventHandler(tableLayoutPanel_MouseClick);
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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

            tableLayoutPanel.ColumnCount = 57;
            tableLayoutPanel.RowCount = 33;

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            }

            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            }

            int a = 0;
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    chBoxes[a] = new CheckBox();
                    chBoxes[a].Name = "chBox_" + i.ToString() + "." + j.ToString();
                    chBoxes[a].Tag = "tag_" + i.ToString() + "." + j.ToString();
                    chBoxes[a].Dock = DockStyle.Fill;
                    chBoxes[a].Size = new Size(20, 20);
                    chBoxes[a].TextAlign = ContentAlignment.MiddleCenter;
                    chBoxes[a].ThreeState = true;
                    chBoxes[a].CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    chBoxes[a].Click += new EventHandler(checkBox_Click);
                    chBoxes[a].MouseEnter += new EventHandler(checkBox_Enter);
                    if (chBoxes[a].Name== "chBox_16.27")
                    {
                        chBoxes[a].CheckState = CheckState.Checked;
                        lastChBox = chBoxes[a];
                    }
                    a++;
                }
            }

        }

        private void checkBox_Enter(object sender, EventArgs e)
        {

        }

        private void DiaForm_Shown(object sender, EventArgs e)
        {
            tableLayoutPanel.Controls.AddRange(chBoxes);   
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
                lastChBox.CheckState = CheckState.Unchecked;
                chb.CheckState = CheckState.Checked;
                lastChBox = chb;
            }
            else
            {
                chb.CheckState = CheckState.Indeterminate;
            }
            //tableLayoutPanel.GetCellPosition();
        }

        //private void GetChBoxName(Control control)
        //{
        //    MessageBox.Show(control.Name);
        //}

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // сделать запись в массив состояний
        }
    }
}
