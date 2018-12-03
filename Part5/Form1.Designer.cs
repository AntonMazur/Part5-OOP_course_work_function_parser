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
            this.dataGridView_keyVals = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_funcMin = new System.Windows.Forms.Label();
            this.btn_setRestrictions = new System.Windows.Forms.Button();
            this.rbtn_genetic = new System.Windows.Forms.RadioButton();
            this.rbtn_role = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_keyVals)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_func
            // 
            this.richTextBox_func.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_func.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox_func.Location = new System.Drawing.Point(294, 357);
            this.richTextBox_func.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_func.Name = "richTextBox_func";
            this.richTextBox_func.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_func.Size = new System.Drawing.Size(640, 461);
            this.richTextBox_func.TabIndex = 1;
            this.richTextBox_func.Text = "Your function must be here";
            this.richTextBox_func.Enter += new System.EventHandler(this.richTextBox_func_Enter);
            this.richTextBox_func.Leave += new System.EventHandler(this.richTextBox_func_Leave);
            // 
            // button_summation
            // 
            this.button_summation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_summation.Location = new System.Drawing.Point(19, 34);
            this.button_summation.Margin = new System.Windows.Forms.Padding(4);
            this.button_summation.Name = "button_summation";
            this.button_summation.Size = new System.Drawing.Size(189, 49);
            this.button_summation.TabIndex = 2;
            this.button_summation.Text = "∑(a;b)(...)";
            this.button_summation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_summation.UseVisualStyleBackColor = true;
            this.button_summation.Click += new System.EventHandler(this.button_summation_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiplication.Location = new System.Drawing.Point(19, 97);
            this.button_multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(189, 49);
            this.button_multiplication.TabIndex = 3;
            this.button_multiplication.Text = "∏(a;b)(...)";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_cos
            // 
            this.button_cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cos.Location = new System.Drawing.Point(19, 223);
            this.button_cos.Margin = new System.Windows.Forms.Padding(4);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(189, 49);
            this.button_cos.TabIndex = 4;
            this.button_cos.Text = "cos(...)";
            this.button_cos.UseVisualStyleBackColor = true;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // button_sin
            // 
            this.button_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sin.Location = new System.Drawing.Point(19, 160);
            this.button_sin.Margin = new System.Windows.Forms.Padding(4);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(189, 49);
            this.button_sin.TabIndex = 5;
            this.button_sin.Text = "sin(...)";
            this.button_sin.UseVisualStyleBackColor = true;
            this.button_sin.Click += new System.EventHandler(this.button_sin_Click);
            // 
            // button_tg
            // 
            this.button_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tg.Location = new System.Drawing.Point(19, 286);
            this.button_tg.Margin = new System.Windows.Forms.Padding(4);
            this.button_tg.Name = "button_tg";
            this.button_tg.Size = new System.Drawing.Size(189, 49);
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
            this.groupBox1.Location = new System.Drawing.Point(34, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(240, 359);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Math functions";
            // 
            // dataGridView_keyVals
            // 
            this.dataGridView_keyVals.AllowUserToOrderColumns = true;
            this.dataGridView_keyVals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_keyVals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_keyVals.Location = new System.Drawing.Point(965, 140);
            this.dataGridView_keyVals.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_keyVals.Name = "dataGridView_keyVals";
            this.dataGridView_keyVals.ReadOnly = true;
            this.dataGridView_keyVals.Size = new System.Drawing.Size(812, 592);
            this.dataGridView_keyVals.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(53, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(53, 140);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(189, 68);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(957, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "Function minimum: ";
            // 
            // label_funcMin
            // 
            this.label_funcMin.AutoSize = true;
            this.label_funcMin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_funcMin.Location = new System.Drawing.Point(959, 73);
            this.label_funcMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_funcMin.Name = "label_funcMin";
            this.label_funcMin.Size = new System.Drawing.Size(59, 34);
            this.label_funcMin.TabIndex = 20;
            this.label_funcMin.Text = "[...]";
            // 
            // btn_setRestrictions
            // 
            this.btn_setRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_setRestrictions.Location = new System.Drawing.Point(53, 232);
            this.btn_setRestrictions.Margin = new System.Windows.Forms.Padding(4);
            this.btn_setRestrictions.Name = "btn_setRestrictions";
            this.btn_setRestrictions.Size = new System.Drawing.Size(189, 75);
            this.btn_setRestrictions.TabIndex = 21;
            this.btn_setRestrictions.Text = "Задать ограничения";
            this.btn_setRestrictions.UseVisualStyleBackColor = true;
            this.btn_setRestrictions.Click += new System.EventHandler(this.btn_setRestrictions_Click);
            // 
            // rbtn_genetic
            // 
            this.rbtn_genetic.AutoSize = true;
            this.rbtn_genetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_genetic.Location = new System.Drawing.Point(25, 32);
            this.rbtn_genetic.Name = "rbtn_genetic";
            this.rbtn_genetic.Size = new System.Drawing.Size(351, 36);
            this.rbtn_genetic.TabIndex = 22;
            this.rbtn_genetic.TabStop = true;
            this.rbtn_genetic.Text = "Генетический алгоритм";
            this.rbtn_genetic.UseVisualStyleBackColor = true;
            // 
            // rbtn_role
            // 
            this.rbtn_role.AutoSize = true;
            this.rbtn_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_role.Location = new System.Drawing.Point(25, 74);
            this.rbtn_role.Name = "rbtn_role";
            this.rbtn_role.Size = new System.Drawing.Size(281, 36);
            this.rbtn_role.TabIndex = 23;
            this.rbtn_role.TabStop = true;
            this.rbtn_role.Text = "Ролевой алгоритм";
            this.rbtn_role.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.rbtn_genetic);
            this.groupBox2.Controls.Add(this.rbtn_role);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(304, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 145);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Используемый алгоритм";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 854);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_setRestrictions);
            this.Controls.Add(this.label_funcMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_keyVals);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.richTextBox_func);
            this.Controls.Add(this.button1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Function parser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_keyVals)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView_keyVals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_funcMin;
        private System.Windows.Forms.Button btn_setRestrictions;
        private System.Windows.Forms.RadioButton rbtn_genetic;
        private System.Windows.Forms.RadioButton rbtn_role;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

