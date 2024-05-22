namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.sicilTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.epostaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.odanumarasiTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iseBaslamaTarihiDateTimePicker = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.unvanTextBox = new System.Windows.Forms.TextBox();
            this.bolumTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelToolStripMenuItem,
            this.donanımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genelToolStripMenuItem
            // 
            this.genelToolStripMenuItem.Name = "genelToolStripMenuItem";
            this.genelToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.genelToolStripMenuItem.Text = "Genel";
            // 
            // donanımToolStripMenuItem
            // 
            this.donanımToolStripMenuItem.Name = "donanımToolStripMenuItem";
            this.donanımToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.donanımToolStripMenuItem.Text = "Donanım";
            this.donanımToolStripMenuItem.Click += new System.EventHandler(this.donanımToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ünvan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(90, 36);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(153, 20);
            this.adTextBox.TabIndex = 2;
            this.adTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(90, 68);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(153, 20);
            this.soyadTextBox.TabIndex = 2;
            // 
            // sicilTextBox
            // 
            this.sicilTextBox.Location = new System.Drawing.Point(90, 109);
            this.sicilTextBox.Name = "sicilTextBox";
            this.sicilTextBox.Size = new System.Drawing.Size(153, 20);
            this.sicilTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bölüm";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sicil no";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "E-posta";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // epostaTextBox
            // 
            this.epostaTextBox.Location = new System.Drawing.Point(90, 293);
            this.epostaTextBox.Name = "epostaTextBox";
            this.epostaTextBox.Size = new System.Drawing.Size(153, 20);
            this.epostaTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-1, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Oda Numarası";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // odanumarasiTextbox
            // 
            this.odanumarasiTextbox.Location = new System.Drawing.Point(121, 346);
            this.odanumarasiTextbox.Name = "odanumarasiTextbox";
            this.odanumarasiTextbox.Size = new System.Drawing.Size(123, 20);
            this.odanumarasiTextbox.TabIndex = 2;
            this.odanumarasiTextbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(-3, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "İşe başlama tarihi";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // iseBaslamaTarihiDateTimePicker
            // 
            this.iseBaslamaTarihiDateTimePicker.Location = new System.Drawing.Point(143, 395);
            this.iseBaslamaTarihiDateTimePicker.Name = "iseBaslamaTarihiDateTimePicker";
            this.iseBaslamaTarihiDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.iseBaslamaTarihiDateTimePicker.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(11, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unvanTextBox
            // 
            this.unvanTextBox.Location = new System.Drawing.Point(90, 195);
            this.unvanTextBox.Name = "unvanTextBox";
            this.unvanTextBox.Size = new System.Drawing.Size(153, 20);
            this.unvanTextBox.TabIndex = 2;
            this.unvanTextBox.TextChanged += new System.EventHandler(this.unvanTextBox_TextChanged);
            // 
            // bolumTextBox
            // 
            this.bolumTextBox.Location = new System.Drawing.Point(90, 250);
            this.bolumTextBox.Name = "bolumTextBox";
            this.bolumTextBox.Size = new System.Drawing.Size(153, 20);
            this.bolumTextBox.TabIndex = 2;
            this.bolumTextBox.TextChanged += new System.EventHandler(this.unvanTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1150, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iseBaslamaTarihiDateTimePicker);
            this.Controls.Add(this.odanumarasiTextbox);
            this.Controls.Add(this.epostaTextBox);
            this.Controls.Add(this.bolumTextBox);
            this.Controls.Add(this.unvanTextBox);
            this.Controls.Add(this.sicilTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donanımToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox sicilTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox epostaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox odanumarasiTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iseBaslamaTarihiDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox unvanTextBox;
        private System.Windows.Forms.TextBox bolumTextBox;
    }
}

