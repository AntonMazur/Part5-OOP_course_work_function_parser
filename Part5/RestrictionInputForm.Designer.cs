namespace Part5
{
    partial class RestrictionInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_varName = new System.Windows.Forms.Label();
            this.textB_restriction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ограничения для переменной";
            // 
            // lbl_varName
            // 
            this.lbl_varName.AutoSize = true;
            this.lbl_varName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_varName.Location = new System.Drawing.Point(414, 47);
            this.lbl_varName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_varName.Name = "lbl_varName";
            this.lbl_varName.Size = new System.Drawing.Size(0, 31);
            this.lbl_varName.TabIndex = 25;
            // 
            // textB_restriction
            // 
            this.textB_restriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textB_restriction.Location = new System.Drawing.Point(36, 120);
            this.textB_restriction.Margin = new System.Windows.Forms.Padding(4);
            this.textB_restriction.Name = "textB_restriction";
            this.textB_restriction.Size = new System.Drawing.Size(297, 38);
            this.textB_restriction.TabIndex = 26;
            this.textB_restriction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textB_restriction_KeyDown);
            // 
            // RestrictionInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 228);
            this.Controls.Add(this.textB_restriction);
            this.Controls.Add(this.lbl_varName);
            this.Controls.Add(this.label1);
            this.Name = "RestrictionInputForm";
            this.Text = "Ограничения области поиска минимума";
            this.Load += new System.EventHandler(this.RestrictionInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_varName;
        private System.Windows.Forms.TextBox textB_restriction;
    }
}