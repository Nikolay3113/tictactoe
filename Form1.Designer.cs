namespace tictactoe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Wins – 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(507, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "AI Wins – 0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 160);
            this.button1.TabIndex = 2;
            this.button1.Tag = "play";
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.playerClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 160);
            this.button2.TabIndex = 3;
            this.button2.Tag = "play";
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.playerClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(426, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 160);
            this.button3.TabIndex = 4;
            this.button3.Tag = "play";
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.playerClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(60, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 160);
            this.button4.TabIndex = 5;
            this.button4.Tag = "play";
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.playerClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(243, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 160);
            this.button5.TabIndex = 6;
            this.button5.Tag = "play";
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.playerClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(426, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 160);
            this.button6.TabIndex = 7;
            this.button6.Tag = "play";
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.playerClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(60, 385);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 160);
            this.button7.TabIndex = 8;
            this.button7.Tag = "play";
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.playerClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(243, 385);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 160);
            this.button8.TabIndex = 9;
            this.button8.Tag = "play";
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.playerClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(426, 385);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(177, 160);
            this.button9.TabIndex = 10;
            this.button9.Tag = "play";
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.playerClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(268, 576);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 39);
            this.button10.TabIndex = 11;
            this.button10.Text = "Restart";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // AImoves
            // 
            this.AImoves.Interval = 300;
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.comboBox1.Location = new System.Drawing.Point(451, 576);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "level";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 671);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe MOO ICT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer AImoves;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

