namespace Part5
{
    partial class GeneticAlgorithmParamsForm
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
            this.tB_iterCount = new System.Windows.Forms.TextBox();
            this.tB_individualsCount = new System.Windows.Forms.TextBox();
            this.tB_crossoverProb = new System.Windows.Forms.TextBox();
            this.tB_mutationProb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_maxGenotypeDelta = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_iterCount
            // 
            this.tB_iterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_iterCount.Location = new System.Drawing.Point(561, 44);
            this.tB_iterCount.Margin = new System.Windows.Forms.Padding(4);
            this.tB_iterCount.Name = "tB_iterCount";
            this.tB_iterCount.Size = new System.Drawing.Size(297, 38);
            this.tB_iterCount.TabIndex = 19;
            // 
            // tB_individualsCount
            // 
            this.tB_individualsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_individualsCount.Location = new System.Drawing.Point(561, 104);
            this.tB_individualsCount.Margin = new System.Windows.Forms.Padding(4);
            this.tB_individualsCount.Name = "tB_individualsCount";
            this.tB_individualsCount.Size = new System.Drawing.Size(297, 38);
            this.tB_individualsCount.TabIndex = 20;
            // 
            // tB_crossoverProb
            // 
            this.tB_crossoverProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_crossoverProb.Location = new System.Drawing.Point(561, 161);
            this.tB_crossoverProb.Margin = new System.Windows.Forms.Padding(4);
            this.tB_crossoverProb.Name = "tB_crossoverProb";
            this.tB_crossoverProb.Size = new System.Drawing.Size(297, 38);
            this.tB_crossoverProb.TabIndex = 21;
            // 
            // tB_mutationProb
            // 
            this.tB_mutationProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_mutationProb.Location = new System.Drawing.Point(561, 217);
            this.tB_mutationProb.Margin = new System.Windows.Forms.Padding(4);
            this.tB_mutationProb.Name = "tB_mutationProb";
            this.tB_mutationProb.Size = new System.Drawing.Size(297, 38);
            this.tB_mutationProb.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Количество итераций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Количество особей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Вероятность скрещивания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Вероятность мутации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Максимальное изменение гена";
            // 
            // tB_maxGenotypeDelta
            // 
            this.tB_maxGenotypeDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_maxGenotypeDelta.Location = new System.Drawing.Point(561, 275);
            this.tB_maxGenotypeDelta.Margin = new System.Windows.Forms.Padding(4);
            this.tB_maxGenotypeDelta.Name = "tB_maxGenotypeDelta";
            this.tB_maxGenotypeDelta.Size = new System.Drawing.Size(297, 38);
            this.tB_maxGenotypeDelta.TabIndex = 27;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ok.Location = new System.Drawing.Point(355, 355);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(189, 62);
            this.btn_ok.TabIndex = 29;
            this.btn_ok.Text = "Продолжить";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // GeneticAlgorithmParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 438);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_maxGenotypeDelta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_mutationProb);
            this.Controls.Add(this.tB_crossoverProb);
            this.Controls.Add(this.tB_individualsCount);
            this.Controls.Add(this.tB_iterCount);
            this.Name = "GeneticAlgorithmParamsForm";
            this.Text = "GeneticAlgorithmParamsForm";
            this.Load += new System.EventHandler(this.GeneticAlgorithmParamsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_iterCount;
        private System.Windows.Forms.TextBox tB_individualsCount;
        private System.Windows.Forms.TextBox tB_crossoverProb;
        private System.Windows.Forms.TextBox tB_mutationProb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_maxGenotypeDelta;
        private System.Windows.Forms.Button btn_ok;
    }
}