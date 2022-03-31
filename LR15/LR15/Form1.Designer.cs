namespace LR15
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
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.panelChooseColor = new System.Windows.Forms.Panel();
            this.txtChooseFont = new System.Windows.Forms.TextBox();
            this.txtChooseFile = new System.Windows.Forms.TextBox();
            this.txtChooseFolder = new System.Windows.Forms.TextBox();
            this.buttonAns = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(50, 44);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(119, 23);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "Выбор цвета";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(50, 108);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(119, 23);
            this.btnChooseFont.TabIndex = 1;
            this.btnChooseFont.Text = "Выбор шрифта";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(50, 167);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(119, 23);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Выбор файла";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(50, 224);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(119, 23);
            this.btnChooseFolder.TabIndex = 3;
            this.btnChooseFolder.Text = "Выбор каталога";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // panelChooseColor
            // 
            this.panelChooseColor.Location = new System.Drawing.Point(218, 42);
            this.panelChooseColor.Name = "panelChooseColor";
            this.panelChooseColor.Size = new System.Drawing.Size(570, 25);
            this.panelChooseColor.TabIndex = 4;
            // 
            // txtChooseFont
            // 
            this.txtChooseFont.Location = new System.Drawing.Point(218, 111);
            this.txtChooseFont.Name = "txtChooseFont";
            this.txtChooseFont.Size = new System.Drawing.Size(570, 20);
            this.txtChooseFont.TabIndex = 5;
            // 
            // txtChooseFile
            // 
            this.txtChooseFile.Location = new System.Drawing.Point(218, 170);
            this.txtChooseFile.Name = "txtChooseFile";
            this.txtChooseFile.Size = new System.Drawing.Size(570, 20);
            this.txtChooseFile.TabIndex = 6;
            // 
            // txtChooseFolder
            // 
            this.txtChooseFolder.Location = new System.Drawing.Point(218, 227);
            this.txtChooseFolder.Name = "txtChooseFolder";
            this.txtChooseFolder.Size = new System.Drawing.Size(570, 20);
            this.txtChooseFolder.TabIndex = 7;
            // 
            // buttonAns
            // 
            this.buttonAns.Location = new System.Drawing.Point(329, 319);
            this.buttonAns.Name = "buttonAns";
            this.buttonAns.Size = new System.Drawing.Size(118, 63);
            this.buttonAns.TabIndex = 8;
            this.buttonAns.Text = "Вариант 6     Рассчитать";
            this.buttonAns.UseVisualStyleBackColor = true;
            this.buttonAns.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(113, 301);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(143, 20);
            this.textBoxX.TabIndex = 9;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(113, 384);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(143, 20);
            this.textBoxN.TabIndex = 10;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(92, 301);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(15, 16);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "X";
            // 
            // labelN
            // 
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(17, 358);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(90, 83);
            this.labelN.TabIndex = 12;
            this.labelN.Text = "Количество слагаемых в правой части выражения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ответ = ";
            // 
            // textBoxAns
            // 
            this.textBoxAns.Location = new System.Drawing.Point(546, 341);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(184, 20);
            this.textBoxAns.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonAns);
            this.Controls.Add(this.txtChooseFolder);
            this.Controls.Add(this.txtChooseFile);
            this.Controls.Add(this.txtChooseFont);
            this.Controls.Add(this.panelChooseColor);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.btnChooseColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Panel panelChooseColor;
        private System.Windows.Forms.TextBox txtChooseFont;
        private System.Windows.Forms.TextBox txtChooseFile;
        private System.Windows.Forms.TextBox txtChooseFolder;
        private System.Windows.Forms.Button buttonAns;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAns;
    }
}

