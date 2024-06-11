namespace Tetris
{
    partial class Form1
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
            this.buttonshowall = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxmanje = new System.Windows.Forms.TextBox();
            this.textBoxvise = new System.Windows.Forms.TextBox();
            this.textBoxime = new System.Windows.Forms.TextBox();
            this.textBoxprezime = new System.Windows.Forms.TextBox();
            this.textBoxpoeni = new System.Windows.Forms.TextBox();
            this.buttonunesi = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonshowall
            // 
            this.buttonshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonshowall.Location = new System.Drawing.Point(639, 54);
            this.buttonshowall.Name = "buttonshowall";
            this.buttonshowall.Size = new System.Drawing.Size(155, 34);
            this.buttonshowall.TabIndex = 0;
            this.buttonshowall.Text = "Prikaži sve";
            this.buttonshowall.UseVisualStyleBackColor = true;
            this.buttonshowall.Click += new System.EventHandler(this.buttonshowall_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 624);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Po Imenu",
            "Po Poenima"});
            this.comboBox1.Location = new System.Drawing.Point(376, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 34);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxmanje
            // 
            this.textBoxmanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxmanje.Location = new System.Drawing.Point(634, 150);
            this.textBoxmanje.Name = "textBoxmanje";
            this.textBoxmanje.Size = new System.Drawing.Size(100, 26);
            this.textBoxmanje.TabIndex = 3;
            this.textBoxmanje.TextChanged += new System.EventHandler(this.textBoxmanje_TextChanged);
            this.textBoxmanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxmanje_KeyPress);
            // 
            // textBoxvise
            // 
            this.textBoxvise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxvise.Location = new System.Drawing.Point(634, 110);
            this.textBoxvise.Name = "textBoxvise";
            this.textBoxvise.Size = new System.Drawing.Size(100, 26);
            this.textBoxvise.TabIndex = 4;
            this.textBoxvise.TextChanged += new System.EventHandler(this.textBoxvise_TextChanged);
            this.textBoxvise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxvise_KeyPress);
            // 
            // textBoxime
            // 
            this.textBoxime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxime.Location = new System.Drawing.Point(403, 412);
            this.textBoxime.Name = "textBoxime";
            this.textBoxime.Size = new System.Drawing.Size(117, 31);
            this.textBoxime.TabIndex = 5;
            this.textBoxime.TextChanged += new System.EventHandler(this.textBoxime_TextChanged);
            this.textBoxime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxime_KeyPress);
            // 
            // textBoxprezime
            // 
            this.textBoxprezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxprezime.Location = new System.Drawing.Point(534, 412);
            this.textBoxprezime.Name = "textBoxprezime";
            this.textBoxprezime.Size = new System.Drawing.Size(120, 31);
            this.textBoxprezime.TabIndex = 6;
            this.textBoxprezime.TextChanged += new System.EventHandler(this.textBoxprezime_TextChanged);
            this.textBoxprezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxprezime_KeyPress);
            // 
            // textBoxpoeni
            // 
            this.textBoxpoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpoeni.Location = new System.Drawing.Point(670, 412);
            this.textBoxpoeni.Name = "textBoxpoeni";
            this.textBoxpoeni.Size = new System.Drawing.Size(119, 31);
            this.textBoxpoeni.TabIndex = 7;
            this.textBoxpoeni.TextChanged += new System.EventHandler(this.textBoxpoeni_TextChanged);
            this.textBoxpoeni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxpoeni_KeyPress);
            // 
            // buttonunesi
            // 
            this.buttonunesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonunesi.Location = new System.Drawing.Point(514, 480);
            this.buttonunesi.Name = "buttonunesi";
            this.buttonunesi.Size = new System.Drawing.Size(165, 62);
            this.buttonunesi.TabIndex = 8;
            this.buttonunesi.Text = "Unesi";
            this.buttonunesi.UseVisualStyleBackColor = true;
            this.buttonunesi.Click += new System.EventHandler(this.buttonunesi_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.textBoxsearch.Location = new System.Drawing.Point(574, 297);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(173, 39);
            this.textBoxsearch.TabIndex = 9;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            this.textBoxsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsearch_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(319, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 683);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rezultat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.Location = new System.Drawing.Point(740, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "poena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.Location = new System.Drawing.Point(740, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "poena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label6.Location = new System.Drawing.Point(383, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prikaži one koji imaju više od : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label7.Location = new System.Drawing.Point(367, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Prikaži one koji imaju manje od : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.label8.Location = new System.Drawing.Point(428, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pretraži";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.label9.Location = new System.Drawing.Point(468, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Unesite takmičara:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tetris.Properties.Resources.tetristransparentlogov2;
            this.pictureBox2.Location = new System.Drawing.Point(436, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.button1.Location = new System.Drawing.Point(319, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(554, 127);
            this.button1.TabIndex = 21;
            this.button1.Text = "Igraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label10.Location = new System.Drawing.Point(443, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sortiraj";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.label11.Location = new System.Drawing.Point(74, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 38);
            this.label11.TabIndex = 23;
            this.label11.Text = "Takmičari";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.tetrisbackground;
            this.ClientSize = new System.Drawing.Size(885, 707);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.buttonunesi);
            this.Controls.Add(this.textBoxpoeni);
            this.Controls.Add(this.textBoxprezime);
            this.Controls.Add(this.textBoxime);
            this.Controls.Add(this.textBoxvise);
            this.Controls.Add(this.textBoxmanje);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonshowall);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonshowall;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxmanje;
        private System.Windows.Forms.TextBox textBoxvise;
        private System.Windows.Forms.TextBox textBoxime;
        private System.Windows.Forms.TextBox textBoxprezime;
        private System.Windows.Forms.TextBox textBoxpoeni;
        private System.Windows.Forms.Button buttonunesi;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}