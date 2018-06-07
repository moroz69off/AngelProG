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
        public DiaForm()
        {
            InitializeComponent();


            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // чекбоксы по центру ячейки
            

            string colNamePre;
            
            // В этом цикле добавляю нужное (его нужно вычислить ещё, пока 60) количество столбцов в сетку
            for (int i = 0; i < 60; i++)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn(true);
                colNamePre = "Column" + i.ToString();
                checkBoxColumn.Name = colNamePre;
                checkBoxColumn.Width = 20;

                checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                checkBoxColumn.FalseValue = "emptyCell";
                checkBoxColumn.FlatStyle = FlatStyle.Popup;
                checkBoxColumn.HeaderText = "";
                checkBoxColumn.IndeterminateValue = "diabloCell";
                checkBoxColumn.MinimumWidth = 20;
                checkBoxColumn.Resizable = DataGridViewTriState.False;
                checkBoxColumn.ThreeState = true;
                checkBoxColumn.TrueValue = "angelCell";

                dataGridView.Columns.Add(checkBoxColumn);
            }

            // Добавляю строки
            dataGridView.Rows.Add(32);

            // Установить все ячейки false
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.Rows.Count; j++)
                {
                    dataGridView[i, j].ReadOnly = false;
                    
                }
            }
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
    }
}
