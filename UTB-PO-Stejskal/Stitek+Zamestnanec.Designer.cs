namespace UTB_PO_Stejskal
{
    partial class Stitek_Zamestnanec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stitek_Zamestnanec));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxStitek = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxZamestnanec = new System.Windows.Forms.ListBox();
            this.spoj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxStitek);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Štítek";
            // 
            // listBoxStitek
            // 
            this.listBoxStitek.FormattingEnabled = true;
            this.listBoxStitek.ItemHeight = 16;
            this.listBoxStitek.Location = new System.Drawing.Point(19, 28);
            this.listBoxStitek.Name = "listBoxStitek";
            this.listBoxStitek.Size = new System.Drawing.Size(269, 388);
            this.listBoxStitek.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxZamestnanec);
            this.groupBox2.Location = new System.Drawing.Point(486, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zaměstnanec";
            // 
            // listBoxZamestnanec
            // 
            this.listBoxZamestnanec.FormattingEnabled = true;
            this.listBoxZamestnanec.ItemHeight = 16;
            this.listBoxZamestnanec.Location = new System.Drawing.Point(16, 28);
            this.listBoxZamestnanec.Name = "listBoxZamestnanec";
            this.listBoxZamestnanec.Size = new System.Drawing.Size(269, 388);
            this.listBoxZamestnanec.TabIndex = 1;
            // 
            // spoj
            // 
            this.spoj.BackColor = System.Drawing.Color.Red;
            this.spoj.Location = new System.Drawing.Point(323, 187);
            this.spoj.Name = "spoj";
            this.spoj.Size = new System.Drawing.Size(157, 78);
            this.spoj.TabIndex = 3;
            this.spoj.Text = "Napojit!";
            this.spoj.UseVisualStyleBackColor = false;
            this.spoj.Click += new System.EventHandler(this.spoj_Click);
            // 
            // Stitek_Zamestnanec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spoj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stitek_Zamestnanec";
            this.Text = "Stitek_Zamestnanec";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxStitek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxZamestnanec;
        private System.Windows.Forms.Button spoj;
    }
}