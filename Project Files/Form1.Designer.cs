namespace WindowsApplication4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.engfrom = new System.Windows.Forms.RadioButton();
            this.arabfrom = new System.Windows.Forms.RadioButton();
            this.frenchfrom = new System.Windows.Forms.RadioButton();
            this.engto = new System.Windows.Forms.RadioButton();
            this.arabicto = new System.Windows.Forms.RadioButton();
            this.frenchto = new System.Windows.Forms.RadioButton();
            this.quitbutt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "English / Arabic / French Dictionary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Word:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(158, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Translation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // engfrom
            // 
            this.engfrom.AutoSize = true;
            this.engfrom.Location = new System.Drawing.Point(15, 18);
            this.engfrom.Name = "engfrom";
            this.engfrom.Size = new System.Drawing.Size(66, 17);
            this.engfrom.TabIndex = 8;
            this.engfrom.TabStop = true;
            this.engfrom.Text = "English";
            this.engfrom.UseVisualStyleBackColor = true;
            this.engfrom.CheckedChanged += new System.EventHandler(this.engfrom_CheckedChanged_1);
            // 
            // arabfrom
            // 
            this.arabfrom.AutoSize = true;
            this.arabfrom.Location = new System.Drawing.Point(15, 50);
            this.arabfrom.Name = "arabfrom";
            this.arabfrom.Size = new System.Drawing.Size(61, 17);
            this.arabfrom.TabIndex = 9;
            this.arabfrom.TabStop = true;
            this.arabfrom.Text = "Arabic";
            this.arabfrom.UseVisualStyleBackColor = true;
            this.arabfrom.CheckedChanged += new System.EventHandler(this.arabfrom_CheckedChanged);
            // 
            // frenchfrom
            // 
            this.frenchfrom.AutoSize = true;
            this.frenchfrom.Location = new System.Drawing.Point(15, 84);
            this.frenchfrom.Name = "frenchfrom";
            this.frenchfrom.Size = new System.Drawing.Size(64, 17);
            this.frenchfrom.TabIndex = 10;
            this.frenchfrom.TabStop = true;
            this.frenchfrom.Text = "French";
            this.frenchfrom.UseVisualStyleBackColor = true;
            this.frenchfrom.CheckedChanged += new System.EventHandler(this.frenchfrom_CheckedChanged);
            // 
            // engto
            // 
            this.engto.AutoSize = true;
            this.engto.Location = new System.Drawing.Point(17, 22);
            this.engto.Name = "engto";
            this.engto.Size = new System.Drawing.Size(66, 17);
            this.engto.TabIndex = 11;
            this.engto.TabStop = true;
            this.engto.Text = "English";
            this.engto.UseVisualStyleBackColor = true;
            this.engto.CheckedChanged += new System.EventHandler(this.engto_CheckedChanged);
            // 
            // arabicto
            // 
            this.arabicto.AutoSize = true;
            this.arabicto.Location = new System.Drawing.Point(17, 55);
            this.arabicto.Name = "arabicto";
            this.arabicto.Size = new System.Drawing.Size(61, 17);
            this.arabicto.TabIndex = 12;
            this.arabicto.TabStop = true;
            this.arabicto.Text = "Arabic";
            this.arabicto.UseVisualStyleBackColor = true;
            this.arabicto.CheckedChanged += new System.EventHandler(this.arabicto_CheckedChanged);
            // 
            // frenchto
            // 
            this.frenchto.AutoSize = true;
            this.frenchto.Location = new System.Drawing.Point(17, 89);
            this.frenchto.Name = "frenchto";
            this.frenchto.Size = new System.Drawing.Size(64, 17);
            this.frenchto.TabIndex = 13;
            this.frenchto.TabStop = true;
            this.frenchto.Text = "French";
            this.frenchto.UseVisualStyleBackColor = true;
            this.frenchto.CheckedChanged += new System.EventHandler(this.frenchto_CheckedChanged);
            // 
            // quitbutt
            // 
            this.quitbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbutt.Location = new System.Drawing.Point(309, 6);
            this.quitbutt.Name = "quitbutt";
            this.quitbutt.Size = new System.Drawing.Size(130, 34);
            this.quitbutt.TabIndex = 14;
            this.quitbutt.Text = "Quit";
            this.quitbutt.UseVisualStyleBackColor = true;
            this.quitbutt.Click += new System.EventHandler(this.quitbutt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frenchfrom);
            this.groupBox1.Controls.Add(this.arabfrom);
            this.groupBox1.Controls.Add(this.engfrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 121);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translate From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frenchto);
            this.groupBox2.Controls.Add(this.arabicto);
            this.groupBox2.Controls.Add(this.engto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 120);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate To";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(158, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(205, 97);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsApplication4.Properties.Resources.dictnry;
            this.pictureBox2.Location = new System.Drawing.Point(199, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 66);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 311);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.quitbutt);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(29, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 50);
            this.panel3.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(542, 464);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton engfrom;
        private System.Windows.Forms.RadioButton arabfrom;
        private System.Windows.Forms.RadioButton frenchfrom;
        private System.Windows.Forms.RadioButton engto;
        private System.Windows.Forms.RadioButton arabicto;
        private System.Windows.Forms.RadioButton frenchto;
        private System.Windows.Forms.Button quitbutt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

