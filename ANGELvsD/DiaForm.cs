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
    public partial class DiaForm : Form
    {
        private TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        private CheckBox[] chBoxes = new CheckBox[1881];
      private CheckBox checkBox;

        public DiaForm()
        {
            InitializeComponent();

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

        private void CheckBox_CheckedChanged(Object sender, EventArgs e)
        {

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
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.RowCount; j++)
                {
                    chBoxes[a] = new CheckBox();
                    chBoxes[a].Name = "chBox_" + i.ToString() + "." + j.ToString();
                    chBoxes[a].Tag = "tag_" + i.ToString() + "." + j.ToString();
                    chBoxes[a].Dock = DockStyle.Fill;
                    chBoxes[a].Size = new Size(19, 19);
                    chBoxes[a].TextAlign = ContentAlignment.MiddleCenter;
                    chBoxes[a].ThreeState = true;
                    chBoxes[a].CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    chBoxes[a].Click += new EventHandler(checkBox_Click);
                    a++;
                }
            }

        }

        private void DiaForm_Shown(object sender, EventArgs e)
        {
            //int a = 0;
            //for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            //{
            //    for (int j = 0; j < tableLayoutPanel.RowCount; j++)
            //    {
            //        chBoxes[a] = new CheckBox();
            //        chBoxes[a].Name = "chBox_" + i.ToString() + "." + j.ToString();
            //        chBoxes[a].Tag = "tag_" + i.ToString() + "." + j.ToString();
            //        chBoxes[a].Dock = DockStyle.Fill;
            //      //chBoxes[a].Location = new System.Drawing.Point(0, 0);
            //     // chBoxes[a].Size = new System.Drawing.Size(952, 544);
            //    //  chBoxes[a].TabIndex = 0;
            //        chBoxes[a].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //        chBoxes[a].ThreeState = true;
            //        chBoxes[a].CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            //        chBoxes[a].Click += new EventHandler(checkBox_Click);
            //        a++;
            //    }          
            //}
            tableLayoutPanel.Controls.AddRange(chBoxes);
        }

        private void tableLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // смена хода:
            if (label.Text == "Ход\nАнгела") label.Text = "Ход\nДьявола";
            else label.Text = "Ход\nАнгела";
            //tableLayoutPanel.GetCellPosition();
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            IsAngelNext(0, 0);
        }

        private void IsAngelNext(int isAx, int isAy) //
        {
            
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
