namespace WindowsFormsApp1
{
    partial class Form4
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
            this.Masiv = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Masiv
            // 
            this.Masiv.AutoSize = true;
            this.Masiv.Location = new System.Drawing.Point(44, 48);
            this.Masiv.Name = "Masiv";
            this.Masiv.Size = new System.Drawing.Size(163, 25);
            this.Masiv.TabIndex = 0;
            this.Masiv.Text = "Масив з файлу";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(44, 143);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(222, 25);
            this.Result.TabIndex = 1;
            this.Result.Text = "Результуючий масив";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Masiv);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Masiv;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}