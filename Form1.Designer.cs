namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.линейные = new System.Windows.Forms.TabPage();
            this.lblResultLinear1 = new System.Windows.Forms.Label();
            this.textZ = new System.Windows.Forms.TextBox();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.Z = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.Label();
            this.pictureЛинейные = new System.Windows.Forms.PictureBox();
            this.разветвляющийся = new System.Windows.Forms.TabPage();
            this.Вычисление1 = new System.Windows.Forms.Button();
            this.pictureРазветвляющийся = new System.Windows.Forms.PictureBox();
            this.X2 = new System.Windows.Forms.Label();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.Label();
            this.radioCos = new System.Windows.Forms.RadioButton();
            this.radioSqr = new System.Windows.Forms.RadioButton();
            this.radioExp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.Вычисление2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.линейные.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureЛинейные)).BeginInit();
            this.разветвляющийся.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureРазветвляющийся)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.линейные);
            this.tabControl1.Controls.Add(this.разветвляющийся);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // линейные
            // 
            this.линейные.Controls.Add(this.Вычисление1);
            this.линейные.Controls.Add(this.lblResultLinear1);
            this.линейные.Controls.Add(this.textZ);
            this.линейные.Controls.Add(this.textY1);
            this.линейные.Controls.Add(this.textX1);
            this.линейные.Controls.Add(this.Z);
            this.линейные.Controls.Add(this.Y1);
            this.линейные.Controls.Add(this.X1);
            this.линейные.Controls.Add(this.pictureЛинейные);
            this.линейные.Location = new System.Drawing.Point(4, 25);
            this.линейные.Name = "линейные";
            this.линейные.Padding = new System.Windows.Forms.Padding(3);
            this.линейные.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.линейные.Size = new System.Drawing.Size(714, 397);
            this.линейные.TabIndex = 0;
            this.линейные.Text = "линейные";
            this.линейные.UseVisualStyleBackColor = true;
            // 
            // lblResultLinear1
            // 
            this.lblResultLinear1.AutoSize = true;
            this.lblResultLinear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultLinear1.Location = new System.Drawing.Point(42, 312);
            this.lblResultLinear1.Name = "lblResultLinear1";
            this.lblResultLinear1.Size = new System.Drawing.Size(112, 20);
            this.lblResultLinear1.TabIndex = 7;
            this.lblResultLinear1.Text = "Результат:";
            this.lblResultLinear1.Click += new System.EventHandler(this.label4_Click);
            // 
            // textZ
            // 
            this.textZ.Location = new System.Drawing.Point(298, 222);
            this.textZ.Name = "textZ";
            this.textZ.Size = new System.Drawing.Size(100, 22);
            this.textZ.TabIndex = 6;
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(298, 189);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(100, 22);
            this.textY1.TabIndex = 5;
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(298, 161);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(100, 22);
            this.textX1.TabIndex = 4;
            this.textX1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.Location = new System.Drawing.Point(39, 215);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(248, 29);
            this.Z.TabIndex = 3;
            this.Z.Text = "Введите значение Z:";
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y1.Location = new System.Drawing.Point(39, 186);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(250, 29);
            this.Y1.TabIndex = 2;
            this.Y1.Text = "Введите значение Y:";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X1.Location = new System.Drawing.Point(41, 154);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(251, 29);
            this.X1.TabIndex = 1;
            this.X1.Text = "Введите значение X:";
            // 
            // pictureЛинейные
            // 
            this.pictureЛинейные.Image = ((System.Drawing.Image)(resources.GetObject("pictureЛинейные.Image")));
            this.pictureЛинейные.Location = new System.Drawing.Point(27, 16);
            this.pictureЛинейные.Name = "pictureЛинейные";
            this.pictureЛинейные.Size = new System.Drawing.Size(661, 121);
            this.pictureЛинейные.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureЛинейные.TabIndex = 0;
            this.pictureЛинейные.TabStop = false;
            // 
            // разветвляющийся
            // 
            this.разветвляющийся.Controls.Add(this.Вычисление2);
            this.разветвляющийся.Controls.Add(this.lblResult);
            this.разветвляющийся.Controls.Add(this.groupBox1);
            this.разветвляющийся.Controls.Add(this.Y2);
            this.разветвляющийся.Controls.Add(this.textY2);
            this.разветвляющийся.Controls.Add(this.textX2);
            this.разветвляющийся.Controls.Add(this.X2);
            this.разветвляющийся.Controls.Add(this.pictureРазветвляющийся);
            this.разветвляющийся.Location = new System.Drawing.Point(4, 25);
            this.разветвляющийся.Name = "разветвляющийся";
            this.разветвляющийся.Padding = new System.Windows.Forms.Padding(3);
            this.разветвляющийся.Size = new System.Drawing.Size(714, 397);
            this.разветвляющийся.TabIndex = 1;
            this.разветвляющийся.Text = "разветвляющийся";
            this.разветвляющийся.UseVisualStyleBackColor = true;
            // 
            // Вычисление1
            // 
            this.Вычисление1.Location = new System.Drawing.Point(70, 271);
            this.Вычисление1.Name = "Вычисление1";
            this.Вычисление1.Size = new System.Drawing.Size(107, 23);
            this.Вычисление1.TabIndex = 8;
            this.Вычисление1.Text = "Вычислить";
            this.Вычисление1.UseVisualStyleBackColor = true;
            this.Вычисление1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureРазветвляющийся
            // 
            this.pictureРазветвляющийся.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureРазветвляющийся.Image = ((System.Drawing.Image)(resources.GetObject("pictureРазветвляющийся.Image")));
            this.pictureРазветвляющийся.Location = new System.Drawing.Point(152, 16);
            this.pictureРазветвляющийся.Name = "pictureРазветвляющийся";
            this.pictureРазветвляющийся.Size = new System.Drawing.Size(341, 107);
            this.pictureРазветвляющийся.TabIndex = 0;
            this.pictureРазветвляющийся.TabStop = false;
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X2.Location = new System.Drawing.Point(46, 152);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(44, 29);
            this.X2.TabIndex = 1;
            this.X2.Text = "X=";
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(87, 152);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(100, 22);
            this.textX2.TabIndex = 2;
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(87, 192);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(100, 22);
            this.textY2.TabIndex = 3;
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y2.Location = new System.Drawing.Point(47, 185);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(43, 29);
            this.Y2.TabIndex = 4;
            this.Y2.Text = "Y=";
            // 
            // radioCos
            // 
            this.radioCos.AutoSize = true;
            this.radioCos.Location = new System.Drawing.Point(6, 21);
            this.radioCos.Name = "radioCos";
            this.radioCos.Size = new System.Drawing.Size(64, 20);
            this.radioCos.TabIndex = 5;
            this.radioCos.TabStop = true;
            this.radioCos.Text = "cos(x)";
            this.radioCos.UseVisualStyleBackColor = true;
            // 
            // radioSqr
            // 
            this.radioSqr.AutoSize = true;
            this.radioSqr.Location = new System.Drawing.Point(9, 47);
            this.radioSqr.Name = "radioSqr";
            this.radioSqr.Size = new System.Drawing.Size(61, 20);
            this.radioSqr.TabIndex = 6;
            this.radioSqr.TabStop = true;
            this.radioSqr.Text = "sqr(x)";
            this.radioSqr.UseVisualStyleBackColor = true;
            // 
            // radioExp
            // 
            this.radioExp.AutoSize = true;
            this.radioExp.Location = new System.Drawing.Point(9, 73);
            this.radioExp.Name = "radioExp";
            this.radioExp.Size = new System.Drawing.Size(64, 20);
            this.radioExp.TabIndex = 7;
            this.radioExp.TabStop = true;
            this.radioExp.Text = "exp(x)";
            this.radioExp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCos);
            this.groupBox1.Controls.Add(this.radioExp);
            this.groupBox1.Controls.Add(this.radioSqr);
            this.groupBox1.Location = new System.Drawing.Point(420, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор функции";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(43, 304);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(144, 29);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Результат:";
            // 
            // Вычисление2
            // 
            this.Вычисление2.Location = new System.Drawing.Point(51, 258);
            this.Вычисление2.Name = "Вычисление2";
            this.Вычисление2.Size = new System.Drawing.Size(115, 23);
            this.Вычисление2.TabIndex = 10;
            this.Вычисление2.Text = "Вычислить";
            this.Вычисление2.UseVisualStyleBackColor = true;
            this.Вычисление2.Click += new System.EventHandler(this.Вычисление2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.линейные.ResumeLayout(false);
            this.линейные.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureЛинейные)).EndInit();
            this.разветвляющийся.ResumeLayout(false);
            this.разветвляющийся.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureРазветвляющийся)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage линейные;
        private System.Windows.Forms.TabPage разветвляющийся;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label Y1;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.PictureBox pictureЛинейные;
        private System.Windows.Forms.Label lblResultLinear1;
        private System.Windows.Forms.TextBox textZ;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.Button Вычисление1;
        private System.Windows.Forms.PictureBox pictureРазветвляющийся;
        private System.Windows.Forms.Label Y2;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.RadioButton radioExp;
        private System.Windows.Forms.RadioButton radioSqr;
        private System.Windows.Forms.RadioButton radioCos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Вычисление2;
        private System.Windows.Forms.Label lblResult;
    }
}

