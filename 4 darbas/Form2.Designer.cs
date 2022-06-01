
namespace _4_darbas
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
            this.txtSbar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listDB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butKslap = new System.Windows.Forms.Button();
            this.butRslap = new System.Windows.Forms.Button();
            this.butAlanga = new System.Windows.Forms.Button();
            this.butPnslap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPvar = new System.Windows.Forms.TextBox();
            this.txtPslap = new System.Windows.Forms.TextBox();
            this.butNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTvard = new System.Windows.Forms.TextBox();
            this.butDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSbar
            // 
            this.txtSbar.Location = new System.Drawing.Point(76, 8);
            this.txtSbar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSbar.Name = "txtSbar";
            this.txtSbar.Size = new System.Drawing.Size(245, 20);
            this.txtSbar.TabIndex = 10;
            this.txtSbar.TextChanged += new System.EventHandler(this.txtSbar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ieskoti:";
            // 
            // listDB
            // 
            this.listDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listDB.HideSelection = false;
            this.listDB.Location = new System.Drawing.Point(15, 30);
            this.listDB.Margin = new System.Windows.Forms.Padding(2);
            this.listDB.Name = "listDB";
            this.listDB.Size = new System.Drawing.Size(689, 271);
            this.listDB.TabIndex = 12;
            this.listDB.UseCompatibleStateImageBehavior = false;
            this.listDB.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numeris";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vardas";
            this.columnHeader2.Width = 187;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Slaptazodis";
            this.columnHeader3.Width = 203;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "URL";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Komentaras";
            this.columnHeader5.Width = 123;
            // 
            // butKslap
            // 
            this.butKslap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKslap.Location = new System.Drawing.Point(181, 317);
            this.butKslap.Margin = new System.Windows.Forms.Padding(2);
            this.butKslap.Name = "butKslap";
            this.butKslap.Size = new System.Drawing.Size(166, 30);
            this.butKslap.TabIndex = 16;
            this.butKslap.Text = "Kopijuoti slaptazodi";
            this.butKslap.UseVisualStyleBackColor = true;
            this.butKslap.Click += new System.EventHandler(this.butKslap_Click);
            // 
            // butRslap
            // 
            this.butRslap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRslap.Location = new System.Drawing.Point(11, 317);
            this.butRslap.Margin = new System.Windows.Forms.Padding(2);
            this.butRslap.Name = "butRslap";
            this.butRslap.Size = new System.Drawing.Size(166, 30);
            this.butRslap.TabIndex = 17;
            this.butRslap.Text = "Rodyti slaptazodzius";
            this.butRslap.UseVisualStyleBackColor = true;
            this.butRslap.Click += new System.EventHandler(this.butRslap_Click);
            // 
            // butAlanga
            // 
            this.butAlanga.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAlanga.Location = new System.Drawing.Point(351, 317);
            this.butAlanga.Margin = new System.Windows.Forms.Padding(2);
            this.butAlanga.Name = "butAlanga";
            this.butAlanga.Size = new System.Drawing.Size(166, 30);
            this.butAlanga.TabIndex = 18;
            this.butAlanga.Text = "Atnaujinti langa";
            this.butAlanga.UseVisualStyleBackColor = true;
            this.butAlanga.Click += new System.EventHandler(this.butAlanga_Click);
            // 
            // butPnslap
            // 
            this.butPnslap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPnslap.Location = new System.Drawing.Point(521, 317);
            this.butPnslap.Margin = new System.Windows.Forms.Padding(2);
            this.butPnslap.Name = "butPnslap";
            this.butPnslap.Size = new System.Drawing.Size(183, 30);
            this.butPnslap.TabIndex = 20;
            this.butPnslap.Text = "Prideti nauja slaptazodi";
            this.butPnslap.UseVisualStyleBackColor = true;
            this.butPnslap.Click += new System.EventHandler(this.butPnslap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pakeisti slaptazodi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(37, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "vardas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Slaptazodis:";
            // 
            // txtPvar
            // 
            this.txtPvar.Location = new System.Drawing.Point(100, 406);
            this.txtPvar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPvar.Name = "txtPvar";
            this.txtPvar.Size = new System.Drawing.Size(143, 20);
            this.txtPvar.TabIndex = 23;
            // 
            // txtPslap
            // 
            this.txtPslap.Location = new System.Drawing.Point(100, 437);
            this.txtPslap.Margin = new System.Windows.Forms.Padding(2);
            this.txtPslap.Name = "txtPslap";
            this.txtPslap.Size = new System.Drawing.Size(143, 20);
            this.txtPslap.TabIndex = 24;
            // 
            // butNew
            // 
            this.butNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNew.Location = new System.Drawing.Point(41, 479);
            this.butNew.Margin = new System.Windows.Forms.Padding(2);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(171, 26);
            this.butNew.TabIndex = 25;
            this.butNew.Text = "Atnaujinti ";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(306, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Trinti infromacija apie slaptazodi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(306, 405);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Vardas";
            // 
            // txtTvard
            // 
            this.txtTvard.Location = new System.Drawing.Point(366, 406);
            this.txtTvard.Margin = new System.Windows.Forms.Padding(2);
            this.txtTvard.Name = "txtTvard";
            this.txtTvard.Size = new System.Drawing.Size(170, 20);
            this.txtTvard.TabIndex = 28;
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butDel.Location = new System.Drawing.Point(336, 475);
            this.butDel.Margin = new System.Windows.Forms.Padding(2);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(171, 30);
            this.butDel.TabIndex = 29;
            this.butDel.Text = "Trinti";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 568);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.txtTvard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.txtPslap);
            this.Controls.Add(this.txtPvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butPnslap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butAlanga);
            this.Controls.Add(this.butRslap);
            this.Controls.Add(this.butKslap);
            this.Controls.Add(this.listDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSbar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listDB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button butKslap;
        private System.Windows.Forms.Button butRslap;
        private System.Windows.Forms.Button butAlanga;
        private System.Windows.Forms.Button butPnslap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPvar;
        private System.Windows.Forms.TextBox txtPslap;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTvard;
        private System.Windows.Forms.Button butDel;
    }
}