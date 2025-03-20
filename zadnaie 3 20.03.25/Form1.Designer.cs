namespace zadnaie_3_20._03._25
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_add = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_zap = new System.Windows.Forms.Button();
            this.but_od = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(375, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(393, 36);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 1;
            this.but_add.Text = "Dodaj";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(393, 82);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(75, 23);
            this.but_del.TabIndex = 2;
            this.but_del.Text = "Usuń";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_zap
            // 
            this.but_zap.Location = new System.Drawing.Point(12, 273);
            this.but_zap.Name = "but_zap";
            this.but_zap.Size = new System.Drawing.Size(118, 23);
            this.but_zap.TabIndex = 3;
            this.but_zap.Text = "Zapis do csv";
            this.but_zap.UseVisualStyleBackColor = true;
            this.but_zap.Click += new System.EventHandler(this.but_zap_Click);
            // 
            // but_od
            // 
            this.but_od.Location = new System.Drawing.Point(177, 273);
            this.but_od.Name = "but_od";
            this.but_od.Size = new System.Drawing.Size(124, 23);
            this.but_od.TabIndex = 4;
            this.but_od.Text = "Odczyt z csv";
            this.but_od.UseVisualStyleBackColor = true;
            this.but_od.Click += new System.EventHandler(this.but_od_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 370);
            this.Controls.Add(this.but_od);
            this.Controls.Add(this.but_zap);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_zap;
        private System.Windows.Forms.Button but_od;
    }
}

