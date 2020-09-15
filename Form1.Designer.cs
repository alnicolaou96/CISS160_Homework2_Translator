namespace Homework2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pineapple = new System.Windows.Forms.Button();
            this.Translation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Potato = new System.Windows.Forms.Button();
            this.Star = new System.Windows.Forms.Button();
            this.Kira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pineapple
            // 
            this.Pineapple.Location = new System.Drawing.Point(12, 74);
            this.Pineapple.Name = "Pineapple";
            this.Pineapple.Size = new System.Drawing.Size(75, 23);
            this.Pineapple.TabIndex = 1;
            this.Pineapple.Text = "Pineapple\r\n";
            this.Pineapple.UseVisualStyleBackColor = true;
            this.Pineapple.Click += new System.EventHandler(this.Pineapple_Click);
            // 
            // Translation
            // 
            this.Translation.AutoSize = true;
            this.Translation.Location = new System.Drawing.Point(9, 155);
            this.Translation.Name = "Translation";
            this.Translation.Size = new System.Drawing.Size(16, 13);
            this.Translation.TabIndex = 2;
            this.Translation.Text = "...\r\n";
            this.Translation.Click += new System.EventHandler(this.Translation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select word to translate into french\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Translation:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Potato
            // 
            this.Potato.Location = new System.Drawing.Point(93, 74);
            this.Potato.Name = "Potato";
            this.Potato.Size = new System.Drawing.Size(75, 23);
            this.Potato.TabIndex = 5;
            this.Potato.Text = "Potato";
            this.Potato.UseVisualStyleBackColor = true;
            this.Potato.Click += new System.EventHandler(this.Potato_Click);
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(174, 74);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(75, 23);
            this.Star.TabIndex = 6;
            this.Star.Text = "Star";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // Kira
            // 
            this.Kira.Location = new System.Drawing.Point(255, 74);
            this.Kira.Name = "Kira";
            this.Kira.Size = new System.Drawing.Size(194, 373);
            this.Kira.TabIndex = 7;
            this.Kira.Text = resources.GetString("Kira.Text");
            this.Kira.UseVisualStyleBackColor = true;
            this.Kira.Click += new System.EventHandler(this.Kira_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(463, 459);
            this.Controls.Add(this.Kira);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.Potato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Translation);
            this.Controls.Add(this.Pineapple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Pineapple;
        private System.Windows.Forms.Label Translation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Potato;
        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.Button Kira;
    }
}

