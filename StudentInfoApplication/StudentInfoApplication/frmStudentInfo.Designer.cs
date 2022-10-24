namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentInfo));
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb1.Font = new System.Drawing.Font("Helvetica LT Std", 12F);
            this.lb1.ForeColor = System.Drawing.Color.LightGray;
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 18;
            this.lb1.Location = new System.Drawing.Point(14, 137);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 108);
            this.lb1.TabIndex = 0;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.lb3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb3.Font = new System.Drawing.Font("Helvetica LT Std", 12F);
            this.lb3.ForeColor = System.Drawing.Color.LightGray;
            this.lb3.FormattingEnabled = true;
            this.lb3.ItemHeight = 18;
            this.lb3.Location = new System.Drawing.Point(146, 137);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(126, 108);
            this.lb3.TabIndex = 1;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb2.Font = new System.Drawing.Font("Helvetica LT Std", 12F);
            this.lb2.ForeColor = System.Drawing.Color.LightGray;
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 18;
            this.lb2.Location = new System.Drawing.Point(285, 137);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 108);
            this.lb2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std", 11F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica LT Std", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(146, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica LT Std", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(283, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name *";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Helvetica LT Std", 14.25F);
            this.id.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.id.Location = new System.Drawing.Point(13, 108);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(120, 23);
            this.id.TabIndex = 6;
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.ln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ln.Font = new System.Drawing.Font("Helvetica LT Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ln.Location = new System.Drawing.Point(146, 108);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(126, 23);
            this.ln.TabIndex = 7;
            // 
            // fn
            // 
            this.fn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.fn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fn.Font = new System.Drawing.Font("Helvetica LT Std", 14.25F);
            this.fn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.fn.Location = new System.Drawing.Point(285, 108);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(120, 23);
            this.fn.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(-4, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 5);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica LT Std", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Helvetica LT Std", 25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(145, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica LT Std Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(134)))));
            this.label6.Location = new System.Drawing.Point(331, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Application";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica LT Std Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(134)))));
            this.label7.Location = new System.Drawing.Point(1, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hyx 2.0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.button1.BackgroundImage = global::StudentInfoApplication.Properties.Resources._231;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Helvetica LT Std", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(302, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(424, 312);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentInfo";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

