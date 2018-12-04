namespace Part5
{
    partial class SwarmAlgorithmParamsForm
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_globalMinImpact = new System.Windows.Forms.TextBox();
            this.tB_localMinImpact = new System.Windows.Forms.TextBox();
            this.tB_particleCount = new System.Windows.Forms.TextBox();
            this.tB_iterCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ok.Location = new System.Drawing.Point(316, 309);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(189, 62);
            this.btn_ok.TabIndex = 40;
            this.btn_ok.Text = "Продолжить";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Влияние глобаного минимума";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Влияние локального мнимума";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Численность роя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Количество итераций";
            // 
            // tB_globalMinImpact
            // 
            this.tB_globalMinImpact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_globalMinImpact.Location = new System.Drawing.Point(534, 218);
            this.tB_globalMinImpact.Margin = new System.Windows.Forms.Padding(4);
            this.tB_globalMinImpact.Name = "tB_globalMinImpact";
            this.tB_globalMinImpact.Size = new System.Drawing.Size(297, 38);
            this.tB_globalMinImpact.TabIndex = 33;
            // 
            // tB_localMinImpact
            // 
            this.tB_localMinImpact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_localMinImpact.Location = new System.Drawing.Point(534, 162);
            this.tB_localMinImpact.Margin = new System.Windows.Forms.Padding(4);
            this.tB_localMinImpact.Name = "tB_localMinImpact";
            this.tB_localMinImpact.Size = new System.Drawing.Size(297, 38);
            this.tB_localMinImpact.TabIndex = 32;
            // 
            // tB_particleCount
            // 
            this.tB_particleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_particleCount.Location = new System.Drawing.Point(534, 105);
            this.tB_particleCount.Margin = new System.Windows.Forms.Padding(4);
            this.tB_particleCount.Name = "tB_particleCount";
            this.tB_particleCount.Size = new System.Drawing.Size(297, 38);
            this.tB_particleCount.TabIndex = 31;
            // 
            // tB_iterCount
            // 
            this.tB_iterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_iterCount.Location = new System.Drawing.Point(534, 45);
            this.tB_iterCount.Margin = new System.Windows.Forms.Padding(4);
            this.tB_iterCount.Name = "tB_iterCount";
            this.tB_iterCount.Size = new System.Drawing.Size(297, 38);
            this.tB_iterCount.TabIndex = 30;
            // 
            // SwarmAlgorithmParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 391);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_globalMinImpact);
            this.Controls.Add(this.tB_localMinImpact);
            this.Controls.Add(this.tB_particleCount);
            this.Controls.Add(this.tB_iterCount);
            this.Name = "SwarmAlgorithmParamsForm";
            this.Text = "SwarmAlgorithmParamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_globalMinImpact;
        private System.Windows.Forms.TextBox tB_localMinImpact;
        private System.Windows.Forms.TextBox tB_particleCount;
        private System.Windows.Forms.TextBox tB_iterCount;
    }
}