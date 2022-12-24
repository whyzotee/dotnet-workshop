namespace Lab3_6._1
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
            this.m_ohm_2 = new System.Windows.Forms.RadioButton();
            this.k_ohm_2 = new System.Windows.Forms.RadioButton();
            this.ohm_2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.k_ohm = new System.Windows.Forms.RadioButton();
            this.m_ohm = new System.Windows.Forms.RadioButton();
            this.ohm = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.Label();
            this.num_1 = new System.Windows.Forms.TextBox();
            this.num_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรมแปลงหน่วยค่าฟารัด";
            // 
            // m_ohm_2
            // 
            this.m_ohm_2.AutoSize = true;
            this.m_ohm_2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ohm_2.ForeColor = System.Drawing.Color.White;
            this.m_ohm_2.Location = new System.Drawing.Point(21, 109);
            this.m_ohm_2.Name = "m_ohm_2";
            this.m_ohm_2.Size = new System.Drawing.Size(152, 34);
            this.m_ohm_2.TabIndex = 6;
            this.m_ohm_2.Text = "mF (MilliFarad)";
            this.m_ohm_2.UseVisualStyleBackColor = true;
            // 
            // k_ohm_2
            // 
            this.k_ohm_2.AutoSize = true;
            this.k_ohm_2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_ohm_2.ForeColor = System.Drawing.Color.White;
            this.k_ohm_2.Location = new System.Drawing.Point(21, 69);
            this.k_ohm_2.Name = "k_ohm_2";
            this.k_ohm_2.Size = new System.Drawing.Size(144, 34);
            this.k_ohm_2.TabIndex = 5;
            this.k_ohm_2.Text = "kF (KiloFarad)";
            this.k_ohm_2.UseVisualStyleBackColor = true;
            // 
            // ohm_2
            // 
            this.ohm_2.AutoSize = true;
            this.ohm_2.Checked = true;
            this.ohm_2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohm_2.ForeColor = System.Drawing.Color.White;
            this.ohm_2.Location = new System.Drawing.Point(21, 29);
            this.ohm_2.Name = "ohm_2";
            this.ohm_2.Size = new System.Drawing.Size(160, 34);
            this.ohm_2.TabIndex = 4;
            this.ohm_2.TabStop = true;
            this.ohm_2.Text = "uF (MicroFarad)";
            this.ohm_2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.k_ohm_2);
            this.groupBox1.Controls.Add(this.m_ohm_2);
            this.groupBox1.Controls.Add(this.ohm_2);
            this.groupBox1.Location = new System.Drawing.Point(298, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.k_ohm);
            this.groupBox2.Controls.Add(this.m_ohm);
            this.groupBox2.Controls.Add(this.ohm);
            this.groupBox2.Location = new System.Drawing.Point(22, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 169);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // k_ohm
            // 
            this.k_ohm.AutoSize = true;
            this.k_ohm.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_ohm.ForeColor = System.Drawing.Color.White;
            this.k_ohm.Location = new System.Drawing.Point(11, 67);
            this.k_ohm.Name = "k_ohm";
            this.k_ohm.Size = new System.Drawing.Size(144, 34);
            this.k_ohm.TabIndex = 5;
            this.k_ohm.Text = "kF (KiloFarad)";
            this.k_ohm.UseVisualStyleBackColor = true;
            // 
            // m_ohm
            // 
            this.m_ohm.AutoSize = true;
            this.m_ohm.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ohm.ForeColor = System.Drawing.Color.White;
            this.m_ohm.Location = new System.Drawing.Point(11, 107);
            this.m_ohm.Name = "m_ohm";
            this.m_ohm.Size = new System.Drawing.Size(152, 34);
            this.m_ohm.TabIndex = 6;
            this.m_ohm.Text = "mF (MilliFarad)";
            this.m_ohm.UseVisualStyleBackColor = true;
            // 
            // ohm
            // 
            this.ohm.AutoSize = true;
            this.ohm.Checked = true;
            this.ohm.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohm.ForeColor = System.Drawing.Color.White;
            this.ohm.Location = new System.Drawing.Point(11, 29);
            this.ohm.Name = "ohm";
            this.ohm.Size = new System.Drawing.Size(160, 34);
            this.ohm.TabIndex = 4;
            this.ohm.TabStop = true;
            this.ohm.Text = "uF (MicroFarad)";
            this.ohm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "แปลงเป็น";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "ค่าฟารัด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "ค่าที่แปลงได้";
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.ForeColor = System.Drawing.Color.White;
            this.value.Location = new System.Drawing.Point(337, 328);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(142, 30);
            this.value.TabIndex = 12;
            this.value.Text = "uF (MicroFarad)";
            // 
            // num_1
            // 
            this.num_1.Font = new System.Drawing.Font("Kanit", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_1.Location = new System.Drawing.Point(202, 272);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(128, 27);
            this.num_1.TabIndex = 13;
            // 
            // num_2
            // 
            this.num_2.Font = new System.Drawing.Font("Kanit", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_2.Location = new System.Drawing.Point(202, 328);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(128, 27);
            this.num_2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "คกลง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(512, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "capacitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton m_ohm_2;
        private System.Windows.Forms.RadioButton k_ohm_2;
        private System.Windows.Forms.RadioButton ohm_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton k_ohm;
        private System.Windows.Forms.RadioButton m_ohm;
        private System.Windows.Forms.RadioButton ohm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.TextBox num_1;
        private System.Windows.Forms.TextBox num_2;
        private System.Windows.Forms.Button button1;
    }
}

