namespace UTB_PO_Stejskal
{
    partial class Hlavniokno
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hlavniokno));
            this.tvorbapredmetu = new System.Windows.Forms.Button();
            this.tvorbaskupiny = new System.Windows.Forms.Button();
            this.tvorbazamestnance = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvorbapredmetu
            // 
            this.tvorbapredmetu.Location = new System.Drawing.Point(12, 12);
            this.tvorbapredmetu.Name = "tvorbapredmetu";
            this.tvorbapredmetu.Size = new System.Drawing.Size(153, 60);
            this.tvorbapredmetu.TabIndex = 0;
            this.tvorbapredmetu.Text = "Tvorba předmětu";
            this.tvorbapredmetu.UseVisualStyleBackColor = true;
            this.tvorbapredmetu.Click += new System.EventHandler(this.tvorbapredmetu_Click);
            // 
            // tvorbaskupiny
            // 
            this.tvorbaskupiny.Location = new System.Drawing.Point(171, 12);
            this.tvorbaskupiny.Name = "tvorbaskupiny";
            this.tvorbaskupiny.Size = new System.Drawing.Size(153, 60);
            this.tvorbaskupiny.TabIndex = 1;
            this.tvorbaskupiny.Text = "Tvorba studijní skupiny";
            this.tvorbaskupiny.UseVisualStyleBackColor = true;
            this.tvorbaskupiny.Click += new System.EventHandler(this.tvorbaskupiny_Click);
            // 
            // tvorbazamestnance
            // 
            this.tvorbazamestnance.Location = new System.Drawing.Point(330, 12);
            this.tvorbazamestnance.Name = "tvorbazamestnance";
            this.tvorbazamestnance.Size = new System.Drawing.Size(153, 60);
            this.tvorbazamestnance.TabIndex = 2;
            this.tvorbazamestnance.Text = "Tvorba zaměstnance";
            this.tvorbazamestnance.UseVisualStyleBackColor = true;
            this.tvorbazamestnance.Click += new System.EventHandler(this.tvorbazamestnance_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vypsání štítků";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Propojení předmětů a skupin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Hlavniokno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 144);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tvorbazamestnance);
            this.Controls.Add(this.tvorbaskupiny);
            this.Controls.Add(this.tvorbapredmetu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hlavniokno";
            this.Text = "PO-Stejskal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tvorbapredmetu;
        private System.Windows.Forms.Button tvorbaskupiny;
        private System.Windows.Forms.Button tvorbazamestnance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

