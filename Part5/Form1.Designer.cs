namespace Part5
{
    partial class Form1
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
            this.richTextBox_func = new System.Windows.Forms.RichTextBox();
            this.button_summation = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_tg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_paramsVals = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_directionVals = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_keyVals = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_Eps = new System.Windows.Forms.TextBox();
            this.textBox_maxCountIter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_funcMin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_keyVals)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_func
            // 
            this.richTextBox_func.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_func.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox_func.Location = new System.Drawing.Point(221, 220);
            this.richTextBox_func.Name = "richTextBox_func";
            this.richTextBox_func.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_func.Size = new System.Drawing.Size(481, 375);
            this.richTextBox_func.TabIndex = 1;
            this.richTextBox_func.Text = "Your function must be here";
            this.richTextBox_func.Enter += new System.EventHandler(this.richTextBox_func_Enter);
            this.richTextBox_func.Leave += new System.EventHandler(this.richTextBox_func_Leave);
            // 
            // button_summation
            // 
            this.button_summation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_summation.Location = new System.Drawing.Point(14, 28);
            this.button_summation.Name = "button_summation";
            this.button_summation.Size = new System.Drawing.Size(142, 40);
            this.button_summation.TabIndex = 2;
            this.button_summation.Text = "∑(a;b)(...)";
            this.button_summation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_summation.UseVisualStyleBackColor = true;
            this.button_summation.Click += new System.EventHandler(this.button_summation_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiplication.Location = new System.Drawing.Point(14, 79);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(142, 40);
            this.button_multiplication.TabIndex = 3;
            this.button_multiplication.Text = "∏(a;b)(...)";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_cos
            // 
            this.button_cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cos.Location = new System.Drawing.Point(14, 181);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(142, 40);
            this.button_cos.TabIndex = 4;
            this.button_cos.Text = "cos(...)";
            this.button_cos.UseVisualStyleBackColor = true;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // button_sin
            // 
            this.button_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sin.Location = new System.Drawing.Point(14, 130);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(142, 40);
            this.button_sin.TabIndex = 5;
            this.button_sin.Text = "sin(...)";
            this.button_sin.UseVisualStyleBackColor = true;
            this.button_sin.Click += new System.EventHandler(this.button_sin_Click);
            // 
            // button_tg
            // 
            this.button_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tg.Location = new System.Drawing.Point(14, 232);
            this.button_tg.Name = "button_tg";
            this.button_tg.Size = new System.Drawing.Size(142, 40);
            this.button_tg.TabIndex = 6;
            this.button_tg.Text = "tg(...)";
            this.button_tg.UseVisualStyleBackColor = true;
            this.button_tg.Click += new System.EventHandler(this.button_tg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.button_tg);
            this.groupBox1.Controls.Add(this.button_sin);
            this.groupBox1.Controls.Add(this.button_cos);
            this.groupBox1.Controls.Add(this.button_multiplication);
            this.groupBox1.Controls.Add(this.button_summation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(26, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 292);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Math functions";
            // 
            // textBox_paramsVals
            // 
            this.textBox_paramsVals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_paramsVals.Location = new System.Drawing.Point(478, 54);
            this.textBox_paramsVals.Name = "textBox_paramsVals";
            this.textBox_paramsVals.Size = new System.Drawing.Size(224, 32);
            this.textBox_paramsVals.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(473, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Start point";
            // 
            // textBox_directionVals
            // 
            this.textBox_directionVals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_directionVals.Location = new System.Drawing.Point(478, 137);
            this.textBox_directionVals.Name = "textBox_directionVals";
            this.textBox_directionVals.Size = new System.Drawing.Size(224, 32);
            this.textBox_directionVals.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(473, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start direction";
            // 
            // dataGridView_keyVals
            // 
            this.dataGridView_keyVals.AllowUserToOrderColumns = true;
            this.dataGridView_keyVals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_keyVals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_keyVals.Location = new System.Drawing.Point(724, 114);
            this.dataGridView_keyVals.Name = "dataGridView_keyVals";
            this.dataGridView_keyVals.ReadOnly = true;
            this.dataGridView_keyVals.Size = new System.Drawing.Size(609, 481);
            this.dataGridView_keyVals.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(216, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "EPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(216, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Max count of iterations";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(40, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(40, 114);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(142, 55);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_Eps
            // 
            this.textBox_Eps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Eps.Location = new System.Drawing.Point(221, 54);
            this.textBox_Eps.Name = "textBox_Eps";
            this.textBox_Eps.Size = new System.Drawing.Size(224, 32);
            this.textBox_Eps.TabIndex = 17;
            // 
            // textBox_maxCountIter
            // 
            this.textBox_maxCountIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_maxCountIter.Location = new System.Drawing.Point(222, 137);
            this.textBox_maxCountIter.Name = "textBox_maxCountIter";
            this.textBox_maxCountIter.Size = new System.Drawing.Size(224, 32);
            this.textBox_maxCountIter.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(718, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Function minimum: ";
            // 
            // label_funcMin
            // 
            this.label_funcMin.AutoSize = true;
            this.label_funcMin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_funcMin.Location = new System.Drawing.Point(719, 59);
            this.label_funcMin.Name = "label_funcMin";
            this.label_funcMin.Size = new System.Drawing.Size(46, 27);
            this.label_funcMin.TabIndex = 20;
            this.label_funcMin.Text = "[...]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 641);
            this.Controls.Add(this.label_funcMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_maxCountIter);
            this.Controls.Add(this.textBox_Eps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_keyVals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_directionVals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_paramsVals);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.richTextBox_func);
            this.Controls.Add(this.button1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Function parser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_keyVals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox_func;
        private System.Windows.Forms.Button button_summation;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_tg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_paramsVals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_directionVals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_keyVals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_Eps;
        private System.Windows.Forms.TextBox textBox_maxCountIter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_funcMin;
    }
}

