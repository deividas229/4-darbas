﻿
namespace _4_darbas
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVard = new System.Windows.Forms.TextBox();
            this.txtSlap = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtKom = new System.Windows.Forms.TextBox();
            this.butPri = new System.Windows.Forms.Button();
            this.butGslap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slaptazodis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Komentaras";
            // 
            // txtVard
            // 
            this.txtVard.Location = new System.Drawing.Point(138, 11);
            this.txtVard.Margin = new System.Windows.Forms.Padding(2);
            this.txtVard.Name = "txtVard";
            this.txtVard.Size = new System.Drawing.Size(222, 20);
            this.txtVard.TabIndex = 6;
            // 
            // txtSlap
            // 
            this.txtSlap.Location = new System.Drawing.Point(138, 47);
            this.txtSlap.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlap.Name = "txtSlap";
            this.txtSlap.Size = new System.Drawing.Size(222, 20);
            this.txtSlap.TabIndex = 7;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(138, 84);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(222, 20);
            this.txtURL.TabIndex = 8;
            // 
            // txtKom
            // 
            this.txtKom.Location = new System.Drawing.Point(138, 119);
            this.txtKom.Margin = new System.Windows.Forms.Padding(2);
            this.txtKom.Name = "txtKom";
            this.txtKom.Size = new System.Drawing.Size(222, 20);
            this.txtKom.TabIndex = 9;
            // 
            // butPri
            // 
            this.butPri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPri.Location = new System.Drawing.Point(235, 163);
            this.butPri.Margin = new System.Windows.Forms.Padding(2);
            this.butPri.Name = "butPri";
            this.butPri.Size = new System.Drawing.Size(125, 40);
            this.butPri.TabIndex = 10;
            this.butPri.Text = "Prideti";
            this.butPri.UseVisualStyleBackColor = true;
            this.butPri.Click += new System.EventHandler(this.butPri_Click);
            // 
            // butGslap
            // 
            this.butGslap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGslap.Location = new System.Drawing.Point(28, 163);
            this.butGslap.Margin = new System.Windows.Forms.Padding(2);
            this.butGslap.Name = "butGslap";
            this.butGslap.Size = new System.Drawing.Size(161, 40);
            this.butGslap.TabIndex = 11;
            this.butGslap.Text = "Generuoti slaptazodi";
            this.butGslap.UseVisualStyleBackColor = true;
            this.butGslap.Click += new System.EventHandler(this.butGslap_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 237);
            this.Controls.Add(this.butGslap);
            this.Controls.Add(this.butPri);
            this.Controls.Add(this.txtKom);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtSlap);
            this.Controls.Add(this.txtVard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVard;
        private System.Windows.Forms.TextBox txtSlap;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtKom;
        private System.Windows.Forms.Button butPri;
        private System.Windows.Forms.Button butGslap;
    }
}