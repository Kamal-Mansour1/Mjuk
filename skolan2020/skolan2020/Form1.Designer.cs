
namespace skolan2020
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
            this.btnSkapaElev = new System.Windows.Forms.Button();
            this.btnIfMyndig = new System.Windows.Forms.Button();
            this.btnBeräknaBMI = new System.Windows.Forms.Button();
            this.txtFörnamn = new System.Windows.Forms.TextBox();
            this.txtLängd = new System.Windows.Forms.TextBox();
            this.btnHelaNamnet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEfternamn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtVikt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSkapaElev
            // 
            this.btnSkapaElev.Location = new System.Drawing.Point(80, 308);
            this.btnSkapaElev.Name = "btnSkapaElev";
            this.btnSkapaElev.Size = new System.Drawing.Size(75, 23);
            this.btnSkapaElev.TabIndex = 0;
            this.btnSkapaElev.Text = "Skapa Elev";
            this.btnSkapaElev.UseVisualStyleBackColor = true;
            this.btnSkapaElev.Click += new System.EventHandler(this.btnSkapaElev_Click);
            // 
            // btnIfMyndig
            // 
            this.btnIfMyndig.Location = new System.Drawing.Point(360, 319);
            this.btnIfMyndig.Name = "btnIfMyndig";
            this.btnIfMyndig.Size = new System.Drawing.Size(75, 23);
            this.btnIfMyndig.TabIndex = 1;
            this.btnIfMyndig.Text = "Är Myndig?";
            this.btnIfMyndig.UseVisualStyleBackColor = true;
            this.btnIfMyndig.Click += new System.EventHandler(this.btnIfMyndig_Click);
            // 
            // btnBeräknaBMI
            // 
            this.btnBeräknaBMI.Location = new System.Drawing.Point(360, 348);
            this.btnBeräknaBMI.Name = "btnBeräknaBMI";
            this.btnBeräknaBMI.Size = new System.Drawing.Size(75, 23);
            this.btnBeräknaBMI.TabIndex = 2;
            this.btnBeräknaBMI.Text = "BeräknaBMI";
            this.btnBeräknaBMI.UseVisualStyleBackColor = true;
            this.btnBeräknaBMI.Click += new System.EventHandler(this.btnBeräknaBMI_Click);
            // 
            // txtFörnamn
            // 
            this.txtFörnamn.Location = new System.Drawing.Point(80, 121);
            this.txtFörnamn.Name = "txtFörnamn";
            this.txtFörnamn.Size = new System.Drawing.Size(100, 20);
            this.txtFörnamn.TabIndex = 3;
            // 
            // txtLängd
            // 
            this.txtLängd.Location = new System.Drawing.Point(80, 188);
            this.txtLängd.Name = "txtLängd";
            this.txtLängd.Size = new System.Drawing.Size(100, 20);
            this.txtLängd.TabIndex = 4;
            // 
            // btnHelaNamnet
            // 
            this.btnHelaNamnet.Location = new System.Drawing.Point(173, 404);
            this.btnHelaNamnet.Name = "btnHelaNamnet";
            this.btnHelaNamnet.Size = new System.Drawing.Size(129, 23);
            this.btnHelaNamnet.TabIndex = 6;
            this.btnHelaNamnet.Text = "Få ut Hela namnet";
            this.btnHelaNamnet.UseVisualStyleBackColor = true;
            this.btnHelaNamnet.Click += new System.EventHandler(this.btnHelaNamnet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Förnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Längd:";
            // 
            // txtEfternamn
            // 
            this.txtEfternamn.Location = new System.Drawing.Point(80, 157);
            this.txtEfternamn.Name = "txtEfternamn";
            this.txtEfternamn.Size = new System.Drawing.Size(100, 20);
            this.txtEfternamn.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "FödelseDatum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtVikt
            // 
            this.txtVikt.Location = new System.Drawing.Point(80, 224);
            this.txtVikt.Name = "txtVikt";
            this.txtVikt.Size = new System.Drawing.Size(100, 20);
            this.txtVikt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vikt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVikt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEfternamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelaNamnet);
            this.Controls.Add(this.txtLängd);
            this.Controls.Add(this.txtFörnamn);
            this.Controls.Add(this.btnBeräknaBMI);
            this.Controls.Add(this.btnIfMyndig);
            this.Controls.Add(this.btnSkapaElev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkapaElev;
        private System.Windows.Forms.Button btnIfMyndig;
        private System.Windows.Forms.Button btnBeräknaBMI;
        private System.Windows.Forms.TextBox txtFörnamn;
        private System.Windows.Forms.TextBox txtLängd;
        private System.Windows.Forms.Button btnHelaNamnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEfternamn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtVikt;
        private System.Windows.Forms.Label label5;
    }
}

