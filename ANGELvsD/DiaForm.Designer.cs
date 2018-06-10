namespace ANGELvsD
{
    partial class DiaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaForm));
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "В начало";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Location = new System.Drawing.Point(119, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(549, 546);
            this.panel.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 25);
            this.label.TabIndex = 0;
            // 
            // DiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 570);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ангел и дьявол";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DiaForm_Load);
            this.Shown += new System.EventHandler(this.DiaForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label;
        
    }
}