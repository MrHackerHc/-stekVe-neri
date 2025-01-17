using System;

namespace İstek
{
    partial class list
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.veris = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.IdDelete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button2.Location = new System.Drawing.Point(644, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Verileri Yükle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.veriload);
            // 
            // veris
            // 
            this.veris.Location = new System.Drawing.Point(12, 12);
            this.veris.Name = "veris";
            this.veris.Size = new System.Drawing.Size(776, 383);
            this.veris.TabIndex = 3;
            this.veris.Text = "";
            this.veris.TextChanged += new System.EventHandler(this.veri_TextChanged_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button3.Location = new System.Drawing.Point(215, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Silencek Id";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.sil);
            // 
            // IdDelete
            // 
            this.IdDelete.Location = new System.Drawing.Point(380, 409);
            this.IdDelete.Name = "IdDelete";
            this.IdDelete.Size = new System.Drawing.Size(103, 22);
            this.IdDelete.TabIndex = 5;
            this.IdDelete.TextChanged += new System.EventHandler(this.IdDelete_TextChanged_1);
            this.IdDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdSilText);
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.veris);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list";
            this.Load += new System.EventHandler(this.list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox veris;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox IdDelete;
        private readonly EventHandler IdDelete_TextChanged;
    }
}