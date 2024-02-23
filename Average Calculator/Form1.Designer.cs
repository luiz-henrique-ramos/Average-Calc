namespace Average_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextPoints1 = new System.Windows.Forms.TextBox();
            this.TextPoints2 = new System.Windows.Forms.TextBox();
            this.TextPoints3 = new System.Windows.Forms.TextBox();
            this.TextPoints4 = new System.Windows.Forms.TextBox();
            this.ButtonComputer = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.MediumBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Points 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Points 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "points 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Average Calculator";
            // 
            // TextPoints1
            // 
            this.TextPoints1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPoints1.Location = new System.Drawing.Point(12, 91);
            this.TextPoints1.MaxLength = 6;
            this.TextPoints1.Name = "TextPoints1";
            this.TextPoints1.Size = new System.Drawing.Size(70, 29);
            this.TextPoints1.TabIndex = 5;
            this.TextPoints1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextPoints1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPoints1_KeyPress);
            // 
            // TextPoints2
            // 
            this.TextPoints2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPoints2.Location = new System.Drawing.Point(12, 147);
            this.TextPoints2.Name = "TextPoints2";
            this.TextPoints2.Size = new System.Drawing.Size(70, 29);
            this.TextPoints2.TabIndex = 6;
            this.TextPoints2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextPoints2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPoints2_KeyPress);
            // 
            // TextPoints3
            // 
            this.TextPoints3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPoints3.Location = new System.Drawing.Point(12, 203);
            this.TextPoints3.Name = "TextPoints3";
            this.TextPoints3.Size = new System.Drawing.Size(70, 29);
            this.TextPoints3.TabIndex = 7;
            this.TextPoints3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextPoints3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPoints3_KeyPress);
            // 
            // TextPoints4
            // 
            this.TextPoints4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPoints4.Location = new System.Drawing.Point(12, 259);
            this.TextPoints4.Name = "TextPoints4";
            this.TextPoints4.Size = new System.Drawing.Size(70, 29);
            this.TextPoints4.TabIndex = 8;
            this.TextPoints4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextPoints4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPoints4_KeyPress);
            // 
            // ButtonComputer
            // 
            this.ButtonComputer.Location = new System.Drawing.Point(114, 147);
            this.ButtonComputer.Name = "ButtonComputer";
            this.ButtonComputer.Size = new System.Drawing.Size(75, 53);
            this.ButtonComputer.TabIndex = 9;
            this.ButtonComputer.Text = "Compute Average";
            this.ButtonComputer.UseVisualStyleBackColor = true;
            this.ButtonComputer.Click += new System.EventHandler(this.ButtonComputer_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(217, 147);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 53);
            this.ButtonDelete.TabIndex = 10;
            this.ButtonDelete.Text = "Clear Points";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // MediumBox
            // 
            this.MediumBox.AutoSize = true;
            this.MediumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumBox.Location = new System.Drawing.Point(229, 96);
            this.MediumBox.Name = "MediumBox";
            this.MediumBox.Size = new System.Drawing.Size(88, 17);
            this.MediumBox.TabIndex = 11;
            this.MediumBox.Text = "                    ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Average Points:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 299);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MediumBox);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonComputer);
            this.Controls.Add(this.TextPoints4);
            this.Controls.Add(this.TextPoints3);
            this.Controls.Add(this.TextPoints2);
            this.Controls.Add(this.TextPoints1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextPoints1;
        private System.Windows.Forms.TextBox TextPoints2;
        private System.Windows.Forms.TextBox TextPoints3;
        private System.Windows.Forms.TextBox TextPoints4;
        private System.Windows.Forms.Button ButtonComputer;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label MediumBox;
        private System.Windows.Forms.Label label6;
    }
}

