namespace ANGELvsD
{
    partial class AngelForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngelForm));
            this.numericUpDownALeave = new System.Windows.Forms.NumericUpDown();
            this.labelPower = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownALeave)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownALeave
            // 
            this.numericUpDownALeave.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownALeave.Location = new System.Drawing.Point(79, 104);
            this.numericUpDownALeave.Name = "numericUpDownALeave";
            this.numericUpDownALeave.Size = new System.Drawing.Size(173, 43);
            this.numericUpDownALeave.TabIndex = 0;
            this.numericUpDownALeave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownALeave.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPower.Location = new System.Drawing.Point(73, 50);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(179, 35);
            this.labelPower.TabIndex = 1;
            this.labelPower.Text = "Сила Ангела";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(79, 185);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(173, 65);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Играть";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonExit.Location = new System.Drawing.Point(79, 281);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(173, 44);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AngelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 337);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.numericUpDownALeave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AngelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ангел и дьявол";
            this.Load += new System.EventHandler(this.AngelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownALeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownALeave;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
    }
}

