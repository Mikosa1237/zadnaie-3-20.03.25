namespace zadnaie_3_20._03._25
{
    partial class Form2
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
            this.text_imie = new System.Windows.Forms.TextBox();
            this.text_naz = new System.Windows.Forms.TextBox();
            this.text_wiek = new System.Windows.Forms.TextBox();
            this.but_OK = new System.Windows.Forms.Button();
            this.but_can = new System.Windows.Forms.Button();
            this.combo_stan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_imie
            // 
            this.text_imie.Location = new System.Drawing.Point(58, 27);
            this.text_imie.Name = "text_imie";
            this.text_imie.Size = new System.Drawing.Size(127, 22);
            this.text_imie.TabIndex = 0;
            this.text_imie.TextChanged += new System.EventHandler(this.text_imie_TextChanged);
            // 
            // text_naz
            // 
            this.text_naz.Location = new System.Drawing.Point(58, 68);
            this.text_naz.Name = "text_naz";
            this.text_naz.Size = new System.Drawing.Size(127, 22);
            this.text_naz.TabIndex = 1;
            this.text_naz.TextChanged += new System.EventHandler(this.text_naz_TextChanged);
            // 
            // text_wiek
            // 
            this.text_wiek.Location = new System.Drawing.Point(58, 110);
            this.text_wiek.Name = "text_wiek";
            this.text_wiek.Size = new System.Drawing.Size(127, 22);
            this.text_wiek.TabIndex = 2;
            this.text_wiek.TextChanged += new System.EventHandler(this.text_wiek_TextChanged);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(67, 225);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 8;
            this.but_OK.Text = "Zatwierdź";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_can
            // 
            this.but_can.Location = new System.Drawing.Point(204, 225);
            this.but_can.Name = "but_can";
            this.but_can.Size = new System.Drawing.Size(75, 23);
            this.but_can.TabIndex = 9;
            this.but_can.Text = "Anuluj";
            this.but_can.UseVisualStyleBackColor = true;
            this.but_can.Click += new System.EventHandler(this.but_can_Click);
            // 
            // combo_stan
            // 
            this.combo_stan.FormattingEnabled = true;
            this.combo_stan.Location = new System.Drawing.Point(58, 159);
            this.combo_stan.Name = "combo_stan";
            this.combo_stan.Size = new System.Drawing.Size(127, 24);
            this.combo_stan.TabIndex = 11;
            this.combo_stan.SelectedIndexChanged += new System.EventHandler(this.combo_stan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stanowisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "WIek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Imię";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_stan);
            this.Controls.Add(this.but_can);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.text_wiek);
            this.Controls.Add(this.text_naz);
            this.Controls.Add(this.text_imie);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_imie;
        private System.Windows.Forms.TextBox text_naz;
        private System.Windows.Forms.TextBox text_wiek;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_can;
        private System.Windows.Forms.ComboBox combo_stan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}