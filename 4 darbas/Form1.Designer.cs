
namespace _4_darbas
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
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.txtSlap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butPrisijungti = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(155, 62);
            this.txtVardas.Margin = new System.Windows.Forms.Padding(2);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(194, 20);
            this.txtVardas.TabIndex = 4;
            // 
            // txtSlap
            // 
            this.txtSlap.Location = new System.Drawing.Point(155, 108);
            this.txtSlap.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlap.Name = "txtSlap";
            this.txtSlap.Size = new System.Drawing.Size(194, 20);
            this.txtSlap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prisijungimo vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Slaptazodis";
            // 
            // butPrisijungti
            // 
            this.butPrisijungti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.butPrisijungti.Location = new System.Drawing.Point(186, 142);
            this.butPrisijungti.Margin = new System.Windows.Forms.Padding(2);
            this.butPrisijungti.Name = "butPrisijungti";
            this.butPrisijungti.Size = new System.Drawing.Size(122, 49);
            this.butPrisijungti.TabIndex = 8;
            this.butPrisijungti.Text = "Prisijungti";
            this.butPrisijungti.UseVisualStyleBackColor = true;
            this.butPrisijungti.Click += new System.EventHandler(this.butPrisijungti_Click);
            // 
            // butReg
            // 
            this.butReg.Location = new System.Drawing.Point(255, 223);
            this.butReg.Margin = new System.Windows.Forms.Padding(2);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(96, 30);
            this.butReg.TabIndex = 9;
            this.butReg.Text = "Registruoti";
            this.butReg.UseVisualStyleBackColor = true;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Norint uzsiregistruoti,  iveskite duomenis auksciau";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butPrisijungti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSlap);
            this.Controls.Add(this.txtVardas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.TextBox txtSlap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butPrisijungti;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.Label label3;
    }
}

