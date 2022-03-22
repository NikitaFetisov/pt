namespace LR14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxA = new System.Windows.Forms.ToolStripComboBox();
            this.ComboBoxB = new System.Windows.Forms.ToolStripComboBox();
            this.TextBoxX = new System.Windows.Forms.ToolStripTextBox();
            this.TextBoxY = new System.Windows.Forms.ToolStripTextBox();
            this.TextBoxZ = new System.Windows.Forms.ToolStripTextBox();
            this.aToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.Answer = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.MainStatusStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.aToolStripMenuItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.aToolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Answer2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripDropDownButtonDateTime = new System.Windows.Forms.ToolStripDropDownButton();
            this.Pervii = new System.Windows.Forms.ToolStripMenuItem();
            this.Vtoroy = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adfToolStripMenuItem
            // 
            this.adfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboBoxA,
            this.ComboBoxB,
            this.TextBoxX,
            this.TextBoxY,
            this.TextBoxZ,
            this.aToolStripMenuItem4,
            this.Answer});
            this.adfToolStripMenuItem.Name = "adfToolStripMenuItem";
            this.adfToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adfToolStripMenuItem.Text = "1 Задание";
            // 
            // ComboBoxA
            // 
            this.ComboBoxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComboBoxA.Name = "ComboBoxA";
            this.ComboBoxA.Size = new System.Drawing.Size(180, 23);
            this.ComboBoxA.ToolTipText = "const A";
            this.ComboBoxA.SelectedIndexChanged += new System.EventHandler(this.ComboBoxA_SelectedIndexChanged);
            // 
            // ComboBoxB
            // 
            this.ComboBoxB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComboBoxB.Name = "ComboBoxB";
            this.ComboBoxB.Size = new System.Drawing.Size(420, 23);
            this.ComboBoxB.ToolTipText = "const B";
            this.ComboBoxB.SelectedIndexChanged += new System.EventHandler(this.ComboBoxB_SelectedIndexChanged);
            // 
            // TextBoxX
            // 
            this.TextBoxX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(240, 23);
            this.TextBoxX.Text = "0";
            this.TextBoxX.ToolTipText = "X";
            this.TextBoxX.TextChanged += new System.EventHandler(this.TextBoxX_TextChanged);
            // 
            // TextBoxY
            // 
            this.TextBoxY.AutoSize = false;
            this.TextBoxY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(300, 23);
            this.TextBoxY.Text = "0";
            this.TextBoxY.ToolTipText = "Y";
            this.TextBoxY.TextChanged += new System.EventHandler(this.TextBoxY_TextChanged);
            // 
            // TextBoxZ
            // 
            this.TextBoxZ.AutoSize = false;
            this.TextBoxZ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxZ.Name = "TextBoxZ";
            this.TextBoxZ.Size = new System.Drawing.Size(360, 23);
            this.TextBoxZ.Text = "0";
            this.TextBoxZ.ToolTipText = "Z";
            this.TextBoxZ.TextChanged += new System.EventHandler(this.TextBoxZ_TextChanged);
            // 
            // aToolStripMenuItem4
            // 
            this.aToolStripMenuItem4.Name = "aToolStripMenuItem4";
            this.aToolStripMenuItem4.Size = new System.Drawing.Size(477, 6);
            // 
            // Answer
            // 
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(480, 22);
            this.Answer.Text = "Рассчитать";
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.aToolStripMenuItem2,
            this.aToolStripMenuItem3,
            this.aToolStripMenuItem6,
            this.exitToolStripMenuItem});
            this.MainStatusStrip.Name = "contextMenuStrip1";
            this.MainStatusStrip.Size = new System.Drawing.Size(421, 134);
            this.MainStatusStrip.Text = "0";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aToolStripMenuItem.Items.AddRange(new object[] {
            "White",
            "Red",
            "Black",
            "Blue",
            "Yellow"});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.aToolStripMenuItem.ToolTipText = "Готовые цвета";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(240, 23);
            this.aToolStripMenuItem1.Text = "0";
            this.aToolStripMenuItem1.ToolTipText = "Red";
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(300, 23);
            this.aToolStripMenuItem2.Text = "0";
            this.aToolStripMenuItem2.ToolTipText = "Green";
            // 
            // aToolStripMenuItem3
            // 
            this.aToolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aToolStripMenuItem3.Name = "aToolStripMenuItem3";
            this.aToolStripMenuItem3.Size = new System.Drawing.Size(360, 23);
            this.aToolStripMenuItem3.Text = "0";
            this.aToolStripMenuItem3.ToolTipText = "Blue";
            // 
            // aToolStripMenuItem6
            // 
            this.aToolStripMenuItem6.Name = "aToolStripMenuItem6";
            this.aToolStripMenuItem6.Size = new System.Drawing.Size(417, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Answer2,
            this.toolStripStatusLabelClock,
            this.ToolStripDropDownButtonDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Answer2
            // 
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(721, 17);
            this.Answer2.Spring = true;
            this.Answer2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            this.toolStripStatusLabelClock.Size = new System.Drawing.Size(4, 17);
            // 
            // ToolStripDropDownButtonDateTime
            // 
            this.ToolStripDropDownButtonDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDropDownButtonDateTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pervii,
            this.Vtoroy});
            this.ToolStripDropDownButtonDateTime.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDropDownButtonDateTime.Image")));
            this.ToolStripDropDownButtonDateTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButtonDateTime.Name = "ToolStripDropDownButtonDateTime";
            this.ToolStripDropDownButtonDateTime.Size = new System.Drawing.Size(29, 20);
            this.ToolStripDropDownButtonDateTime.Text = "2 Задание";
            // 
            // Pervii
            // 
            this.Pervii.Name = "Pervii";
            this.Pervii.Size = new System.Drawing.Size(187, 22);
            this.Pervii.Text = "Первое уравнение";
            this.Pervii.Click += new System.EventHandler(this.Pervii_Click);
            // 
            // Vtoroy
            // 
            this.Vtoroy.Name = "Vtoroy";
            this.Vtoroy.Size = new System.Drawing.Size(187, 22);
            this.Vtoroy.Text = "Квадраты координат";
            this.Vtoroy.Click += new System.EventHandler(this.Vtoroy_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timerDateTimeUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adfToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ComboBoxA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripTextBox TextBoxX;
        private System.Windows.Forms.ToolStripTextBox TextBoxY;
        private System.Windows.Forms.ToolStripTextBox TextBoxZ;
        private System.Windows.Forms.ToolStripSeparator aToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Answer;
        private System.Windows.Forms.ContextMenuStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripComboBox aToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox aToolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator aToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ComboBoxB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Answer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButtonDateTime;
        private System.Windows.Forms.ToolStripMenuItem Pervii;
        private System.Windows.Forms.ToolStripMenuItem Vtoroy;
        private System.Windows.Forms.Timer timer1;
    }
}

