namespace CSharp_bai7
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtduonglich = new System.Windows.Forms.TextBox();
            this.txtamlich = new System.Windows.Forms.TextBox();
            this.bttinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Can Chi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dương Lịch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Âm Lịch";
            // 
            // txtduonglich
            // 
            this.txtduonglich.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduonglich.Location = new System.Drawing.Point(480, 124);
            this.txtduonglich.Name = "txtduonglich";
            this.txtduonglich.Size = new System.Drawing.Size(341, 46);
            this.txtduonglich.TabIndex = 3;
            this.txtduonglich.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtamlich
            // 
            this.txtamlich.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamlich.Location = new System.Drawing.Point(480, 212);
            this.txtamlich.Name = "txtamlich";
            this.txtamlich.Size = new System.Drawing.Size(341, 46);
            this.txtamlich.TabIndex = 4;
            // 
            // bttinh
            // 
            this.bttinh.Font = new System.Drawing.Font("Microsoft Tai Le", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttinh.Location = new System.Drawing.Point(401, 358);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(224, 119);
            this.bttinh.TabIndex = 5;
            this.bttinh.Text = "Tính";
            this.bttinh.UseVisualStyleBackColor = true;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 556);
            this.Controls.Add(this.bttinh);
            this.Controls.Add(this.txtamlich);
            this.Controls.Add(this.txtduonglich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtduonglich;
        private System.Windows.Forms.TextBox txtamlich;
        private System.Windows.Forms.Button bttinh;
    }
}

